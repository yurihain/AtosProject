using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Servicos
{
    public class CalculoLci : ICalculoDeInvestimento
    {
        public async Task<double> Calcular(double ValorInvestimento, int MesesInvestimento)
        {
            return await Task.Run(() =>
            {
                return 2;
            });
        }
    }
}
