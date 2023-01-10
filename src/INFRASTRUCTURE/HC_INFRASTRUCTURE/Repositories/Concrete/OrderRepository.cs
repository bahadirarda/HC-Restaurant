using HC_DOMAIN.Entities.Concrete;
using HC_DOMAIN.Repositories.EntityRepository;
using HC_INFRASTRUCTURE.Context;
using HC_INFRASTRUCTURE.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_INFRASTRUCTURE.Repositories.Concrete
{
    public class OrderRepository: GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(HC_DbContext db): base(db)
        {

        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await GetList();
        }

        public async Task<List<Order>> GetOrdersByAppUserId(string appUserId)
        {
            return await GetByDefaults(p => p.AppUser.Id == appUserId);
        }

        public async Task<string> CreateOrder(Order order)
        {
            return await Add(order);
        }

        public async Task<string> UpdateOrder(Order order)
        {
            return await Update(order);
        }

        public async Task<string> DeleteOrder(Guid id)
        {
            return await Delete(id);
        }

    }
}
