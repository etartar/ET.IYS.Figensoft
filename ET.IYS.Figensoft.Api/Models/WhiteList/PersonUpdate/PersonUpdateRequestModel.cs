namespace ET.IYS.Figensoft.Api.Models.WhiteList.PersonUpdate
{
    public class PersonUpdateRequestModel
    {
        public string PersonId { get; set; }
        public string NameSurname { get; set; }
        public string MustAddMasterAccount { get; set; }
        public string Reason { get; set; }
        public string EvidenceType { get; set; }
        public List<PersonUpdateETKPermissionRequestModel> ETK { get; set; }
    }
}
