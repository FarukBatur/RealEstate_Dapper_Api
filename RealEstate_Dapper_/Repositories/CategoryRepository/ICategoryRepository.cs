using RealEstate_Dapper_.Dtos.CategoryDtos;

namespace RealEstate_Dapper_.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDto categoryDto);
    }
}
