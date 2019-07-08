using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace api_version.V2.Controllers
{
    [ApiVersion("2")]
    [Route("api/v2/[controller]")]
    public class LoginController : Controller
    {
        /// <summary>
        /// v2 test
        /// </summary>
        [Route("Get"), HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "v2", "value1", "value2" };
        }
    }
}