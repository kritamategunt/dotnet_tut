namespace helloWorld.Models
{
    public class Computer
    {
        // 🔑 Required by both EF & Dapper
        public int ComputerId { get; private set; }

        public string Motherboard { get; private set; } = "";
        public int CPUCores { get; private set; }
        public bool HasWifi { get; private set; }
        public bool HasLTE { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public decimal Price { get; private set; }
        public string VideoCard { get; private set; } = "";
        public DateTime AddingDate { get; private set; }

        // ✅ REQUIRED for EF + Dapper
        private Computer() { }

        // ✅ Your domain constructor
        public Computer(
            string motherboard,
            int cpuCores,
            bool hasWifi,
            bool hasLTE,
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
