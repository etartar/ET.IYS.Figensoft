namespace ET.IYS.Figensoft.Requests.WhiteList.PersonUpdate
{
    public class PersonUpdateRequest
    {
        public string Reason { get; set; }
        public string MustAddMasterAccount { get; set; }
        public string EvidenceType { get; set; }
        public string EvidenceData { get; set; }
        public PersonUpdatePersonRequest Person { get; set; }
    }
}
