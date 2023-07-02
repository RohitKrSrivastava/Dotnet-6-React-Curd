using CafeAPI.Models;
using CafeAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CafeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CafeController : ControllerBase
    {
        private readonly ICafeService _cafeService;
        public CafeController(ICafeService cafeService)
        {
            _cafeService = cafeService;
        }

        [HttpGet]
        [Route("allCafeList")]
        public IActionResult GetAllCafe()
        {
            try
            {
                var result = _cafeService.GetAllCafe();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost]
        [Route("addCafeDetails")]
        public IActionResult AddCafe(CafeData addCafe) {
            try
            {
                return Ok(_cafeService.AddCafe(addCafe));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet]
        [Route("cafeByName/{name}")]
        public IActionResult GetCafeByName(string name) {
            try
            {
                return Ok(_cafeService.GetCafeByName(name));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPut]
        [Route("updateCafeDetails")]
        public IActionResult UpdateCafe(CafeData cafeData) {
            try
            {
                return Ok(_cafeService.UpdateCafe(cafeData));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpDelete]
        [Route("deleteCafe/{id}")]
        public IActionResult DeleteCafe(string id) {
            try
            {
                return Ok(_cafeService.DeleteCafe(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
