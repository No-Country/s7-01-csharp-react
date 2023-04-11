using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.ProductoDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Services
{
    public class ProductoService : IProductoService
    {

        private readonly IGenericRepository<Producto> _productoRepository;

        public ProductoService(IGenericRepository<Producto> productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public ResponseDTO GetAllProductos()
        {
            throw new NotImplementedException();
        }

        public ResponseDTO GetProductoByIdAsync(int id)
        {
            try
            {
                var producto = _productoRepository.GetByIdAsync(id);

                if (producto == null)
                {
                    return new ResponseDTO
                    {
                        Success = false,
                        Result = null,
                        Message = $"No se encontró el producto con el id {id}.",
                        StatusCode = 404
                    };
                }

                var productoDto = new ProductoDTO
                {
                    Id = producto.Id,
                    VeterinariaId = producto.VeterinariaId,
                    Costo = producto.Costo,
                    Nombre = producto.Nombre
                };

                return new ResponseDTO
                {
                    Success = true,
                    Result = productoDto,
                    Message = $"Producto con id {id} encontrado exitosamente.",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = ex.Message,
                    StatusCode = 500
                };
            }
        }

        public ResponseDTO AddProducto(ProductoDTO productoDto)
        {
            try
            {
                var producto = new Producto
                {
                    VeterinariaId = productoDto.VeterinariaId,
                    Costo = productoDto.Costo,
                    Nombre = productoDto.Nombre
                };

                _productoRepository.Add(producto);
                _productoRepository.Save();

                return new ResponseDTO
                {
                    Success = true,
                    Result = producto.Id,
                    Message = "Producto agregado exitosamente.",
                    StatusCode = 201
                };
            }
            catch (Exception ex)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = ex.Message,
                    StatusCode = 500
                };
            }
        }                         

        public ResponseDTO UpdateProducto(int id, ProductoDTO productoDto)
        {
            throw new NotImplementedException();
        }

    }
}
