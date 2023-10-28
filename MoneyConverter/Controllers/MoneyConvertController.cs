using Microsoft.AspNetCore.Mvc;
using MoneyConverter.Models;
using MoneyConverter.Service;
using System.Globalization;

namespace MoneyConverter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoneyConvertController : ControllerBase
    {
        private readonly NumberFormatInfo _numberFormat;
        public MoneyConvertController()
        {

        }

        [HttpGet("{sumToConvert}")]
        public JsonResult Convert(string sumToConvert)
        {
            var converterResult = ConverterService.ConvertToString(sumToConvert);
            return new JsonResult(converterResult);
        }
    }
}
