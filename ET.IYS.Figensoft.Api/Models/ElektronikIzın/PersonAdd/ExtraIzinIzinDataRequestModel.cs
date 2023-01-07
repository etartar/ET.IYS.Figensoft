namespace ET.IYS.Figensoft.Api.Models.ElektronikIzın.PersonAdd
{
    public class ExtraIzinIzinDataRequestModel
    {
        public string RefFormGuid { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string IzinMetni { get; set; }
        public List<ExtraIzinIzinDataValueRequestModel> Values { get; set; }
    }
}
