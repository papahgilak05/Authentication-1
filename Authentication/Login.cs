using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public class Login : Data
    {
        public string name { get; set; }
        public string pass { get; set; }


        public void login() 
        {
            Console.Clear();
            Console.Write("Username : ");
            name = Console.ReadLine();
            Console.Write("Password : ");
            pass = Console.ReadLine();

        }
    }
}