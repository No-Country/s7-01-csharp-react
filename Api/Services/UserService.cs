using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
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

        public async Task<string> RegisterAsync(RegistroDTO model)
        {
            Usuario user = new Usuario()
            {
                Nombre = model.Nombre,
                Email = model.Email,
            };

            user.Password = _passwordHasher.HashPassword(user, model.Password);

            var usuarioExiste = await _repository.FindEmail(u => u.Email == model.Email);

            if (usuarioExiste == null)
            {
                var rolPredeterminado = await _roleRepository.FindRoleName(r => r.Nombre == "User");
                try
                {
                    user.Role = rolPredeterminado;
                    await _repository.AddAsync(user);
                    await _repository.SaveAsync();
                    JwtSecurityToken jwtSecurityToken = CreateJwtToken(user);
                    string Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
                    return $"El usuario {model.Nombre} ha sido registrado exitosamente\n {Token}";
                }
                catch (Exception ex)
                {
                    var message = ex.Message;
                    return $"Error: {message}";
                }

            }
            else
            {
                return $"El usuario con {model.Nombre} ya se encuentra registrado.";
            }
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
