using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather
{
    class Program
    {
        static void Main(string[] args)
        {
            int weather;
            int celsius;
            Random rand = new Random();
            weather = rand.Next(1, 4);
            celsius = rand.Next(-40, 40);
            switch (weather)
            {
                case 1:
                    Console.WriteLine("Ясная");
                    Console.WriteLine(celsius);
                    break;
                case 2:
                    Console.WriteLine("дождь");
                    Console.WriteLine(celsius);
                    break;
                case 3:
                    Console.WriteLine("облачно");
                    Console.WriteLine(celsius);
                    break;
                case 4:
                    Console.WriteLine("снег");
                    Console.WriteLine(celsius);
                    break;
            }
            Console.ReadKey();
        }
    }
}
