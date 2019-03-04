﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint4Currency
{
    public class DollarCoin : USCoin
    {
        public DollarCoin()
        {
            MintMark = USCoinMintMark.D;

        }

        public DollarCoin(USCoinMintMark mintMark)
        {
            MintMark = mintMark;
        }
    }
}
