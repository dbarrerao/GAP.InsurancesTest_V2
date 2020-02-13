using GAP.Business.Businnes;
using GAP.Business.Interfaces;
using GAP.Models;
using GAP.Repositories.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Tests.Business
{
    [TestClass]
    public class InsuranceBusinessTest
    {
        private IInsuranceBusiness _insuranceBusiness;

        [TestInitialize]
        public void TestInitialize()
        {
            var insuranceBusinessMock = new Mock<IInsuranceBusiness>();
            var coveringTypeRepositoryMock = new Mock<ICoveringTypeRepository>();
            var insuranceRepositoryMock = new Mock<IInsuranceRepository>();

            Insurance insuranceValid = new Insurance();

            bool Valid = true;
            bool Invalid = false;
                                   
            int CoveringTypeIdValid = 2;
            int RiskTypeIdValid = 1;           
            
            int CoveringTypeIdInvalid = 1;
            int RiskTypeIdInvalid = 5;
            
            insuranceBusinessMock.Setup(x => x.ValidateInsurance(CoveringTypeIdValid, RiskTypeIdValid)).Returns(Valid);
            insuranceBusinessMock.Setup(x => x.ValidateInsurance(CoveringTypeIdInvalid, RiskTypeIdInvalid)).Returns(Invalid);

            _insuranceBusiness = new InsuranceBusiness(insuranceRepositoryMock.Object, coveringTypeRepositoryMock.Object);
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        [TestMethod]
        public void UpdByInsurance_Valid_ReturnTrue()
        {
            int CoveringTypeIdValid = 2;
            int RiskTypeIdValid = 1;                      
           
            bool result = _insuranceBusiness.ValidateInsurance(CoveringTypeIdValid, RiskTypeIdValid);
            
            Assert.IsTrue(result);            
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void UpdByInsurance_Invalid_ReturnFalse()
        {           
            int CoveringTypeIdInvalid = 1;
            int RiskTypeIdInvalid = 5;
           
            bool result = _insuranceBusiness.ValidateInsurance(CoveringTypeIdInvalid, RiskTypeIdInvalid);
           
            Assert.IsFalse(result);

        }
    }
}
