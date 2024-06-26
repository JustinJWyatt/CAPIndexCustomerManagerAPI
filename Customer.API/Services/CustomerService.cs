using Customer.API.Models;

namespace Customer.API.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateCustomer(Models.Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var customer = GetCustomer(id);

            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public Models.Customer GetCustomer(int id) => _context.Customers.Find(id);

        public IEnumerable<Models.Customer> GetCustomers() => _context.Customers.ToList();

        public void UpdateCustomer(int id, Models.Customer customer)
        {
            var _ = GetCustomer(id);
            _context.Update(_).CurrentValues.SetValues(customer);
            _context.SaveChanges();
        }
    }
}
