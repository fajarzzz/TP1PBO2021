using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PBO2021
{
    public class User
    {
        public string username{ get; set; }
        public string nim {get; set; }
        public string nama {get; set; }
        public string password { get; set; }

        public User() { }

        public User(string username, string nim, string nama, string password) {
            this.username = username;
            this.nim = nim;
            this.nama = nama;
            this.password = password;
        }
    }
}
