namespace ET.IYS.Figensoft.Api.Models.ElektronikIzın.PersonAdd
{
    public class PersonAddRequestModel
    {
        public string PersonId { get; set; }
        public string NameSurname { get; set; }
        public string GsmNumber { get; set; }
        public string MustAddMasterAccount { get; set; }
        public string Reason { get; set; }
        public List<PersonKVKPermissionRequestModel> KVK { get; set; }
        public List<PersonETKPermissionRequestModel> ETK { get; set; }
        public ExtraIzinIzinDataRequestModel? ExtraIzinIzinData { get; set; }
    }
}
