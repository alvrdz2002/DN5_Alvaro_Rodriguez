using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AudioManager;

namespace Ejercicio_1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine("Type the transport");

                String AnimalType = Console.ReadLine().ToLower();

                Vehicle transport = null;

                switch (AnimalType)
                {

                    case "car":
                        transport = new Car();
                        break;

                    case "truck":
                        transport = new Truck();
                        break;

                    case "train":
                        transport = new Train();
                        break;



                    default:
                        Console.WriteLine("Transport not found");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }
                if (transport != null)
                {
                    transport.TransportSound();
                }
                count++;
            }
            Console.WriteLine("Program finalized");
        }
    }
}
