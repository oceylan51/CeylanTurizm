using CeylanTurizm.Business.Abstract;
using CeylanTurizm.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeylanTurizm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IBusService _busService;

        public HomeController(IBusService busService)
        {
            _busService = busService;
        }
        [HttpGet("BusList")]
        public List<Bus> BusList()
        {
            List<Bus> buses = _busService.GetAll();
            return buses;
        }
        [HttpDelete("{id}")]
        public void DeleteBus(int id,int ad)
        {
            _busService.BusDelete(id);
        }
    }
}
