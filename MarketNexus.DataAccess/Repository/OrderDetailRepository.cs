using MarketNexus.DataAccess.Data;
using MarketNexus.DataAccess.Repository.IRepository;
using MarketNexus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketNexus.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>,IOrderDetailRepository
    {
        private ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}
