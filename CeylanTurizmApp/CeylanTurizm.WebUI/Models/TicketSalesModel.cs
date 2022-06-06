using CeylanTurizm.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CeylanTurizm.WebUI.Models
{
    public class TicketSalesModel
    {
        
        [Required]
        public int ExpeditionId { get; set; }
        public Expedition Expedition { get; set; }
        [Required(ErrorMessage = "Lütfen koltuk seçiniz")]
        public int SeatNumber { get; set; }
        [Required]
        public string customerName { get; set; }
        [Required]
        public string customerSurname { get; set; }
        [Required]
        public string customerTelNo { get; set; }
        [Required]
        public string customerTcNo { get; set; }
    }
}
