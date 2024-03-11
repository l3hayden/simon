using L3Pricing.Entities;

namespace L3Pricing.Services
{
    public interface IServiceService
    {
        Task<List<Service>> GetAllServices();
        Task<Service> AddService(Service service);
        Task<Service> GetServiceById(int id);
        Task UpdateService(Service service);
        Task DeleteServiceById(int id);
    }
}
