using System;
using System.Threading.Tasks;

namespace Api.Application.Servicos
{
    public class CalculoCdb : ICalculoDeInvestimento
    {
        public async Task<double> Calcular(double ValorInvestimento, int MesesInvestimento)
        {
            return await Task.Run(() =>
            {
                var cdi = Constantes.CalculosConstantes.Constantes.CDI / 100;
                var tb = Constantes.CalculosConstantes.Constantes.TB / 100;
                var rendimentos = ValorInvestimento;

                for (int mes = 1; mes <= MesesInvestimento; mes++)
                {
                    rendimentos *= (1 + (cdi * tb));
                }

                return Convert.ToDouble(String.Format("{0:0.00}", rendimentos));
            }
            );
        }
    }
}