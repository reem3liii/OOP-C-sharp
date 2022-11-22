using System;

namespace task6
{
    internal class Program
    {
        #region Functions
        public static int GetPower(int num , int power) {

            int result = 1;
            for(int i = 0; i < power; i++)
            {
                result *=  num;
            }
            return result;
        
        }

        public static int GetFactorial(int num)
        {

            int result = 1;
            while(num >1)
            {
                result *= num;
                num--;
            }
            return result;

        }

        public static bool CheckPrime(int num)
        {
            for(int i = 2; i <= 100 ;i++)
            {
                if (num == i)
                {
                    continue;
                }                  
                if (num % i == 0)
                {
                    return false;
                }              
            }
            return true;
        }

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine(GetPower(2, 3));
            Console.WriteLine(GetPower(4, 2));
            Console.WriteLine("--------------");
            Console.WriteLine(GetFactorial(3));
            Console.WriteLine(GetFactorial(4));
            Console.WriteLine("--------------");
            Console.WriteLine(CheckPrime(11));
            Console.WriteLine(CheckPrime(20));
            Console.WriteLine("--------------");


        }
    }
}
