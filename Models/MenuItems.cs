using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class MenuItems
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public virtual Table Table { get; set; }
        public virtual MenuItems MenuItem { get; set; }
    }
}