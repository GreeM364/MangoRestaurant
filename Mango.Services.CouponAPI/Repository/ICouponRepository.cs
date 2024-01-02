using Mango.Services.CouponAPI.DTO;

namespace Mango.Services.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
        Task<bool> DoesCouponExist(string couponCode);
    }
}
