namespace ET.IYS.Figensoft.Requests.WhiteList.PersonRemove
{
    public class PersonRemoveRequest
    {
        public string Reason { get; set; }
        public string MustRemoveMasterAccount { get; set; }
        public string MustRemoveOtherDealers { get; set; }
        public string PersonId { get; set; }
        public string RemoveKVKPermission { get; set; }
        public PersonRemoveETKRequest ETK { get; set; }
    }
}
