using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string ContactDetails { get; set; }
        public string Role { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set;}
    }
}