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
            return "";
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

        //public ICurrencyRepo MakeChange(double Amount)
        //{
            
        //}

        //public ICurrencyRepo MakeChange(double AmountTendered, double TotaCost)
        //{
        //    return 
        //}

        public ICoin RemoveCoin(ICoin c)
        {
            ICoin removedCoin = c;
            Coins.Remove(c);
            return removedCoin;
        }

        public double TotalValue()
        {
            double frank = 0;
            for(int i = 0; i < GetCoinCount(); i++)
            {
                frank = frank + Coins[i].MonetaryValue;
            }
            return frank;
        }
    }
}
