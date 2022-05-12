using Api.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Servicos
{
    public class CalcularImposto : ICalcularImposto
    {
        public async Task<double> Calcular(double valor, int meses)
        {
            return await Task.Run(() =>
            {
                double porcentagem = 15;
                if (meses <= 6)
                    porcentagem = 22.5;
                else if (meses > 6 && meses <= 12)
                    porcentagem = 20;
                else if (meses > 12 && meses <= 24)
                    porcentagem = 17.5;

                return Convert.ToDouble(String.Format("{0:0.00}", (valor * porcentagem) / 100));
            });
        }
    }
}
