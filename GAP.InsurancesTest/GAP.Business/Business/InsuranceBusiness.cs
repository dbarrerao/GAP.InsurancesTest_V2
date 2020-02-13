using GAP.Business.Interfaces;
using GAP.Models;
using GAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Business.Businnes
{
    public class InsuranceBusiness : IInsuranceBusiness
    {
        private IInsuranceRepository _insuranceRepository;
        private ICoveringTypeRepository _coveringTypeRepository;

        public InsuranceBusiness(IInsuranceRepository insuranceRepository, ICoveringTypeRepository coveringTypeRepository)
        {
            _insuranceRepository = insuranceRepository;
            _coveringTypeRepository = coveringTypeRepository;
        }


        public bool DelInsuranceById(int id)
        {
            return _insuranceRepository.DelInsuranceById(id);
        }

        public List<Insurance> GetAll()
        {
            return _insuranceRepository.GetAll();
        }

        public Insurance GetById(int id)
        {
            return _insuranceRepository.GetById(id);
        }

        public List<Insurance> GetInsuranceByClient(int id)
        {
            return _insuranceRepository.GetInsuranceByClient(id);
        }

        public bool InsertInsurance(Insurance insurance)
        {
            bool validationBusiness;
            try
            {
              
                CoveringType coveringType = _coveringTypeRepository.GetbyId(insurance.CoveringTypeId);

                int riskType = insurance.RiskTypeId;

                if (riskType == 4 && coveringType.Percentage > 50)
                    validationBusiness = false;
                else
                    validationBusiness = _insuranceRepository.InsertInsurance(insurance);

                return validationBusiness;
            }
            catch (Exception e)
            {

                throw e;
            }
            
            
        }

        public bool UpdInsuranceById(Insurance insurance, int id)
        {
            bool validationBusiness;           
            try
            {               
                CoveringType coveringType = _coveringTypeRepository.GetbyId(insurance.CoveringTypeId);

                int riskType = insurance.RiskTypeId;

                if (riskType == 4 && coveringType.Percentage > 50)
                    validationBusiness = false;
                else
                    validationBusiness = _insuranceRepository.UpdInsuranceById(insurance, id);

                return validationBusiness;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
