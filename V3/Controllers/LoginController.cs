using System.Collections.Generic;
using api_version.V3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_version.V3.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("3")]
    public class LoginController : Controller
    {
        /// <summary>
        /// test
        /// </summary>
        /// <param name="model"></param>
        [Route("Login"), HttpPost]
        [Consumes("application/json")]
        public void Post([FromBody]LoginViewModel model)
        {
        }
        [Route("Get"), HttpGet]
        public string Get()
        {
            return "value1";
        }

        [Route("GetList"), HttpGet]
        public IEnumerable<string> GetList()
        {
            return new string[] { "value1", "value2" };
        }
    }
}