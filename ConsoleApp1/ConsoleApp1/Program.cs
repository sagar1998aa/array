using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************");
            Console.WriteLine("please Enter the name of your boss");
            Console.WriteLine("****************************");
            Console.ReadLine();
            Console.WriteLine("****************************");
            Console.WriteLine("please Enter the name of your servent");
            Console.WriteLine("****************************");
            Console.ReadLine(); Console.WriteLine("****************************");
            Console.WriteLine("please Enter the name of your bodyguard");
            Console.WriteLine("****************************");
            Console.ReadLine();
            String[] Medalwinner = new string[3];
            Console.WriteLine("please enter the name of the gold winner");
            Medalwinner[0] = Console.ReadLine();

            Console.WriteLine("please enter the name of the silver  winner");
            Medalwinner[1] = Console.ReadLine();

            Console.WriteLine("please enter the name of the bronze winner");
            Medalwinner[2] = Console.ReadLine();

            Console.WriteLine("which medal winner would you like to see. /n1 Gold /n2-silver /n-3bronze");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"The medal winner is {Medalwinner [input -1]}" );


        }
    }
}
