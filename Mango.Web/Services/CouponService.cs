using Mango.Web.Models;
using Mango.Web.Services.IServices;

namespace Mango.Web.Services
{
    public class CouponService : BaseService, ICouponService
    {
        private readonly IHttpClientFactory _clientFactory;

        public CouponService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<T> GetCoupon<T>(string couponCode, string token = null)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ServerAPIBase + "/api/coupon/" + couponCode,
                AccessToken = token
            });
        }
    }
}
