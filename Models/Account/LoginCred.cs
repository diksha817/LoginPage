using System.ComponentModel.DataAnnotations;

namespace Week2.Models.Account
{
    public class LoginCred
    {
        public required string Username { get; set; }

        public required string Password { get; set; }
    }
}
