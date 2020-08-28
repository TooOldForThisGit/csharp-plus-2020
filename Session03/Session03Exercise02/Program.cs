        
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

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
            
            Console.WriteLine("Ange ett antal siffror, separat med kommatecken.");
            var inputNumber = Console.ReadLine();

            var inputStringArray = inputNumber.Split(',', StringSplitOptions.RemoveEmptyEntries);//new [] för FrameWork 
            var numbers = new double[inputStringArray.Length];
            double middlevalue = 0;

            //while()
            for (int i = 0; i < inputStringArray.Length; i++)
            {
                Console.WriteLine("Värdet är:".PadRight(14) + inputStringArray[i]);
                try
                {
                    double currentNumber = 0;
                    NumberStyles numberStyles = NumberStyles.Any | NumberStyles.Float; //bitwiseoperator
                    bool parsed  = Double.TryParse(inputStringArray[i], numberStyles, CultureInfo.InvariantCulture, out currentNumber);
                    if (parsed)
                    {
                        numbers[i] = currentNumber;
                        middlevalue += currentNumber;
                    }
                    else continue;
                    
                    // Debug.Assert(i < numbers.Length - 1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine($"Högsta värdet: {numbers.Max()}");//Max value  
            Console.WriteLine($"Minsta värdet: {numbers.Min()}");//Min value
            Console.WriteLine("Medelvärdet för arrayen är: " + string.Format($"{(middlevalue / numbers.Length):0.00}")); //Middle value
            Console.ReadKey();

        }
    }
}
