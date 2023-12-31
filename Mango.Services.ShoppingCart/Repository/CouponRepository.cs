﻿using Mango.Services.ShoppingCartAPI.DTO;
using Mango.Services.ShoppingCartAPI.Repository.IRepository;
using Newtonsoft.Json;

namespace Mango.Services.ShoppingCartAPI.Repository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly HttpClient _client;

        public CouponRepository(HttpClient client)
        {
            _client = client;
        }

        public async Task<CouponDto> GetCoupon(string couponName)
        {
            var response = await _client.GetAsync($"/api/coupon/{couponName}");
            var apiContent = await response.Content.ReadAsStringAsync();
            var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);

            if (resp.IsSuccess)
            {
                return JsonConvert.DeserializeObject<CouponDto>(Convert.ToString(resp.Result));
            }

            return new CouponDto();
        }

        public async Task<bool> DoesCouponExist(string couponName)
        {
            var response = await _client.GetAsync($"/api/coupon/exist/{couponName}");
            var apiContent = await response.Content.ReadAsStringAsync();
            var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);

            if (resp.IsSuccess)
                return (bool)resp.Result;

            return false;
        }
    }
}
