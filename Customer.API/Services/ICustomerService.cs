namespace Customer.API.Services
{
    public interface ICustomerService
    {
        public IEnumerable<Models.Customer> GetCustomers();
        public Models.Customer GetCustomer(int id);
        public void DeleteCustomer(int id);
        public void CreateCustomer(Models.Customer customer);
        public void UpdateCustomer(int id, Models.Customer customer);
    }
}
