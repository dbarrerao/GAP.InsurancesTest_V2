using GAP.Models;
using GAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAP.Repositories.Repository
{
    public class CoveringTypeRepository : ICoveringTypeRepository
    {
        private InsuranceContext _context;

        public CoveringTypeRepository(InsuranceContext context)
        {
            _context = context; 
        }

        public List<CoveringType> GetAll()
        {
            return _context.CoveringType.ToList();  
        }

        public CoveringType GetbyId(int id)
        {
            return _context.CoveringType.FirstOrDefault(x => x.Id == id);
        }
    }
}
