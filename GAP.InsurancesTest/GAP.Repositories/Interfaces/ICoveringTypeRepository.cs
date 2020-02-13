using GAP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Repositories.Interfaces
{
    public interface ICoveringTypeRepository
    {
        List<CoveringType> GetAll();
        CoveringType GetbyId(int id);
    }
}
