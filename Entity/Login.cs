using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Login
    {
        int id; string userName, password;

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public Login(int id, string userName, string password)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
        }

        public Login(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
