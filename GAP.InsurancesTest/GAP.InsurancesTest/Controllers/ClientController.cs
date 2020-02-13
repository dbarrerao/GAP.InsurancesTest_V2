using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAP.Business.Interfaces;
using GAP.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GAP.InsurancesTest.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private IClientBusiness _clientBusiness;


        public ClientController(IClientBusiness clientBusiness)
        {
            _clientBusiness = clientBusiness;
        }        
        
        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetAll()
        {
            return _clientBusiness.GetAll();
        }
        
        [HttpGet("{document}")]
        public ActionResult<Client> GetClientByDocument(int document)
        {
            var client = _clientBusiness.GetByDocument(document);            

            return client;
        }
       
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Client client)
        {
             return _clientBusiness.InsertClient(client);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Client client)
        {
            
            if(id != client.Id)
            {
                return BadRequest();
            }

            return _clientBusiness.UpdClientById(client);
           
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {  
            return _clientBusiness.DelClientById(id);
            
        }
    }
}
