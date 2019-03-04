using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint4Currency
{
    public abstract class USCoin : Coin
    {
        public USCoinMintMark MintMark;
        public string About()
        {
            return "";
        }

        public USCoin()
        {
            MintMark = USCoinMintMark.D;
            
        }

        public USCoin(USCoinMintMark mintMark)
        {
            MintMark = mintMark;
        }



    }
}
