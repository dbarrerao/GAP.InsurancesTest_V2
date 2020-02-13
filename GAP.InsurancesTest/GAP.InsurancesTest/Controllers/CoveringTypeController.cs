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
    public class CoveringTypeController : Controller
    {
        private ICoveringTypeBusiness _coveringType;

        public CoveringTypeController(ICoveringTypeBusiness coveringType)
        {
            _coveringType = coveringType;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CoveringType>> GetAll()
        {
            return _coveringType.GetAll();
        }

    }
}
