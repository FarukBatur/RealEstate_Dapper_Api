using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ServicesDtos;
using RealEstate_Dapper_Api.Repositories.ServiceRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var value = await _serviceRepository.GetAllServiceAsync();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            _serviceRepository.CreateService(createServiceDto);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            _serviceRepository.DeleteService(id);
            return Ok("Çalışan Başarılı Bir Şekilde Silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            _serviceRepository.UpdateService(updateServiceDto);
            return Ok("Çalışan Başarıyla Güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var values = await _serviceRepository.GetServiceAsync(id);
            return Ok(values);
        }
    }
}
