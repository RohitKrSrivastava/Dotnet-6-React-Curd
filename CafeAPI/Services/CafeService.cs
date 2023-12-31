﻿using CafeAPI.Models;
using CafeAPI.Repository;

namespace CafeAPI.Services
{
    public class CafeService : ICafeService
    {
        private readonly ICafeRepository _cafeRepository;

        public CafeService(ICafeRepository cafeRepository)
        {
            _cafeRepository = cafeRepository;
        }
        public string AddCafe(CafeData addCafe)
        {
            var cafeData = new CafeData()
            {
                Id = "CF" + Guid.NewGuid().ToString().Split("-")[0],
                Name = addCafe.Name,
                Location = addCafe.Location,
                Discription = addCafe.Discription,
                Logo = addCafe.Logo

            };

            return _cafeRepository.AddCafe(cafeData);
        }

        public bool DeleteCafe(string id)
        {
            return _cafeRepository.DeleteCafe(id);
        }

        public List<CafeData> GetAllCafe()
        {
            return _cafeRepository.GetAllCafe();
        }

        public CafeData GetCafeByName(string name)
        {
            return _cafeRepository.GetCafeByName(name.ToLower().Trim());
        }

        public bool UpdateCafe(CafeData cafeData)
        {
            return _cafeRepository.UpdateCafe(cafeData);
        }
    }
}
