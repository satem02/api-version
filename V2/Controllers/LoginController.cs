using System.Collections.Generic;
using api_version.V2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_version.V2.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2")]
    public class LoginController : Controller
    {
        [Route("Login"), HttpPost]
        public void Post([FromBody]LoginViewModel model)
        {
        }

        [Route("Get"), HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}