﻿namespace CarManufacturer
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3"; 
            car.Year = 1992;

            Console.WriteLine(car.ToString());
        }
    }
}