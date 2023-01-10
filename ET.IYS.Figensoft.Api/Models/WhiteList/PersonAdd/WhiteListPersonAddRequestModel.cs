using ET.IYS.Figensoft.Api.Models.ElektronikIzın.PersonAdd;

namespace ET.IYS.Figensoft.Api.Models.WhiteList.PersonAdd
{
    public class WhiteListPersonAddRequestModel
    {
        public string PersonId { get; set; }
        public string NameSurname { get; set; }
        public string MustAddMasterAccount { get; set; }
        public string Reason { get; set; }
        public string EvidenceType { get; set; }
        public List<WhiteListPersonKVKPermissionRequestModel> KVK { get; set; }
        public List<WhiteListPersonETKPermissionRequestModel> ETK { get; set; }
        public ExtraIzinIzinDataRequestModel? ExtraIzinIzinData { get; set; }
    }
}
