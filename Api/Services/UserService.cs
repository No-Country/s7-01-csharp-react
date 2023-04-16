using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using s7_01.Api.Common;
using s7_01.Api.Common.DTOs.AuthDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Helpers;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace s7_01.Api.Services
{
    public class UserService : IUserService
    {
        private readonly IUsuarioRepository _repository;
        private readonly IRoleRepository _roleRepository;
        private readonly IPasswordHasher<Usuario> _passwordHasher;
        private readonly JWT _jwt;
        public UserService(IUsuarioRepository repository, IRoleRepository roleRepository ,IPasswordHasher<Usuario> passwordHasher, IOptions<JWT> jwt)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
            _roleRepository = roleRepository;
            _jwt = jwt.Value;
        }

        public async Task<ResponseDTO> RegisterAsync(RegistroDTO model)
        {
            var response = new ResponseDTO
            {
                Success = true,
                Result = "",
                Message = "",
                StatusCode = 200
            };
            Usuario user = new Usuario()
            {
                Nombre = model.Nombre,
                Email = model.Email,
            };

            user.Password = _passwordHasher.HashPassword(user, model.Password);

            var usuarioExiste = await _repository.FindEmail(u => u.Email == model.Email);

            if (usuarioExiste == null)
            {
                var rolPredeterminado = await _roleRepository.FindRoleName(r => r.Nombre == Roles.rol_predeterminado.ToString());
                try
                {
                    user.Role = rolPredeterminado;
                    await _repository.AddAsync(user);
                    await _repository.SaveAsync();
                    JwtSecurityToken jwtSecurityToken = CreateJwtToken(user);
                    string Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
                    var userSucces = new SuccessRegisterDTOs()
                    {
                        Nombre = model.Nombre,
                        Email = model.Email,
                        Token = Token
                    };
                    response.Message = "Registro Exitoso";
                    response.Result = userSucces;
                    response.StatusCode = 201;
                    return response;
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.Result = ex.Message;
                    response.Message = "Servel Internal Error";
                    response.StatusCode = 500;
                    return response;
                }

            }
            else
            {
                response.Success = false;
                response.Message = "Ya existe un usuario con el email registrado";
                response.StatusCode = 400;
                return response;
            }
        }

        public async Task<ResponseDTO> LoginAsync(LoginDTO model)
        {
            var success = new SuccessLoginDTO();
            var response = new ResponseDTO
            {
                Success = false,
                Result = "",
                Message = "",
                StatusCode = 500
            };

            var usuarioExiste = await _repository.FindEmail(u => u.Email == model.Email);
            if (usuarioExiste == null)
            {
                response.Result = null;
                response.Message = "No existe un usuario con el email ingresado";
                response.StatusCode = 400;
                return response;
            }

            var resultado = _passwordHasher.VerifyHashedPassword(usuarioExiste, usuarioExiste.Password, model.Password);
            if (resultado == PasswordVerificationResult.Success)
            {
                success.Nombre = usuarioExiste.Nombre;
                success.Email = usuarioExiste.Email;
                success.Role= usuarioExiste.Role;
                JwtSecurityToken jwtSecurityToken = CreateJwtToken(usuarioExiste);
                success.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

                response.Result = success;
                response.Message = "Inicio de Sesion exitoso";
                response.StatusCode = 200;
                response.Success = true;

                return response;
            }

            response.Result = null;
            response.StatusCode = 400;
            response.Message = "Credenciales incorrectas";

            return response;
        }

        public JwtSecurityToken CreateJwtToken(Usuario usuario)
        {
            var roles = usuario.Role;
            var roleClaims = new List<Claim>();

            roleClaims.Add(new Claim("roles", roles.Nombre));

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, usuario.Nombre),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, usuario.Email),
                new Claim("uid", usuario.Id.ToString())
            }
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwt.DurationInMinutes),
                signingCredentials: signingCredentials
                );
            return jwtSecurityToken;
        }

    }
}
