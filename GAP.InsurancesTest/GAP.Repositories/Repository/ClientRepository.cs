using GAP.Models;
using GAP.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAP.Repositories.Repository
{
    public class ClientRepository : IClientRepository
    {
        private InsuranceContext _context;

        public ClientRepository(InsuranceContext context)
        {
            _context = context;  
        }

        public bool DelClientById(int id)
        {
            bool accion = true;

            Client client = _context.Client.FirstOrDefault(x => x.Id == id);

            if (client == null)
            {
                accion = false;
                return accion;
            }

            _context.Client.Remove(client);
            _context.SaveChanges();

            return accion;

        }

        public List<Client> GetAll()
        {
            return _context.Client.ToList();
        }

        public Client GetByDocument(int documento)
        {
            return _context.Client.Include(x => x.Insurance).FirstOrDefault(x => x.Document == documento);
        }

        public Client GetById(int id)
        {
            Client client = _context.Client.Include(x => x.Insurance).FirstOrDefault(x => x.Id == id);

            return client;
        }

        public bool InsertClient(Client client)
        {
            _context.Client.Add(client);
            _context.SaveChanges();
            return true;

        }

        public bool UpdClientById(Client client)
        {
            Client clientResult = _context.Client.FirstOrDefault(x => x.Id == client.Id);

            clientResult.Document = client.Document;
            clientResult.Name = client.Name;
            clientResult.Age = client.Age;

            _context.Entry(clientResult).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }
    }
}
