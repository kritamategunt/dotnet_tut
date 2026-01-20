using System;
using System.Data;
using Dapper;
using helloWorld.Models;
using Microsoft.Data.SqlClient;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            // Console.WriteLine(
            //     "Computer:\nMotherboard: {0}\nCPU Cores: {1} \nVGA: {2}\nPrice: ${3}",
            //     myComputer.Motherboard,
            //     myComputer.CPUCores,
            //     myComputer.VideoCard,
            //     myComputer.Price
            // );

            // myComputer.HasWifi = false; // This line will cause a compile-time error because HasWifi has a private setter

            // Console.WriteLine("Has Wifi: " + myComputer.HasWifi);
            string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=True;Trusted_Connection=false;User Id=sa;Password=SQLConnect1!;";


            IDbConnection dbConnection = new SqlConnection(connectionString);

            string sqlCommandText = "SELECT GETDATE()";
            DateTime currentServerTime = dbConnection.QuerySingle<DateTime>(sqlCommandText);
            Console.WriteLine("Current Server Time: " + currentServerTime.ToString("F"));

            Computer myComputer = new Computer(
                motherboard: "ASUS ROG STRIX B550-F",
                cpuCores: 8,
                hasWifi: true,
                hasLTE: false,
                releaseDate: new DateTime(2021, 5, 15),
                price: 1299.99m,
                videoCard: "NVIDIA GeForce RTX 2060"
            );

            string insertSql = @"
INSERT INTO TutorAppSchema.Computer
(Motherboard, CPUCores, HasWifi, HasLTE, ReleaseDate, Price, VideoCard)
VALUES
(@Motherboard, @CPUCores, @HasWifi, @HasLTE, @ReleaseDate, @Price, @VideoCard);
";
            int result = dbConnection.Execute(insertSql, myComputer);


            // Console.WriteLine("Rows affected: " + result);




            string selectSql = "SELECT * FROM TutorAppSchema.Computer";
            IEnumerable<Computer> computerList = dbConnection.Query<Computer>(selectSql);

            foreach (var computer in computerList)
            {
                Console.WriteLine($"{computer.ComputerId}: {computer.Motherboard} - {computer.CPUCores} cores - ${computer.Price}");
            }
            Console.WriteLine("Total Computers: " + computerList.Count());

        }
    }
}