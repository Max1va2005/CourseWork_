using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{

    public class Ammunition
    {
        private string price;
        public int Number { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Caliber { get; set; }
        public string Range { get; set; }
        public string Weight { get; set; }
        public string CountryOfOrigin { get; set; }
        public decimal Price { get; set; }

        public Ammunition(string name, string purpose, string caliber, string range, string weight, string countryOfOrigin, decimal price)
        {
            Name = name;
            Purpose = purpose;
            Caliber = caliber;
            Range = range;
            Weight = weight;
            CountryOfOrigin = countryOfOrigin;
            Price = price;
        }

        public Ammunition(string name, string? purpose, string caliber, string range, string weight, string countryOfOrigin, string price)
        {
            Name = name;
            Purpose = purpose;
            Caliber = caliber;
            Range = range;
            Weight = weight;
            CountryOfOrigin = countryOfOrigin;
            this.price = price;
        }
    }
}
