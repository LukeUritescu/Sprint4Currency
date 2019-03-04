using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint4Currency
{
    interface IBankNote : ICurrency
    {
        int Year { get; set; }
    }
}
