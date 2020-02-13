using GAP.Models;
using GAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAP.Repositories.Repository
{
    public class RiskTypeRepository : IRiskTypeRepository
    {
        private InsuranceContext _context;

        public RiskTypeRepository(InsuranceContext context)
        {
            _context = context;
        }

        public List<RiskType> GetAll()
        {
            return _context.RyskType.ToList();
        }
    }
}
