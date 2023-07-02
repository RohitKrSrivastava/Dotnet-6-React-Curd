using CafeAPI.Models;

namespace CafeAPI.Services
{
    public interface ICafeService
    {
        public List<CafeData> GetAllCafe();
        public string AddCafe(CafeData addCafe);
        public CafeData GetCafeByName(string name);
        public bool UpdateCafe(CafeData cafeData);
        public bool DeleteCafe(string id);
    }
}
