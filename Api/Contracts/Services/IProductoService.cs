using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.ProductoDTOs;

namespace s7_01.Api.Contracts.Services
{
    public interface IProductoService
    {
        ResponseDTO GetAllAsync();
        ResponseDTO GetByIdAsync(int id);
        ResponseDTO AddAsync(ProductoDTO productoDto);
        ResponseDTO UpdateAsync(int id, ProductoDTO productoDto);
        

    }
}
