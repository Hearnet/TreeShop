﻿using ShopTree.Data.Infrastructure;
using ShopTree.Model.Models;

namespace ShopTree.Data.Repositories
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
    }
    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
