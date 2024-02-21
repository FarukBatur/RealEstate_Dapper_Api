using RealEstate_Dapper_.Dtos.ProductDtos;

namespace RealEstate_Dapper_.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoriesAsync();
    }
}
