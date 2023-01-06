using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;7777using AudioManager;

namespace Ejercicio_1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type the transport");

                String AnimalType = Console.ReadLine().ToLower();

                Transport transport = null;

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

            }
        }
    }
}
