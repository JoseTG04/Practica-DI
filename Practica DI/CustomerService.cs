
using Practica_DI.Interfaces;

namespace Practica_DI
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Customer GetCustomer(int id)
        {
            return _repository.GetById(id);
        }
    }
}
