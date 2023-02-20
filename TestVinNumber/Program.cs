using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VIN_LIB.VIN vin = new VIN_LIB.VIN();
            Console.WriteLine($"Достоверность номера - {vin.CheckVIN("1ZVHT82H485113456")}");
            Console.WriteLine($"Географическая зона - {vin.GetVINCountry("1ZVHT82H485113456")}");
            Console.ReadKey();
        }
    }
}
