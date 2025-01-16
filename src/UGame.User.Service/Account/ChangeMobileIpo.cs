using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.User.Service.Account
{
    public class ChangeMobileIpo
    {
        public string UserId { get; set; }
        public string Mobile { get; set; }
        public string VerifyCode { get; set; }
        public string SecurityCode { get; set; }
        public string AppId { get; set; }

        public string NewPassword { get; set; }
    }
}
