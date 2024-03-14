namespace RealEstate_Dapper_Api.Dtos.ServicesDtos
{
    public class GetByIdServiceDto
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public bool ServiceStatus { get; set; }
    }
}
