using Dapper;
using RealEstate_Dapper_.Models.DapperContext;
using RealEstate_Dapper_Api.Dtos.TestimonialDtos;

namespace RealEstate_Dapper_Api.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultTestimonialDtos>> GetAllTestimonialAsync()
        {
            string query = "Select *From Testimonial";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDtos>(query);
                return values.ToList();
            }
        }
    }
}
