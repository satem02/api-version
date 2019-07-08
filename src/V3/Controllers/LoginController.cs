using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace api_version.V3.Controllers
{
    [ApiVersion("3")]
    [Route("api/v3/[controller]")]
    public class LoginController : Controller
    {
        public LoginController()
        {

        }
        /// <summary>
        /// v3 test
        /// </summary>
        [Route("Get"), HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "v3", "value1", "value2" };
        }
    }
}