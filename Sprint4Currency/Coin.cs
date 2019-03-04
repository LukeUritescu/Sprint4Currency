using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint4Currency
{
    public abstract class Coin : ICoin
    {
        public int Year { get; set; }
        public double MonetaryValue { get; set; }
        public string Name { get; set; }

        public string About()
        {
            return $"US {Name} is from {Year}. It is worth ${MonetaryValue}. It was made in Denver";
        }

        public Coin()
        {
            Year = 2019;
            
        }
    }
}
