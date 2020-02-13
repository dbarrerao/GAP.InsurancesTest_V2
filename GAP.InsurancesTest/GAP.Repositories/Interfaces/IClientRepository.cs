using GAP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Repositories.Interfaces
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        Client GetByDocument(int id);
        Client GetById(int id);
        bool InsertClient(Client client);
        bool UpdClientById(Client client);
        bool DelClientById(int id);
    }
}
