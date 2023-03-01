using System;
using System.Collections.Generic;

public interface IUnitOfWork
{
    IRepository<Customer> Customers { get; }
    IRepository<Order> Orders { get; }
    void Commit();
}
Below is the code of how the implementation of above IUnitOfWork will look like,

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UnitOfWork : IUnitOfWork
{

    private ApplicationContext _dbContext;
    private BaseRepository<Customer> _customers;
    private BaseRepository<Order> _orders;

    public UnitOfWork(ApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IRepository<Customer> Customers
    {
        get
        {
            return _customers ?? 
                (_customers=new BaseRepository<Customer>(_dbContext));
        }
    }

    public IRepository<Order> Orders
    {
        get
        {
            return _orders ?? 
                (_orders=new BaseRepository<Order>(_dbContext));
        }
    }

    public void Commit()
    {
        _dbContext.SaveChanges();
    }
}
