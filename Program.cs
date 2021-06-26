using System;

namespace OverloadAss
{
    class Program
    {
        static void Main(string[] args)
        { 
            var u1 = new User() { FullName = "Segun Ojo", Age = 20 , Level = 3};
            var u2 = new User() { FullName = "Segun Ojo", Age = 89 , Level = 5};
            var result = --u2;

            if (u1.Age == u1.Level)
            {
                Console.WriteLine("Hello from true");
            }
            else
            {
                Console.WriteLine("Hello from false");
            }


            Console.WriteLine(result);

            Console.WriteLine("End of Main");
        }
    }
}
 