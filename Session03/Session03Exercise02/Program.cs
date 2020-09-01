
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Session03Exercise02
{
    class Program
    {
        static string line = "--------------------------------------------------------------";

        static void Main(string[] args)
        {
            while (true)//Forever and ever n ever
            {
                Console.WriteLine("Ange ett antal siffror, separat med kommatecken.");
                Console.WriteLine(line);

                var inputStringArray = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);//new [] för FrameWork 
                List<double> numbersList = new List<double>(); //A list so I dont need to sort unparsed values in for

                double sum = 0;
                double maxValue;
                double minValue;

                int parseNumberCount = 0; //counter for divison with sum for middlevalue

                Console.WriteLine(line);
                //Input
                for (int i = 0; i < inputStringArray.Length; i++)
                {
                    var label = "Värdet är:";
                    var paddedLabel = label.PadRight(14);

                    try
                    {
                        double currentNumber;
                        NumberStyles numberStyles = NumberStyles.Any | NumberStyles.Float; //bitwiseoperator
                        bool parsed = double.TryParse(inputStringArray[i], numberStyles, CultureInfo.InvariantCulture, out currentNumber);
                        if (!parsed) //Jumps backs to the start of the iteration 
                            continue;
                        else //Add elements to list and
                        {
                            numbersList.Add(currentNumber);
                            sum += currentNumber;
                            ++parseNumberCount;//Perhaps exsessive in this stage
                        }
                        Console.WriteLine(paddedLabel + currentNumber); //Prints out inputvalue for user if correct
                        // Debug.Assert(i < numbers.Length - 1); //Remainer just for deeper studies in the subject
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        throw;
                    }

                }
                //Assigning highest and smallest value if element in list is not zero
                if (numbersList.Count != 0)
                {
                    maxValue = numbersList.Max();
                    minValue = numbersList.Min();

                    //Printing out evaluated values
                    Console.WriteLine(line); Console.WriteLine();
                    Console.WriteLine($"Högsta värdet: {maxValue}");//Max value  
                    Console.WriteLine($"Minsta värdet: {minValue}");//Min value
                    Console.WriteLine("Medelvärdet för arrayen är: " + string.Format($"{(sum / parseNumberCount):0.00}")); //Middle value
                }
                else Console.WriteLine("Här har det inte skrivits in nått värde alls. Försök igen!");//ERROR message
                Console.WriteLine("\nTryck på valfri tangent för att köra programmet en gång till.");

                Console.ReadKey();
            }
        }
    }
}
