using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint4Currency
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }

        public string About()
        {
        }

        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public int GetCoinCount()
        {
            int x = 0;
            for(int i = 0; i < Coins.Count; i++)
            {
                x++;
            }
            return x;
        }

        public ICurrencyRepo MakeChange(double Amount)
        {
        }

        public ICurrencyRepo MakeChange(double AmountTendered, double TotaCost)
        {
        }

        public ICoin RemoveCoin(ICoin c)
        {
        }

        public double TotalValue()
        {

        }
    }
}
