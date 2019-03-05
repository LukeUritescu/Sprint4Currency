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
            Dime dime = new Dime();
            Nickel nickel = new Nickel();
            Penny penny = new Penny();
            while (Amount > 0) {
                if (Amount / dollarCoin.MonetaryValue > 0)
                    AddCoin(dollarCoin);
                else if (Amount / dime.MonetaryValue > 0)
                    AddCoin(dime);
                else if (Amount / nickel.MonetaryValue > 0)
                    AddCoin(nickel);
                else
                    AddCoin(penny);


                    }
            return ;
        }

        public ICurrencyRepo MakeChange(double AmountTendered, double TotaCost)
        {
            return
        }

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
