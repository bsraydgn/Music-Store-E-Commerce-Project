using MainMusicStore.Data;
using MainMusicStore.DataAccess.IMainRepository;
using MainMusicStore.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainMusicStore.DataAccess.MainRepository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart shoppingCard)
        {
            _db.Update(shoppingCard);
        }
    }
}
