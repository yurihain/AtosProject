using Api.Application;
using Api.Application.Boundaries;
using Api.Application.Fabricas;
using Api.Application.Interfaces;
using Api.Application.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculoController : ControllerBase
    {
        private readonly ILogger<CalculoController> _logger;
        private readonly ICalcularImposto _calcularImposto;

        public CalculoController(ILogger<CalculoController> logger,
            ICalcularImposto calcularImposto)
        {
            _logger = logger;
            _calcularImposto = calcularImposto;
        }

        [HttpGet]
        public IActionResult Calculo()
        {
            _logger.LogDebug("Iniciando WebAPI");
            return StatusCode(StatusCodes.Status200OK, "Backend API");
        }

        [HttpPost("CalcularInvestimento")]
        [Route("CalcularInvestimento")]
        public async Task<IActionResult> CalcularInvestimento(CalculoInvestimentoInput input)
        {
            var calc = FabricaDeCalculoDeInvestimento.Criar(input.TipoCalculo);
            var retorno = JsonSerializer.Serialize(await calc.Calcular(input.ValorInvestimento, input.MesesInvestimento));

            return StatusCode(StatusCodes.Status200OK, retorno);
        }

        [HttpPost("CalcularImposto")]
        [Route("CalcularImposto")]
        public async Task<IActionResult> CalcularImposto(CalculoJurosInput input)
        {
            var retorno = JsonSerializer.Serialize(await _calcularImposto.Calcular(input.Valor, input.Meses));
            return StatusCode(StatusCodes.Status200OK, retorno);
        }
    }
}
