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
              return Coins.Count;
        }

        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
        }

        public ICurrencyRepo MakeChange(double Amount)
        {
            DollarCoin dollarCoin = new DollarCoin();
            HalfDollar halfDollar = new HalfDollar();
            Quarter quarter = new Quarter();
            Dime dime = new Dime();
            Nickel nickel = new Nickel();
            Penny penny = new Penny();
            CurrencyRepo cr = new CurrencyRepo();
            while (Amount > 0) {
                if (Math.Round(Amount, 2) - Math.Round(dollarCoin.MonetaryValue, 2) >= 0)
                {
                    Amount = Math.Round(Amount, 2) - Math.Round(dollarCoin.MonetaryValue, 2);
                    cr.AddCoin(dollarCoin);
                }

                else if (Math.Round(Amount, 2) - Math.Round(halfDollar.MonetaryValue, 2) >= 0)
                {
                    Amount = Math.Round(Amount, 2) - Math.Round(halfDollar.MonetaryValue, 2);
                    cr.AddCoin(halfDollar);
                }

                else if (Math.Round(Amount, 2) - Math.Round(quarter.MonetaryValue, 2) >= 0)
                {
                    Amount = Math.Round(Amount, 2) - Math.Round(quarter.MonetaryValue, 2);
                    cr.AddCoin(quarter);
                }

                else if (Math.Round(Amount, 2) - Math.Round(dime.MonetaryValue, 2) >= 0)
                {
                    Amount = Math.Round(Amount, 2) - Math.Round(dime.MonetaryValue, 2);
                    cr.AddCoin(dime);
                }
                else if (Math.Round(Amount, 2) - Math.Round(nickel.MonetaryValue, 2) >= 0)
                {
                    Amount = Math.Round(Amount, 2) - Math.Round(nickel.MonetaryValue, 2);
                    cr.AddCoin(nickel);
                }
                else if (Math.Round(Amount, 2) - Math.Round(penny.MonetaryValue, 2) >= 0)
                {
                    Amount = Math.Round(Amount, 2) - Math.Round(penny.MonetaryValue, 2);
                    cr.AddCoin(penny);
                }
                else
                    Amount = 0;


                    }
            return cr;
        }

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
