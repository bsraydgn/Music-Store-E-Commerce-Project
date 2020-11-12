using MainMusicStore.DataAccess.IRepository;
using MainMusicStore.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainMusicStore.DataAccess.IMainRepository
{
    public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails orderDetails);

    }
}
