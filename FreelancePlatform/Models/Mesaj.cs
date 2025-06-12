namespace FreelancePlatform.Models
{
    public class Mesaj
    {
        public int MesajID { get; set; }
        public int ProjeID { get; set; }

        public string GonderenEmail { get; set; } = string.Empty;
        public string AliciEmail { get; set; } = string.Empty;
        public string GonderenAdSoyad { get; set; } = string.Empty;
        public string MesajIcerik { get; set; } = string.Empty;

        public DateTime GonderimTarihi { get; set; }
    }
}
