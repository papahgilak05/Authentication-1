using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    class Program
    {
        public static List<Data> data = new List<Data>();
        static void Main(String[] args)
        {

            bool stop = false;

            while (!stop)
            {
                Menu();
                string pil = Console.ReadLine();
                pil.ToLower();

                if (pil == "1")
                {
                    Console.Clear();
                    BuatUser();
                    Console.ReadKey();
                    
                }

                else if (pil == "2")
                {
                    Console.Clear();
                    Menampilkan();                   
                    Console.ReadKey();


                }
                else if (pil == "3")
                {
                    Console.Clear();
                    Find();
                    Console.ReadKey();

                }
                else if (pil == "4")
                {
                    Console.Clear();
                    Logon();
                    Console.ReadKey();
                }
                else if (pil == "5")
                {
                    stop = true;
                }


            }



        }

        public static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("== Basic Authentication ==");
            Console.WriteLine("1. Create User  ");
            Console.WriteLine("2. Show User ");
            Console.WriteLine("3. Search ");
            Console.WriteLine("4. Login");
            Console.WriteLine("5. Exit");
        }

        public static void BuatUser() 
        {
            Console.Clear();
            Console.WriteLine("== Create User ==");
            Console.Write("Firstname : ");
            string Fname = Console.ReadLine();

            Console.Write("Lastname : ");
            string Lname = Console.ReadLine();

            //UN = FN.Substring(0, 2).ToLower() + LN.Substring(0, 2).ToLower();

            Console.Write("Password : ");
            string Pw = Console.ReadLine();
            Pw = BCrypt.Net.BCrypt.HashPassword(Pw);

            data.Add(new Data(Fname, Lname, BCrypt.Net.BCrypt.HashPassword(Pw), NamaPengguna(Fname.Substring(0,2),Lname.Substring(0,2))));
            Console.WriteLine("Akun Sukses Dibuat");


        }

        public static string NamaPengguna(string a, string b) 
        {
            Random acak = new Random();
            string c = a.ToLower() + b.ToLower();
            int index = data.FindIndex(data => data.UN == c);
            if(index != -1)
            {
                c += acak.Next(10, 100);
            }
            return c;
        
        }

        public static void Menampilkan()
        {
            foreach(var item in data) 
            { 
            Console.WriteLine("====================================");
            Console.WriteLine($"Name : {item.FN} {item.LN}");
            Console.WriteLine($"Username : {item.UN} ");
            Console.WriteLine($"Password : {item.PW} ");
            Console.WriteLine("====================================");
            }
        }

        public static void Find() 
        {
            Console.Write("Cari : ");
            string Cari = Console.ReadLine();
            List<Data> data2 = data.FindAll(
            data2 => data2.FN.ToLower().Contains(Cari.ToLower()) || 
                     data2.LN.ToLower().Contains(Cari.ToLower()) || 
                     data2.UN.ToLower().Contains(Cari.ToLower()));

            if (data2.Count == 0)
            {
                Console.WriteLine("Tidak Ditemukan");
            }
            else
            {
                foreach (var item in data2)
                {
                    Console.WriteLine("====================================");
                    Console.WriteLine($"Name : {item.FN} {item.LN}");
                    Console.WriteLine($"Username : {item.UN} ");
                    Console.WriteLine($"Password : {item.PW} ");
                    Console.WriteLine("====================================");
                }
            }

        }
        public static void Logon()
        {
            Console.Clear();
            Console.WriteLine("==LOGIN==");
            Console.Write("USERNAME : ");
            string username = Console.ReadLine();
            Console.Write("PASSWORD : ");
            string password = Console.ReadLine();
            VerifyLogin(username, password);
        }
        public static void VerifyLogin(string username, string password)
        {
            int index = data.FindIndex(user => user.UN == username);
            if (index != -1)
            {
                // jika ada cocokan password user 
                if (BCrypt.Net.BCrypt.Verify(password, data[index].PW))
                {
                    Console.WriteLine($"Login Successfully. Logged in as {data[index].UN}");
                }
                else
                {
                    Console.WriteLine($"!! Wrong Username or Password !!");
                }
            }
            else
            {
                Console.WriteLine($"!! Username Not Found !!");
            }




        }
    
        
    
    }
}