using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Servicos
{
    class CalculoLca : ICalculoDeInvestimento
    {
        public async Task<double> Calcular(double ValorInvestimento, int MesesInvestimento)
        {
            return await Task.Run(() =>
            {
                return 3;
            });
        }
    }
}
