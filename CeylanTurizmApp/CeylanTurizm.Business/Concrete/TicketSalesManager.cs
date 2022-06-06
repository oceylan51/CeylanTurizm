using CeylanTurizm.Business.Abstract;
using CeylanTurizm.Data.Abstract;
using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Business.Concrete
{
    public class TicketSalesManager : ITicketSalesService
    {
        private ITicketSalesRepository _ticketSalesRepository;

        public TicketSalesManager(ITicketSalesRepository ticketSalesRepository)
        {
            _ticketSalesRepository = ticketSalesRepository;
        }

        public void Create(TicketSales entity)
        {
            throw new NotImplementedException();
        }

        public void TicketSale(TicketSales sales)
        {
            _ticketSalesRepository.TicketSale(sales);
        }

        public void Delete(TicketSales entity)
        {
            _ticketSalesRepository.Delete(entity);
        }

        public List<TicketSales> GetAll()
        {
            return _ticketSalesRepository.GetAll();
        }

        public TicketSales GetById(int id)
        {
            return _ticketSalesRepository.GetById(id);
        }

        public void Update(TicketSales entity)
        {
            _ticketSalesRepository.Update(entity);
        }

        public TicketSales GetTicketSalesById(int id)
        {
            return _ticketSalesRepository.GetTicketSalesById(id);
        }

        public TicketSales TicketFound(int id, string tcNo)
        {
            return _ticketSalesRepository.TicketFound(id, tcNo);
        }

        public List<TicketSales> TicketsInformation(int id)
        {
            return _ticketSalesRepository.TicketsInformation(id);
        }

        public TicketSales PurchasedTickets(int id)
        {
            return _ticketSalesRepository.PurchasedTickets(id);
        }
    }
}
