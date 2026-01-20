using System;
using helloWorld.Models;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer(
                motherboard: "ASUS ROG STRIX B550-F",
                cpuCores: 8,
                hasWifi: true,
                hasLTE: false,
                releaseDate: new DateTime(2021, 5, 15),
                price: 1299.99m,
                videoCard: "NVIDIA GeForce RTX 2060"
            );


            Console.WriteLine(
                "Computer:\nMotherboard: {0}\nCPU Cores: {1} \nVGA: {2}\nPrice: ${3}",
                myComputer.Motherboard,
                myComputer.CPUCores,
                myComputer.VideoCard,
                myComputer.Price
            );

            myComputer.HasWifi = false; // This line will cause a compile-time error because HasWifi has a private setter

            Console.WriteLine("Has Wifi: " + myComputer.HasWifi);

        }
    }
}