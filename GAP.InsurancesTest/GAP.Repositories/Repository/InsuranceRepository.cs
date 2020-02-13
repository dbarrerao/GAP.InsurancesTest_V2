using GAP.Models;
using GAP.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAP.Repositories.Repository
{
    public class InsuranceRepository : IInsuranceRepository
    {
        private InsuranceContext _context;
        public InsuranceRepository(InsuranceContext context)
        {
            _context = context; 
        }
        
        public bool DelInsuranceById(int id)
        {
            bool result = true;

            Insurance insurance = _context.Insurance.FirstOrDefault(x => x.Id == id);

            if (insurance == null)
            {
                result = false;
                return result;
            }

            _context.Insurance.Remove(insurance);
            _context.SaveChanges();

            return result;
        }

        public List<Insurance> GetAll()
        {
            List<Insurance> listInsurance = _context.Insurance.Include(x => x.Client).ToList();

            foreach(Insurance item in listInsurance)
            {
                item.RiskType = _context.RyskType.Find(item.RiskTypeId);
                item.CoveringType = _context.CoveringType.Find(item.CoveringTypeId);
            }
    
            return listInsurance;
        }

        public Insurance GetById(int id)
        {
            Insurance insurance= _context.Insurance.Include(x=> x.Client).FirstOrDefault(x => x.ClientId == id);

            insurance.RiskType = _context.RyskType.Find(insurance.RiskTypeId);
            insurance.CoveringType = _context.CoveringType.Find(insurance.CoveringTypeId);            

            return insurance;
        }

        public List<Insurance> GetInsuranceByClient(int id)
        {
            List<Insurance> listInsurance = _context.Insurance.Include(x => x.Client).Where(x => x.ClientId == id).ToList();

            foreach (Insurance item in listInsurance)
            {
                item.RiskType = _context.RyskType.Find(item.RiskTypeId);
                item.CoveringType = _context.CoveringType.Find(item.CoveringTypeId);
                item.Client = _context.Client.Find(item.ClientId);
            }

            return listInsurance;
        }

        public bool InsertInsurance(Insurance insurance)
        {
            bool result;
            _context.Add(insurance);
            _context.SaveChanges();
            result = true;

            return result;
        }

        public bool UpdInsuranceById(Insurance insurance, int id)
        {
            Insurance insuranceResult = _context.Insurance.FirstOrDefault(x => x.Id == id);

            insuranceResult.Name = insurance.Name;
            insuranceResult.Description = insurance.Description;
            insuranceResult.CoveringTypeId = insurance.CoveringTypeId;
            insuranceResult.RiskTypeId = insurance.RiskTypeId;
            insuranceResult.Period = insurance.Period;
            insuranceResult.StartDate = insurance.StartDate;
            insuranceResult.ClientId = insurance.ClientId;
            insuranceResult.Period = insurance.Period;


            _context.Entry(insuranceResult).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }
         
        public CoveringType GetCoveringById(int id)
        {
            return _context.CoveringType.FirstOrDefault(x => x.Id == id);
        }
    }
}
