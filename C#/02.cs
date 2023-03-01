public class CustomerRepository:ICustomerRepository    
{        
    private ApplicationContext context;        
 
    public CustomerRepository(ApplicationContext context)        
    {            
        this.context = context;        
    }        
    
    public IEnumerable<Customer> GetCustomers()        
    {            
        return context.Customers.ToList();        
    }        
    public Customer GetCustomerByID(int customerId)        
    {
        return context.Customers.Find(customerId);
    }
    
    public void InsertCustomer(Customer customer)
    {            
        context.Customers.Add(customer);      
    }        
    
    public void DeleteCustomer(int customerId)        
    {            
        Customer customer = context.Customers.Find(customerId);                    
        context.Customers.Remove(customer);        
    }        
    
    public void UpdateCustomer(Customer customer)        
    {            
        context.Entry(customer).State = EntityState.Modified;        
    }        
    
    public void Save()        
    {            
        context.SaveChanges();        
    }
    
}
