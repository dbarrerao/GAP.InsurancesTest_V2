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
    public class ClientBusinessTest
    {

        private IClientBusiness _clientBusiness;

        [TestInitialize]
        public void TestInitialize()
        {
            var clientRepositoryMock = new Mock<IClientRepository>();

            Client clientDiego = new Client();
            clientDiego.Document = 98695330;
            clientDiego.Name = "Diego Barrera";

            Client clientNull = null;          

            clientRepositoryMock.Setup(x => x.GetByDocument(98695330)).Returns(clientDiego);
            clientRepositoryMock.Setup(x => x.GetByDocument(123)).Returns(clientNull);   

            _clientBusiness = new ClientBusiness(clientRepositoryMock.Object);
        }

        [TestCleanup]
        public void TestCleanup()
        { 

        }

        [TestMethod]
        public void GetByDocument_ValidDocument_ReturnsInformation()
        {
            // Arrange
            int document = 98695330;
            // Act
            Client client = _clientBusiness.GetByDocument(document);
            // Assert
            Assert.IsNotNull(client);
            Assert.AreEqual("Diego Barrera", client.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetByDocument_InvalidDocument_ReturnsNull()
        {
            // Arrange
            int document = 123;
            // Act
            Client client = _clientBusiness.GetByDocument(document);
            // Assert
            Assert.IsNotNull(client);

        }

    }
}
