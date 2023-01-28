namespace Bilet_4.ViewModels
{
    public class SettingViewModel
    {
        public int? Id { get; set; }
        public string? SiteName { get; set; }
        public string? CallCenter { get; set; }
        public string? Location { get; set; }
        public IFormFile? Logo { get; set; }
        public IFormFile? Icon { get; set; }
    }
}
