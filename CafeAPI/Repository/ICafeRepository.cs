﻿using CafeAPI.Models;

namespace CafeAPI.Repository
{
    public interface ICafeRepository
    {
        public List<CafeData> GetAllCafe(int withEmploeeData);
        public string AddCafe(CafeData addCafe);
        public CafeData GetCafeByName(string name);
        public bool UpdateCafe(CafeData cafeData);
        public bool DeleteCafe(CafeData cafeData);
    }
}
