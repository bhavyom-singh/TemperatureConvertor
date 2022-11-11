using System;

namespace TemperatureConvertor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter C or F");
            string temperatureUnit = Console.ReadLine().ToLower();
            Console.WriteLine("Enter temperature");
            string temperature = Console.ReadLine();
            TemperatureConvertor temperatureConvertor = new TemperatureConvertor();
            switch (temperatureUnit)
            {
                case "c":
                    Console.WriteLine("Temperature in Farenheit : " + temperatureConvertor.TemperatureF(Convert.ToDecimal(temperature)));
                    break;
                case "f":
                    Console.WriteLine("Temperature in Celsius : " + temperatureConvertor.TemperatureC(Convert.ToDecimal(temperature)));
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }

    }
    public class TemperatureConvertor
    {
        public decimal TemperatureC(decimal tempF)
        {
            return (tempF - 32) * 5 / 9;
        }

        public decimal TemperatureF(decimal tempC)
        {
            return 32 + (tempC * 9 / 5);
        }
    }
}
