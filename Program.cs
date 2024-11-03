using Practica_3;
using System;

namespace Practice_3
{
    internal class Program
    {

        static void Main()
        {
            Taxi taxi = Taxi.Instance;
            DebilitatorCreator debCreate = new DebilitatorCreator(false,0,0.5f,30);
            PoliceCarCreator pcCreate = new PoliceCarCreator(true,30,0.8f,1);
            FenceCreator fenceCreate = new FenceCreator(true, 10, 0.8f, 1);

            Console.WriteLine("Press a key to create an obstacle: ");
            Console.WriteLine("     A -> PoliceCar");
            Console.WriteLine("     B -> Fence");
            Console.WriteLine("     C -> Debilitator");

            double startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000.0;
            double lastTimeStamp = 0.0;

            while (true)
            {
                double timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds() / 1000.0 - startTime;

                if (timeStamp - lastTimeStamp >= 0.2)
                {
                    lastTimeStamp = timeStamp;

                    taxi.TaxiValues(timeStamp);

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        switch (key.Key)
                        {
                            case ConsoleKey.A:
                                PoliceCar pc = pcCreate.CreateObstacle();
                                pc.RestLife(taxi);
                                pc.Multiplier(taxi);
                                taxi.EffectTime(timeStamp, pc);
                                break;
                            case ConsoleKey.B:
                                Debilitator debilitator = debCreate.CreateObstacle();
                                debilitator.RestLife(taxi);
                                debilitator.Multiplier(taxi);
                                taxi.EffectTime(timeStamp, debilitator);
                                break;
                            case ConsoleKey.C:
                                Fence fence = fenceCreate.CreateObstacle();
                                fence.RestLife(taxi);
                                fence.Multiplier(taxi);
                                taxi.EffectTime(timeStamp, fence);
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