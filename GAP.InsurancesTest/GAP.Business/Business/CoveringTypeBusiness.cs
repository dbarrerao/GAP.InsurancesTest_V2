using GAP.Business.Interfaces;
using GAP.Models;
using GAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Business.Business
{
    public class CoveringTypeBusiness : ICoveringTypeBusiness
    {
        private ICoveringTypeRepository _coveringType;

        public CoveringTypeBusiness(ICoveringTypeRepository coveringType)
        {
            _coveringType = coveringType;
        }

        public List<CoveringType> GetAll()
        {
            return _coveringType.GetAll();
        }

        public CoveringType GetbyId(int id)
        {
            return _coveringType.GetbyId(id);
        }
    }
}
