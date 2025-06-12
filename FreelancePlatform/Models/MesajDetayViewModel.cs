namespace FreelancePlatform.Models
{
    public class MesajDetayViewModel
    {
        public int ProjeID { get; set; }
        public string ProjeBaslik { get; set; } = string.Empty;
        public string GirisYapanEmail { get; set; } = string.Empty;
        public string KarsiTarafEmail { get; set; } = string.Empty;
        public List<Mesaj> Mesajlar { get; set; } = new();
    }
}
