using CafeProjectSolution.Models;
using Microsoft.AspNetCore.Mvc;
using CafeProjectSolution.DbContexts;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CafeProjectSolution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CafeDataContrcoller : ControllerBase
    {
        private readonly CafeDbContext _dbContext;

        public CafeDataContrcoller(CafeDbContext context) {
            _dbContext = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCafe()
        {
            var allCafe = await _dbContext.CafeData.ToListAsync();
            return Ok(allCafe);

        }

        [HttpPost]
        public async Task<IActionResult> AddCafe(CafeData addCafe)
        {
            var cafeData = new CafeData()
            {
                Id = "CF" + Guid.NewGuid().ToString().Split("-")[0],
                Name = addCafe.Name,
                Location = addCafe.Location,
                Discription = addCafe.Discription,
                Logo = addCafe.Logo

            };
            await _dbContext.CafeData.AddAsync(cafeData);
            await _dbContext.SaveChangesAsync();
            return Ok(cafeData);

        }

        [HttpGet]
        [Route("{name}")]
        public async Task<IActionResult> GetCafeById([FromRoute] string name)
        {
            var cafe = await _dbContext.CafeData.FindAsync(name.Trim());
            if (cafe == null)
            {
                return NotFound();
            }
            return Ok(cafe);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateCafe([FromRoute] Guid id,CafeData cafeData)
        {
            var cafeDetail = await _dbContext.CafeData.FindAsync(id);

            if (cafeDetail != null)
            {
                cafeDetail.Name = cafeData.Name;
                cafeDetail.Location = cafeData.Location;
                cafeDetail.Discription = cafeData.Discription;
                cafeDetail.Logo = cafeData.Logo;

                await _dbContext.SaveChangesAsync();
                return Ok(cafeDetail);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteCafe(string id)
        {
            var cafeDetail = await _dbContext.CafeData.FindAsync(id); ;
            if (cafeDetail != null)
            {
                _dbContext.Remove(cafeDetail);
                _dbContext.SaveChanges();
                return Ok(cafeDetail);
            }
            return NotFound();
        }
    }
}
