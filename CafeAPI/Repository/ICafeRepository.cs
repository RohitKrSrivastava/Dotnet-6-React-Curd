using CafeAPI.Models;

namespace CafeAPI.Repository
{
    public interface ICafeRepository
    {
        public List<CafeData> GetAllCafe();
        public string AddCafe(CafeData addCafe);
        public CafeData GetCafeByName(string name);
        public string GetCafeById(string id);
        public bool UpdateCafe(CafeData cafeData);
        public bool DeleteCafe(string id);
    }
}
