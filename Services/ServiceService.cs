using L3Pricing.Data;
using L3Pricing.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace L3Pricing.Services
{
    public class ServiceService : IServiceService
    {
        private readonly DataContext _context;

        public ServiceService(DataContext context)
        {
            _context = context;
        }

        public async Task<Service> AddService(Service service)
        {
            _context.Services.Add(service);
            await _context.SaveChangesAsync();

            return service;
        }

        public async Task<List<Service>> GetAllServices()
        {
            var services = await _context.Services.ToListAsync();
            return services;
        }
        public async Task<Service> GetServiceById(int id)
        {
            return await _context.Services.FirstOrDefaultAsync(s => s.Id == id);
        }
        public async Task UpdateService(Service serviceToUpdate)
        {
            var service = await _context.Services.FirstOrDefaultAsync(s => s.Id == serviceToUpdate.Id);
            if (service == null) throw new Exception("Service not found.");

            // Update properties
            service.Name = serviceToUpdate.Name;
            service.Cost = serviceToUpdate.Cost;
            service.Sell = serviceToUpdate.Sell;
            service.Description = serviceToUpdate.Description;

            _context.Services.Update(service);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteServiceById(int id)
        {
            var service = await _context.Services.FirstOrDefaultAsync(s => s.Id == id);
            if (service == null) throw new Exception("Service not found.");

            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
        }

    }
}
 