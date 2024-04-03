using ShopTree.Data.Infrastructure;
using ShopTree.Model.Models;

namespace ShopTree.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
