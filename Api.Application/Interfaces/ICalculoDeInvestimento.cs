using System;
using System.Threading.Tasks;

namespace Api.Application
{
    public interface ICalculoDeInvestimento
    {
        public Task<double> Calcular(double ValorInvestimento, int MesesInvestimento);
    }
}