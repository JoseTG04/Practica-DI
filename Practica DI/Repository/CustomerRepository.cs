using Practica_DI.Interfaces;

namespace Practica_DI.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetById(int id)
        {
            // Simulamos la obtención de datos de una base de datos
            return new Customer { Id = id, Name = "José Gómez" };
        }
    }
}
