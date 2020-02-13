using GAP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Business.Interfaces
{
    public interface IRiskTypeBusiness
    {
        List<RiskType> GetAll();
    }
}
