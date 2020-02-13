using GAP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Repositories.Interfaces
{
    public interface IInsuranceRepository
    {
        List<Insurance> GetAll();
        Insurance GetById(int id);
        List<Insurance> GetInsuranceByClient(int id);
        void UpdInsuranceById(Insurance insurance, int id);
        bool DelInsuranceById(int id);
        void InsertInsurance(Insurance insurance);

        CoveringType GetCoveringById(int id);
    }
}
