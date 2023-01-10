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
    public class OrderDetailRepository:GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(HC_DbContext db): base(db) 
        {

        }
        public async Task<OrderDetail> GetOrderDetailById(Guid id)
        {
            return await GetById(id);
        }

        public async Task<List<OrderDetail>> GetOrderDetailsByOrderId(Guid orderId)
        {
            return await GetByDefaults(p => p.OrderId == orderId);
        }

        public async Task<List<OrderDetail>> GetAllOrderDetails()
        {
            return await GetList();
        }

        public async Task<string> CreateOrderDetail(OrderDetail orderDetail)
        {
            return await Add(orderDetail);
        }

        public async Task<string> UpdateOrderDetail(OrderDetail orderDetail)
        {
            return await Update(orderDetail);
        }

        public async Task<string> DeleteOrderDetail(Guid id)
        {
            return await Delete(id);
        }
    }
}
