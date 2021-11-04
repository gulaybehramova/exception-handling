using System;
using ClassLibrary;
using exception_handling;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            try
            {
                Console.WriteLine("Adinizi daxil edin");
                string usernameStr = Console.ReadLine();
                user.UserName = usernameStr;
            }


            catch (Exception)
            {
                Console.WriteLine("Ad uygun deyil");
            }

            try
            {
                Console.WriteLine("Parolunuzu daxil edin: ");
                string password = Console.ReadLine();
                user.Password = password;
            }

            catch (Exception)
            {

                Console.WriteLine("Parol uygun deyil");
            }
            Console.WriteLine($"UserName: {user.UserName} - Password: {user.Password}");
        }
    }
}
