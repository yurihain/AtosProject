using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class CalculoInvestimentoInput
    {
        public double ValorInvestimento { get; set; }
        public int MesesInvestimento { get; set; }
        public int TipoCalculo { get; set; }
    }
}
