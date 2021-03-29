using JsonValidationPoc.Model;
using System;
using System.IO;
using System.Text.Json;

namespace JsonValidationPoc
{
    class Program
    {
        static void Main(string[] args)
        {

            string jsonPath = "Json/car.json";

            if (File.Exists(jsonPath))
            {
                Car car = JsonSerializer.Deserialize<Car>(jsonPath);
                if (car != null)
                {
                    Console.WriteLine($"Car : Brand : {car.Brand} ; {car.Model} ; {car.EnginePower}");
                }
            }
        }
    }
}
