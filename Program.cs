using Practica_3;
using System;

namespace Practice_3
{
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("Press a key to create an obstacle: ");
            Console.WriteLine("     A -> PoliceCar");
            Console.WriteLine("     B -> Fence");
            Console.WriteLine("     C -> Debilitator");

            double startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000.0;
            double lastTimeStamp = 0.0;

            while (true)
            {
                double timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000.0 - startTime;

                if (timeStamp - lastTimeStamp >= 0.02)
                {
                    lastTimeStamp = timeStamp;

                    Taxi.TaxiValues(timeStamp);

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        switch (key.Key)
                        {
                            case ConsoleKey.A:
                                new PoliceCarCreator();
                                break;
                            case ConsoleKey.B:
                                new DebilitatorCreator();
                                break;
                            case ConsoleKey.C:
                                new FenceCreator();
                                break;
                            default:
                                break;
                        }
                    }


                    if (timeStamp % 1 <= 0.002)
                    {
                        Console.WriteLine($"Time: {timeStamp}");
                    }
                }
            }

        }
    }
}