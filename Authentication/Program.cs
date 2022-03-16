using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    class Program
    {
        //int tambahgaji(int a, int b)
        //{
        //    return a + b;
        //}
        static void Main(String[] args)
        {

            /*List<string> np = new List<string>();
            List<string> nk = new List<string>();
            List<int> gaji = new List<int>();
            Employee employee = new Employee();*/

            /*Employee Data1 = new Employee();
            Employee DI = new Employee();
            List<Employee> employee = new List<Employee>();
            string perulangan;*/


            /*Console.WriteLine("Silahkan masukan nama anda ");
            string nama = Console.ReadLine();*/

            //List<Data> data = new List<Data>();
            List<Data> data = new List<Data>();
            bool stop = false;

            while(!stop)
            {
                Data DI = new Data();   
                Login logon = new Login();
                Console.Clear();
                Console.WriteLine("== Basic Authentication ==");
                Console.WriteLine("1. Create User  ");
                Console.WriteLine("2. Show User ");
                Console.WriteLine("3. Search ");
                Console.WriteLine("4. Login");
                Console.WriteLine("5. Exit");
                string pil = Console.ReadLine();
                pil.ToLower();

                if (pil == "1")
                {
                    //string FN, LN, UN, PW;
                    Console.Clear();
                    Console.WriteLine("== Create User ==");
                    Console.Write("Firstname : ");
                    DI.FN = Console.ReadLine();

                    Console.Write("Lastname : ");
                    DI.LN = Console.ReadLine();

                    DI.UN = DI.FN.Substring(0, 2).ToLower() + DI.LN.Substring(0, 2).ToLower();

                    Console.Write("Password : ");
                    DI.PW = Console.ReadLine();
                    DI.PW = BCrypt.Net.BCrypt.HashPassword(DI.PW);

                    data.Add(DI);
                }

                else if (pil == "2")
                {
                    Console.Clear();
                    foreach (var item in data)
                    {

                        item.Menampilkan();

                    }
                    Console.ReadKey();


                }
                else if (pil == "3")
                {
                    stop = false;

                }
                else if (pil == "4")
                {
                    /*Console.Clear();
                    Console.Write("Username : ");
                    user = Console.ReadLine();
                    Console.Write("Password : ");
                    pass = Console.ReadLine();
                    Data.login(user, pass);
                    Console.ReadKey();
                */
                    /*    Console.Clear();
                        Console.Write("Username : ");
                        name = Console.ReadLine();
                        Console.Write("Password : ");
                        pass = Console.ReadLine();
                        if (name == DI.UN && pass == DI.PW)
                        {

                            Console.WriteLine("log in successfully");
                        }
                        else if (name == DI.UN && pass != DI.PW)
                        {
                            Console.WriteLine("password salah");
                        }
                        else if (name != DI.UN && pass == DI.PW)
                        {
                            Console.WriteLine("username salah");
                        }
                        else
                        {
                            Console.WriteLine("Username dan Password Salah");
                        }
                        Console.ReadKey();*/

                    logon.login();

                    var item = data.FirstOrDefault(s => s.UN == logon.name);
                    var item2 = data.FirstOrDefault(s => s.PW == logon.pass);
                    /*var item = data.Where(x => x.UN = logon.name);
                      var item2 = data.Where(x => x.PW = logon.pass);*/


                    if (logon.name == item.UN && BCrypt.Net.BCrypt.Verify(logon.pass, item2.PW))
                    {

                        Console.WriteLine("log in successfully");
                    }
                    else if (logon.name == item.UN && logon.pass != item2.PW)
                    {
                        Console.WriteLine("password salah");
                    }
                    else if (logon.name != item.UN && logon.pass == item2.PW)
                    {
                        Console.WriteLine("username salah");
                    }
                    else
                    {
                        Console.WriteLine("Username dan Password Salah");
                    }


                    Console.ReadKey();
                }
                else if (pil == "5")
                {
                    stop = true;
                }


            } 

        }




    }

}