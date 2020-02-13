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
            var insuranceRepositoryMock = new Mock<IInsuranceRepository>();
            var coveringTypeRepositoryMock = new Mock<ICoveringTypeRepository>();

            Insurance insuranceValid = new Insurance();

            bool Valid = true;
            bool Invalid = false;
            int idInsuranceIsValid = 6;
            int idInsuranceNoTValid = 7;

            Insurance insuranceIsValid = new Insurance();

            insuranceIsValid.Name = "Insurance valid";
            insuranceIsValid.Description = "Test Valid";
            insuranceIsValid.StartDate = Convert.ToDateTime("10/02/2020");
            insuranceIsValid.Period = 2;
            insuranceIsValid.Price = 15000;
            insuranceIsValid.CoveringTypeId = 2;
            insuranceIsValid.RiskTypeId = 1;
            insuranceIsValid.ClientId = 4;
            insuranceIsValid.CoveringType = null;
            insuranceIsValid.RiskType = null;
            insuranceIsValid.Client = null;


            Insurance insuranceInValid = new Insurance();

            insuranceInValid.Name = "Insurance invalid";
            insuranceInValid.Description = "Test invalid";
            insuranceInValid.StartDate = Convert.ToDateTime("10/03/2020");
            insuranceInValid.Period = 3;
            insuranceInValid.Price = 25000;
            insuranceInValid.CoveringTypeId = 1;
            insuranceInValid.RiskTypeId = 5;
            insuranceInValid.ClientId = 1;
            insuranceInValid.CoveringType = null;
            insuranceInValid.RiskType = null;
            insuranceInValid.Client = null;

            insuranceRepositoryMock.Setup(x => x.UpdInsuranceById(insuranceIsValid, idInsuranceIsValid)).Returns(Valid);
            insuranceRepositoryMock.Setup(x => x.UpdInsuranceById(insuranceInValid, idInsuranceNoTValid)).Returns(Invalid);

            _insuranceBusiness = new InsuranceBusiness(insuranceRepositoryMock.Object, coveringTypeRepositoryMock.Object);
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        [TestMethod]
        public void UpdByInsurance_Valid_ReturnTrue()
        {
            // Arrange
            int id = 6;

            Insurance insuranceInValid = new Insurance();

            insuranceInValid.Name = "Insurance invalid";
            insuranceInValid.Description = "Test invalid";
            insuranceInValid.StartDate = Convert.ToDateTime("10/03/2020");
            insuranceInValid.Period = 3;
            insuranceInValid.Price = 25000;
            insuranceInValid.CoveringTypeId = 1;
            insuranceInValid.RiskTypeId = 5;
            insuranceInValid.ClientId = 1;
            insuranceInValid.CoveringType = null;
            insuranceInValid.RiskType = null;
            insuranceInValid.Client = null;

            // Act
            bool result = _insuranceBusiness.UpdInsuranceById(insuranceInValid, id);
            // Assert
            Assert.IsTrue(result);            
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void UpdByInsurance_Invalid_ReturnFalse()
        {
            // Arrange
            int id = 7;

            Insurance insuranceInValid = new Insurance();

            insuranceInValid.Name = "Insurance invalid";
            insuranceInValid.Description = "Test invalid";
            insuranceInValid.StartDate = Convert.ToDateTime("10/03/2020");
            insuranceInValid.Period = 3;
            insuranceInValid.Price = 25000;
            insuranceInValid.CoveringTypeId = 1;
            insuranceInValid.RiskTypeId = 5;
            insuranceInValid.ClientId = 1;
            insuranceInValid.CoveringType = null;
            insuranceInValid.RiskType = null;
            insuranceInValid.Client = null;

            // Act
            bool result = _insuranceBusiness.UpdInsuranceById(insuranceInValid, id);
            // Assert
            Assert.IsFalse(result);

        }
    }
}
