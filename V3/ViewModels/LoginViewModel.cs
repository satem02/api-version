using System.ComponentModel.DataAnnotations;

namespace api_version.V3.ViewModels
{
    public class LoginViewModel
    {
        public int Id { get; set; }
        /// <summary>
        /// can u use mail
        /// </summary>
        /// <value></value>
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}