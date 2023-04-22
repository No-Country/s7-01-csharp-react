using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.Common.DTOs.ProductoDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IGenericRepository<Producto> _productoRepository;
        private readonly IProductoRepository _prodRepository;

        public ProductoService(IGenericRepository<Producto> productoRepository, IProductoRepository prodRepository)
        {
            _productoRepository = productoRepository;
            _prodRepository = prodRepository;
        }

        public async Task<ResponseDTO> GetAllProductosAsync()
        {
            var productos = await _productoRepository.GetAllAsync();

            var response = new ResponseDTO
            {
                Success = true,
                Result = productos,
                Message = "Lista de productos obtenida correctamente",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> GetProductoByIdAsync(int id)
        {
            var producto = await _productoRepository.GetByIdAsync(id);

            if (producto == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "El producto no existe",
                    StatusCode = 404
                };
            }

            var response = new ResponseDTO
            {
                Success = true,
                Result = producto,
                Message = "Producto obtenido correctamente",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> AddProductoAsync(ProductoDTO productoDTO)
        {
            var producto = new Producto
            {
                VeterinariaId = productoDTO.VeterinariaId,                          
                Costo = productoDTO.Costo,
                Nombre = productoDTO.Nombre
            };

            await _productoRepository.AddAsync(producto);
            await _productoRepository.SaveAsync();

            var response = new ResponseDTO
            {
                Success = true,
                Result = producto,
                Message = "Producto agregado correctamente",
                StatusCode = 201
            };

            return response;
        }
        
        public async Task<ResponseDTO> UpdateProductoAsync(int id, ProductoDTO productoDTO)
        {
            var producto = await _productoRepository.GetByIdAsync(id);

            if (producto == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "El producto no existe",
                    StatusCode = 404
                };
            }

            producto.VeterinariaId = productoDTO.VeterinariaId;
            producto.Costo = productoDTO.Costo;
            producto.Nombre = productoDTO.Nombre;

            await _productoRepository.UpdateAsync(producto);

            var response = new ResponseDTO
            {
                Success = true,
                Result = producto,
                Message = "Producto actualizado correctamente",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> DeleteProductoAsync(int id)
        {
            var producto = await _productoRepository.GetByIdAsync(id);

            if (producto == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "El producto no existe",
                    StatusCode = 404
                };
            }

            _productoRepository.Remove(producto);
            await _productoRepository.SaveAsync();

            var response = new ResponseDTO
            {
                Success = true,
                Result = producto,
                Message = "Producto eliminado correctamente",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> GetProductosByVeterinariaIdAsync(int id)
        {
            var productos = await _prodRepository.GetProductosByVeterinariaIdAsync(id);

            if (productos == null || !productos.Any())
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "La veterinaria no tiene productos registrados",
                    StatusCode = 404
                };
            }

            var response = new ResponseDTO
            {
                Success = true,
                Result = productos,
                Message = "Lista de productos obtenida correctamente",
                StatusCode = 200
            };

            return response;
        }




        public async Task<ResponseDTO> AddRangeAsync(IEnumerable<ProductoDTO> productoDTOs)
        {
            var productos = new List<Producto>();
            foreach (var dto in productoDTOs)
            {
                var producto = new Producto
                {
                    VeterinariaId = dto.VeterinariaId,
                    Nombre = dto.Nombre,
                    Costo = dto.Costo
                };
                productos.Add(producto);
            }

            var response = new ResponseDTO();
            try
            {
                await _productoRepository.AddRangeAsync(productos);
                await _productoRepository.SaveAsync();
                response.Success = true;
                response.StatusCode = 201;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.StatusCode = 500;
                response.Message = ex.Message;
            }
            return response;
        }








    }


}
