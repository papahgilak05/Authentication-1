using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public class Data
    {
        public string FN;
        public string LN;
        public string UN;
        public string PW;

       /* public Data (string firstname, string lastname, string username, string password) 
        
        {
            this.FN = firstname;
            this.LN = lastname;
            this.PW = username;
            this.UN = password;
        }

        public string getFirstName()
        {
            return FN;
        }
        public string getLastName()
        {
            return LN;
        }
        public string getUserName()
        {
            return UN;
        }
        public string getPassword()
        {
            return PW;
        }

        public void setFirstName(string firstname)
        {
            this.FN = firstname;
        }
        public void setLastName(string lastname)
        {
            this.LN = lastname;
        }
        public void setUserName(string username)
        {
            this.UN = username;
        }
        public void setPassword(string password)
        {
            this.PW = password;
        }*/

        public void Menampilkan()
        {

            Console.WriteLine("====================================");
            Console.WriteLine($"Name : {FN} {LN}");
            Console.WriteLine($"Username : {UN} ");
            Console.WriteLine($"Password : {PW} ");
            Console.WriteLine("====================================");

        }

        /*public static void login (string username, string password) 
        {
            var dquery = (from d in dt
                          where d.UN.Equals(username)&&
                          d.PW.Equals(password)
                          select d).FirstOrDefault();
            if (dquery == null) 
            {
                Console.WriteLine("Login Failed");
            }
            else
            {
                Console.WriteLine("Login Success");
            }
        
        }*/


    }
}
