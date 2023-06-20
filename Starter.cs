using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_module3
{
    public static class Starter
    {
        public static void Start()
        {
            Console.WriteLine("Welcom to the BMW Motor Show");
            Console.WriteLine();
            string[] cars = { "M3", "M4", "M5", "M8", "X5M", "X3M", "X7M", "X8M" };
            var bmwmotorshow = new MyList<string>();
            bmwmotorshow.AddRange(cars);
            Console.WriteLine();
            Console.WriteLine("add M2:");
            bmwmotorshow.Add("new M2 Competition");
            bmwmotorshow.Sort();
            foreach (var car in bmwmotorshow)
            {
                if (car != default)
                {
                    Console.WriteLine(car);
                }
            }

            Console.WriteLine();
            Console.WriteLine("DElete M5:");
            bmwmotorshow.Remove("M5");
            foreach (var car in bmwmotorshow)
            {
                if (car != default)
                {
                    Console.WriteLine(car);
                }
            }

            Console.WriteLine();
            Console.WriteLine("delete by index-2:");
            bmwmotorshow.RemoveAt(2);
            foreach (var car in bmwmotorshow)
            {
                if (car != default)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
