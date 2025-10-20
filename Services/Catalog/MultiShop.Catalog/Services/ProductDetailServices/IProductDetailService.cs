using MultiShop.Catalog.Dtos.ProductDetailDtos;

namespace MultiShop.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService
    {
        Task<List<ResultProductDetailDto>> GetAllProductDetailAsync();
        Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(string id);
        Task CreateProductAsync(CreateProductDetailDto createProductDetailDto);
        Task UpdateProductAsync(UpdateProductDetailDto updateProductDetailDto);
        Task DeleteProductAsync(string id);

    }
}
