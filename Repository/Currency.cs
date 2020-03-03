using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class Currency
    {
        public int CurrencyID { get; set; }
        public string IsoCode { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public string Country { get; set; }

        //public string FullName { get { return $"{ this.IsoCode} {this.Name}"; } }
    }
}
