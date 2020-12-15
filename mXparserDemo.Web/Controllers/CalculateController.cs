using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mXparserDemo.Service;
using mXparserDemo.Web.Model;

namespace mXparserDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private readonly CalculateService _calculateService;

        public CalculateController()
        {
            _calculateService = new CalculateService();
        }

       public double Post([FromBody] CalculateViewModel calculateViewModel)
        {
            var result = _calculateService.Calculate(calculateViewModel.Formula,()=> new { calculateViewModel.para });
            return result;
        }
    }
}
