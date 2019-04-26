using System.Collections.Generic;
using api_version.V1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_version.V1.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1")]
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
    }
}