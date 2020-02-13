using GAP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Repositories.Interfaces
{
    public interface IRiskTypeRepository
    {
        List<RiskType> GetAll();
    }
}
