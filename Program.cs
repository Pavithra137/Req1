using System;

namespace Storybook
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] d = new User[2];
            for(int i=0;i<2;i++)
            {
                Console.WriteLine(" Enter User {0} details: ", i + 1);
                string details = Console.ReadLine();
                string[] k= details.Split(",");
                d[i] = new User(k[0], k[1], k[2]);
                Console.WriteLine();

            }
            for (int i=0; i < 2;i++)
            {
                Console.WriteLine("User {0}",i + 1);
                Console.WriteLine(d[i]);
                Console.WriteLine();
            }
            if(d[0].Equals(d[1]))
            {
                Console.WriteLine("User 1 is same as User 2");

            }
            else
            {
                Console.WriteLine("User 1 and User 2 are different");
            }
            
        }
    }
}
