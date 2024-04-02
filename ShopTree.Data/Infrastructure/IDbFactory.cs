using System;


namespace ShopTree.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopTreeDbContext Init();
    }
}
