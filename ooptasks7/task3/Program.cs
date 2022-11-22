using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { ID= 100, Name ="Reem Ali", Email = "reemalielesh@gmail.com", UserName = "reem3li", UserPass="5286428" };
            s1.Print();
            Authenticate auth = new Authenticate() { Std = s1 };

            Console.Write("Login with Email and Pass : ");
            if (auth.Login("reemalielesh@gmail.com", "5286428"))
                Console.WriteLine("Done successfully");
            else Console.WriteLine("Failed");
            Console.WriteLine("--------------");

            Console.Write("Reset Pass with ID : ");
            if (auth.ResetPass(100,"5286428","52864"))
                Console.WriteLine("Done successfully");
            else Console.WriteLine("Failed");
            Console.WriteLine("--------------");

            Console.Write("Forget Pass with UserName : ");
            Console.WriteLine(auth.ForgetPass("reem3li"));
            Console.WriteLine("--------------");

        }
    }
}
