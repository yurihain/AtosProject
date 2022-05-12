using Api.Application.Boundaries;
using Api.Application.Interfaces;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using WebApi;
using WebApi.Controllers;

namespace Api.Tests
{
    public class CalculoControllerTests
    {
        [SetUp]
        public void Setup()
        {
            // Method intentionally left empty.
        }

        [Test]
        public void CalcularInvestimento()
        {
            CalculoController controler = Arrange();
            var input = GetValidInputInvestimento();

            var result = controler.CalcularInvestimento(input);
            result.Status.Equals(200);

            Assert.Pass();
        }

        [Test]
        public void CalcularImposto()
        {
            CalculoController controler = Arrange();
            var input = GetValidInputJuros();

            var result = controler.CalcularImposto(input);
            result.Status.Equals(200);

            Assert.Pass();
        }

        private static CalculoController Arrange()
        {
            ILogger<CalculoController> logger = Mock.Of<ILogger<CalculoController>>();
            var moqCalcularImposto = Mock.Of<ICalcularImposto>();

            var controller = new CalculoController(logger, moqCalcularImposto);

            return controller;
        }

        private static CalculoInvestimentoInput GetValidInputInvestimento()
        {
            return new CalculoInvestimentoInput
            {
                MesesInvestimento = 10,
                TipoCalculo = 1,
                ValorInvestimento = 5000
            };
        }

        private static CalculoJurosInput GetValidInputJuros()
        {
            return new CalculoJurosInput
            {
                Valor = 1000,
                Meses = 5
            };
        }
    }
}