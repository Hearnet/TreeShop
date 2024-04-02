using ShopTree.Data.Infrastructure;
using ShopTree.Model.Models;

namespace ShopTree.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }
    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
