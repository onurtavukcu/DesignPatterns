using Design_Patterns.AbstractFactoryDesignPattern;
using Design_Patterns.AdapterDesingPattern;
using Design_Patterns.FactoryDesingPattern;
using Microsoft.AspNetCore.Mvc;

namespace Design_Patterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DesignPatternController : ControllerBase
    {
        [HttpGet("AdapterDesingPattern")]
        public IActionResult GetAdapter()
        {
            var adaptorOperations = new AdapterOperations();

            return Ok(adaptorOperations.Operations());
        }

        [HttpGet("FactoryDesignPattern")]
        public IActionResult GetFactory()
        {
            var factoryOperations = new FactoryOperations();

            return Ok(factoryOperations.Operations());
        }

        [HttpGet("AbstractFactoryDesignPattern")]
        public IActionResult GetAbstractFactory()
        {
            var abstractFactoryOperations = new AbstractFactoryOperations();

            abstractFactoryOperations.Operations();

            return Ok();
        }
    }
}