using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authenticator.Models
{
    public class AccountModel
    {
        public int Id { get; set; } = 0;
        public string Email { get; set; } = "";
        public string OrganizationName { get; set; } = "";
        public string OneTimePassoword { get; set; } = "";
        public int CountDownTime { get; set; } = 30;
    }
}
