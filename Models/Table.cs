using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class Table
    {
        public int ID { get; set; }
        public double Capacity { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<MenuItems> MenuItems { get; set; }
    }
}