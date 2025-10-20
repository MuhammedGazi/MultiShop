using MultiShop.Catalog.Dtos.ProductImageDtos;

namespace MultiShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task<List<ResultProductImageDto>> GetAllProductImagesAsync();
        Task<GetByIdProductImageDto> GetByIdProductImageAsync(string id);
        Task CreateProductImage(CreateProductImageDto createProductImageDto);
        Task UpdateProductImage(UpdateProductImageDto updateProductImageDto);
        Task DeleteProductImage(string id);
    }
}
