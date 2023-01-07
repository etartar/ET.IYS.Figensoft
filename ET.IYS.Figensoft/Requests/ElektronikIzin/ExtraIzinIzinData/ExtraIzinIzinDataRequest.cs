namespace ET.IYS.Figensoft.Requests.ElektronikIzin.ExtraIzinIzinData
{
    public class ExtraIzinIzinDataRequest
    {
        public string refFormGuid { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string IzinMetni { get; set; }
        public List<ExtraIzinIzinDataValueRequest> Values { get; set; }
    }
}
