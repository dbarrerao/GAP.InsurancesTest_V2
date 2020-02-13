using GAP.Business.Interfaces;
using GAP.Models;
using GAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Business.Businnes
{
    public class ClientBusiness : IClientBusiness
    {

        private IClientRepository _clientRepository;

        public ClientBusiness(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public bool DelClientById(int id)
        {
            return _clientRepository.DelClientById(id);
        }

        public List<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Client GetByDocument(int documento)
        {
            return _clientRepository.GetByDocument(documento);
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdClientById(Client client)
        {
            return _clientRepository.UpdClientById(client);
        }

        public bool InsertClient(Client client)
        {
            return _clientRepository.InsertClient(client);
        }
    }
}
