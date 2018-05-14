using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Event4U.Models
{
    public class Event
    {
        public string nom { get; set; }
        public string address{ get ;set; }
        public DateTime date { get; set;}
        public string descriptif { get; set; }
    }
}