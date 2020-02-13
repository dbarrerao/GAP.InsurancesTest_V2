using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAP.Business.Interfaces;
using GAP.Models;
using Microsoft.AspNetCore.Mvc;

namespace GAP.InsurancesTest.Controllers
{
    [Route("api/[controller]")]
    public class RiskTypeController : Controller
    {
        private IRiskTypeBusiness _riskType;

        public RiskTypeController(IRiskTypeBusiness riskType)
        {
            _riskType = riskType;
        }        
      
        [HttpGet]
        public IEnumerable<RiskType> GetAll()
        {
            return _riskType.GetAll();
        }

    }
}
