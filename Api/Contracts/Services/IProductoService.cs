using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.ProductoDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Contracts.Services
{
    public interface IProductoService
    {
        Task<ResponseDTO> GetAllProductosAsync();
        Task<ResponseDTO> GetProductoByIdAsync(int id);
        Task<ResponseDTO> GetProductosByVeterinariaIdAsync(int id);
        Task<ResponseDTO> AddProductoAsync(ProductoDTO productoDTO);
        Task<ResponseDTO> UpdateProductoAsync(int id, ProductoDTO productoDTO);
        Task<ResponseDTO> DeleteProductoAsync(int id);
        
    }
}
