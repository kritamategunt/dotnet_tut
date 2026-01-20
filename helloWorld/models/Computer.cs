namespace helloWorld.Models
{
    class Computer
    {
        public string Motherboard { get; set; } = "";
        public int CPUCores { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; } = "";

        public Computer(
            string motherboard,
            int cpuCores,
            bool hasWifi,
            bool hasLTE,
            DateTime releaseDate,
            decimal price,
            string? videoCard = null)
        {
            Motherboard = motherboard;
            CPUCores = cpuCores;
            HasWifi = hasWifi;
            HasLTE = hasLTE;
            ReleaseDate = releaseDate;
            Price = price;
            VideoCard = videoCard ?? "";
        }
    }
}
