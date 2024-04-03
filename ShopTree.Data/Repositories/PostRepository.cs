using ShopTree.Data.Infrastructure;
using ShopTree.Model.Models;

namespace ShopTree.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
       
    }
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
