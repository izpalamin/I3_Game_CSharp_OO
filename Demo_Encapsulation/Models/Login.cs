using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Encapsulation.Models
{
    internal class Login
    {
        public string email;
        private string _password;

        public bool ChangePassword(string password)
        {
            if (password is null)
            {
                if (password is null)
                    _password = password;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckUser(string email, string password)
        {
            return this.email == email && this._password == password;
        }
    }
}
