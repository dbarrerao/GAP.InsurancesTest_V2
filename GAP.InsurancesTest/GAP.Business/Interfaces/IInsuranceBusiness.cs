﻿using GAP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Business.Interfaces
{
    public interface IInsuranceBusiness
    {
        List<Insurance> GetAll();
        Insurance GetById(int id);
        List<Insurance> GetInsuranceByClient(int id);
        bool UpdInsuranceById(Insurance insurance, int id);
        bool DelInsuranceById(int id);
        bool InsertInsurance(Insurance insurance);
        bool ValidateInsurance(int idCoveringType, int idRiskType);
    }
}
