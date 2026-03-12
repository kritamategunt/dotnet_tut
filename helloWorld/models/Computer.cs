namespace helloWorld.Models
{
    public class Computer
    {
        // 🔑 Required by both EF & Dapper
        public int ComputerId { get; set; }

        public string Motherboard { get; set; } = "";
        public int CPUCores { get; set; }
        public bool HasWifi { get; set; }
        public decimal HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; } = "";
        public DateTime AddingDate { get; set; }

        // ✅ REQUIRED for EF + Dapper
        private Computer() { }

        // ✅ Your domain constructor
        public Computer(
            string motherboard,
            int cpuCores,
            bool hasWifi,
            decimal hasLTE,
            DateTime releaseDate,
            decimal price,
            string videoCard)
        {
            Motherboard = motherboard;
            CPUCores = cpuCores;
            HasWifi = hasWifi;
            HasLTE = hasLTE;
            ReleaseDate = releaseDate;
            Price = price;
            VideoCard = videoCard;
            AddingDate = DateTime.UtcNow;
        }
    }
}
