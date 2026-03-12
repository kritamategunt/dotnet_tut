using System;
using System.Data;
using Dapper;
using helloWorld.Data;
using helloWorld.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appSetting.json")
            .Build();

            DataContextDapper dapper = new DataContextDapper(configuration);

            string sqlCommandText = "SELECT GETDATE()";
            DateTime currentServerTime = dapper.LoadDataSingle<DateTime>(sqlCommandText);
            Console.WriteLine("Current Server Time: " + currentServerTime.ToString("F"));

            Computer myComputer = new Computer(
                motherboard: "ASUS ROG STRIX B550-F",
                cpuCores: 8,
                hasWifi: true,
                hasLTE: 1.0m,
                releaseDate: new DateTime(2021, 5, 15),
                price: 1299.99m,
                videoCard: "NVIDIA GeForce RTX 2060"
            );

            string insertSql = @"
INSERT INTO TutorAppSchema.Computer
(Motherboard, CPUCores, HasWifi, HasLTE, ReleaseDate, Price, VideoCard, AddingDate)
VALUES
(@Motherboard, @CPUCores, @HasWifi, @HasLTE, @ReleaseDate, @Price, @VideoCard, @AddingDate);
";

            //             dapper.ExecuteSqlWithRowCount<Computer>(insertSql
            //                 .Replace("@Motherboard", $"'{myComputer.Motherboard}'")
            //                 .Replace("@CPUCores", myComputer.CPUCores.ToString())
            //                 .Replace("@HasWifi", myComputer.HasWifi ? "1" : "0")
            //                 .Replace("@HasLTE", myComputer.HasLTE ? "1" : "0")
            //                 .Replace("@ReleaseDate", $"'{myComputer.ReleaseDate:yyyy-MM-dd}'")
            //                 .Replace("@Price", myComputer.Price.ToString())
            //                 .Replace("@VideoCard", $"'{myComputer.VideoCard}'")
            //                 .Replace("@AddingDate", $"'{DateTime.Now:yyyy-MM-dd}'")
            //             );


            // Console.WriteLine("Rows affected: " + result);


            DataContextEF entityFramework = new DataContextEF(configuration);
            entityFramework.Add(myComputer);
            entityFramework.SaveChanges();


            string selectSql = "SELECT * FROM TutorAppSchema.Computer";
            IEnumerable<Computer> computers = dapper.LoadData<Computer>(selectSql);
            //For demonstration, we can also load the computers using Entity Framework to compare results
            IEnumerable<Computer>? computersEF = entityFramework.Computer?.ToList();


            Console.WriteLine("Computers in Database:" + computersEF?.Count());
            if (computersEF != null)
            {
                foreach (var computer in computers)
                {
                    Console.WriteLine($"{computer.ComputerId}: {computer.Motherboard} - {computer.CPUCores} cores - ${computer.Price} Adding Date = {computer.AddingDate}");
                }
            }
            Console.WriteLine("Total Computers: " + computers.Count());


        }
    }
}
