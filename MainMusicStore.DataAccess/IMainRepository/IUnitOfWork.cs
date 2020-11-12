using System;
using System.Collections.Generic;
using System.Text;

namespace MainMusicStore.DataAccess.IMainRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICompanyRepository Company { get; }
        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; }
        ISPCallRepository sp_call { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IOrderHeaderRepository OrderHeader { get; }
        IOrderDetailsRepository OrderDetails { get; }

        void Save();
    }
}
