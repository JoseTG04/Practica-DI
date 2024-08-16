using Practica_DI.Repository;
using Practica_DI;

class Program
{
    static void Main(string[] args)
    {
        var repository = new CustomerRepository();
        var service = new CustomerService(repository);
        var customer = service.GetCustomer(1);
        Console.WriteLine($"Customer: {customer.Name}");
    }
}
