using EatTheCode.DependencyInjection.Core.Interfaces;

namespace EatTheCode.DependencyInjection.Services
{
    public class CustomerService : ICustomerService
    {
        public string GetName(int id)
        {
            return $"Customer with id: {id}";
        }
    }
}
