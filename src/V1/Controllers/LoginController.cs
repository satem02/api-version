using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace api_version.V1.Controllers
{
    [ApiVersion("1")]
    [Route("api/v1/[controller]")]
    public class LoginController : Controller
    {
        /// <summary>
        /// v1 test
        /// </summary>
        [Route("Get"), HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "v1", "value1", "value2" };
        }
    }
}