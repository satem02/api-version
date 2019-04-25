using System.Collections.Generic;
using api_version.V1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_version.V1.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1")]
    public class LoginController : Controller
    {
        [Route("Login"), HttpPost]
        public void Post([FromBody]LoginViewModel model)
        {
        }
    }
}