namespace ET.IYS.Figensoft.Api.Models.WhiteList.PersonRemove
{
    public class PersonRemoveRequestModel
    {
        public string Reason { get; set; }
        public string MustRemoveMasterAccount { get; set; }
        public string MustRemoveOtherDealers { get; set; }
        public string PersonId { get; set; }
        public string RemoveKVKPermission { get; set; }
        public PersonRemoveETKRequestModel? ETK { get; set; }
    }
}
