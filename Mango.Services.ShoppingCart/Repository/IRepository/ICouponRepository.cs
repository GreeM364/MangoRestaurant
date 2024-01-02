using Mango.Services.ShoppingCartAPI.DTO;

namespace Mango.Services.ShoppingCartAPI.Repository.IRepository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
        Task<bool> DoesCouponExist(string couponCode);
    }
}
