using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class Reservation
    {

        public int ID { get; set; }
        public int UserID { get; set; }
        public int TableID { get; set; }
        public int ReservDate { get; set; }
        public int ReservTime { get; set; }
        public string Status { get; set; }
        public virtual User User { get; set; }
        public virtual Table Table { get; set; }

        internal void AddReservation(string name, string email, string roomType, DateTime checkInDate, DateTime checkOutDate)
        {
            throw new NotImplementedException();
        }
    }
}