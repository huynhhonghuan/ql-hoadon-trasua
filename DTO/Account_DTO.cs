using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account_DTO
    {
        private string id;
        private string name;
        private string password;

        public Account_DTO(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public string Id_staff { get => id; set => id = value; }
        public string Account_name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
    }
}
