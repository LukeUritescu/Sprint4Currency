using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint4Currency
{
    public class Penny : USCoin
    {
        public Penny()
        {
            MintMark = USCoinMintMark.D;
            
        }

        public Penny(USCoinMintMark mintMark)
        {
            MintMark = mintMark;
        }
    }
}
