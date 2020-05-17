using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeoVicky.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PinCode { get; set; }
        public string State { get; set; }
    }
}