using GAP.Business.Interfaces;
using GAP.Models;
using GAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Business.Business
{
    public class RiskTypeBusiness : IRiskTypeBusiness
    {
        private IRiskTypeRepository _riskType;

        public RiskTypeBusiness(IRiskTypeRepository riskType)
        {
            _riskType = riskType;
        }

        public List<RiskType> GetAll()
        {
            return _riskType.GetAll();
        }
    }
}
