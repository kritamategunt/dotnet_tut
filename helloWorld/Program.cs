using System;
using System.Data;
using Dapper;
using helloWorld.Data;
using helloWorld.Models;
using Microsoft.Data.SqlClient;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            DataContextDapper  dapper = new DataContextDapper();

            // Console.WriteLine(
            //     "Computer:\nMotherboard: {0}\nCPU Cores: {1} \nVGA: {2}\nPrice: ${3}",
            //     myComputer.Motherboard,
            //     myComputer.CPUCores,
            //     myComputer.VideoCard,
            //     myComputer.Price
            // );

            // myComputer.HasWifi = false; // This line will cause a compile-time error because HasWifi has a private setter

            // Console.WriteLine("Has Wifi: " + myComputer.HasWifi);
            // string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=True;Trusted_Connection=false;User Id=sa;Password=SQLConnect1!;";


            // IDbConnection dbConnection = new SqlConnection(connectionString);

            string sqlCommandText = "SELECT GETDATE()";
            DateTime currentServerTime = dapper.LoadDataSingle<DateTime>(sqlCommandText);
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
(Motherboard, CPUCores, HasWifi, HasLTE, ReleaseDate, Price, VideoCard, AddingDate)
VALUES
(@Motherboard, @CPUCores, @HasWifi, @HasLTE, @ReleaseDate, @Price, @VideoCard, @AddingDate);
";

            dapper.ExecuteSqlWithRowCount<Computer>(insertSql
                .Replace("@Motherboard", $"'{myComputer.Motherboard}'")
                .Replace("@CPUCores", myComputer.CPUCores.ToString())
                .Replace("@HasWifi", myComputer.HasWifi ? "1" : "0")
                .Replace("@HasLTE", myComputer.HasLTE ? "1" : "0")
                .Replace("@ReleaseDate", $"'{myComputer.ReleaseDate:yyyy-MM-dd}'")
                .Replace("@Price", myComputer.Price.ToString())
                .Replace("@VideoCard", $"'{myComputer.VideoCard}'")
                .Replace("@AddingDate", $"'{DateTime.Now:yyyy-MM-dd}'")
            );
            

            // Console.WriteLine("Rows affected: " + result);




            string selectSql = "SELECT * FROM TutorAppSchema.Computer";
            IEnumerable<Computer> computers = dapper.LoadData<Computer>(selectSql);
            Console.WriteLine("Computers in Database:");
            foreach (var computer in computers)
            {
                Console.WriteLine($"{computer.ComputerId}: {computer.Motherboard} - {computer.CPUCores} cores - ${computer.Price} Adding Date = {computer.AddingDate}" );
            }
            Console.WriteLine("Total Computers: " + computers.Count());            //IEnumerable<Computer> computerList = dbConnection.Query<Computer>(selectSql);

            // foreach (var computer in computerList)
            // {
            //     Console.WriteLine($"{computer.ComputerId}: {computer.Motherboard} - {computer.CPUCores} cores - ${computer.Price}");
            // }
            // Console.WriteLine("Total Computers: " + computerList.Count());



        }
    }
}