using ShopTree.Data.Infrastructure;
using ShopTree.Model.Models;

namespace ShopTree.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
