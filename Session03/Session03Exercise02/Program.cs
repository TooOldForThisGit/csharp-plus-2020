        
using System;

namespace Session03Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffron, separat med kommatecken.");
            var input = Console.ReadLine();

            var inputArray = input.Split(',', StringSplitOptions.RemoveEmptyEntries);//new [] för FrameWork 
            foreach (var number in inputArray)
            {
                Console.WriteLine("Värdet är " + number);
            }

            Console.ReadKey();
        }
    }
}
