using Api.Application.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Application.Fabricas
{
    public static class FabricaDeCalculoDeInvestimento
    {
        public static ICalculoDeInvestimento Criar(int tipo)
        {
            switch(tipo)
            {
                case 0:
                case 1: return new CalculoCdb();
                case 2: return new CalculoLci();
                case 3: return new CalculoLca();
                default:
                    return null;
            }
        }
    }
}
