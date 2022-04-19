using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities.Interfaces
{
    public interface IProductRepository
    {
        //Method returning a task 
        Task<Product> GetProductByIdAsync(int id );
        //Method returning iread
        Task<IReadOnlyList<Product>> GetProductsAsync();
        
    }
}