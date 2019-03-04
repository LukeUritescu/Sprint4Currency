using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint4Currency
{
    class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string About()
        {
        }

        public void AddCoin(ICoin c)
        {
        }

        public int GetCoinCount()
        {
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
