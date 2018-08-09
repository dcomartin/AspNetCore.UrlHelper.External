using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Demo
{
    [Route("api/[controller]", Name = nameof(ValuesController))]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}