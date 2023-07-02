using CafeAPI.DbContexts;
using CafeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeAPI.Repository
{
    public class CafeRepository : ICafeRepository
    {
        private readonly CafeDbContext _dbContext;

        public CafeRepository(CafeDbContext context)
        {
            _dbContext = context;
        }
        public string AddCafe(CafeData addCafe)
        {
            try
            {
                _dbContext.CafeData.Add(addCafe);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            
            return addCafe.Id;
        }

        public bool DeleteCafe(string id)
        {
            var result = false;
            try
            {
                var findEntity = _dbContext.CafeData.Find(id);

                if (findEntity != null)
                {
                    _dbContext.Remove(findEntity);
                    _dbContext.SaveChanges();
                    result = true;
                }
                else {
                    result = false;
                }
                
            }
            catch (Exception)
            {
                throw;
            }
            
            return result;
        }

        public List<CafeData> GetAllCafe()
        {
            try
            {
               var allCafe = _dbContext.CafeData.Include(x=> x.Employees).ToList();
               return allCafe;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public CafeData GetCafeByName(string name)
        {
            try
            {
                var data = _dbContext.CafeData.Include(x => x.Employees).Where(cf =>cf.Name.ToLower() == name).FirstOrDefault();
                return data;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public bool UpdateCafe(CafeData cafeData)
        {
            try
            {
                var cafeDetail = _dbContext.CafeData.Find(cafeData.Id);

                if (cafeDetail != null)
                {
                    cafeDetail.Name = cafeData.Name;
                    cafeDetail.Location = cafeData.Location;
                    cafeDetail.Discription = cafeData.Discription;
                    cafeDetail.Logo = cafeData.Logo;

                    _dbContext.SaveChanges();
                    return true;
                }

                else {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
