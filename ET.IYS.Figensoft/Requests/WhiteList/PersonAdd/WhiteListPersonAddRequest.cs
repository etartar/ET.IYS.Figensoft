using ET.IYS.Figensoft.Requests.ElektronikIzin.ExtraIzinIzinData;

namespace ET.IYS.Figensoft.Requests.WhiteList.PersonAdd
{
    public class WhiteListPersonAddRequest
    {
        public string Reason { get; set; }
        public string MustAddMasterAccount { get; set; }
        public string EvidenceType { get; set; }
        public string EvidenceData { get; set; }
        public string EvidenceDataExtension { get; set; }
        public WhiteListPersonAddPersonRequest Person { get; set; }
        public ExtraIzinIzinDataRequest? ExtraIzinIzinData { get; set; }
    }
}
