using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Interfaces
{
    public interface ICalcularImposto
    {
        public Task<double> Calcular(double valor, int meses);
    }
}
