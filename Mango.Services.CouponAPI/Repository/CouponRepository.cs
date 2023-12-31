﻿using AutoMapper;
using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.DTO;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.Repository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly ApplicationDbContext _db;
        protected IMapper _mapper;
        public CouponRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<CouponDto> GetCouponByCode(string couponCode)
        {
            var couponFromDb = await _db.Coupons.FirstOrDefaultAsync(u => u.CouponCode == couponCode);
            return _mapper.Map<CouponDto>(couponFromDb);
        }

        public async Task<bool> DoesCouponExist(string couponCode)
        {
            var doesExist = await _db.Coupons.AnyAsync(u => u.CouponCode == couponCode);
            return doesExist;
        }

    }
}
