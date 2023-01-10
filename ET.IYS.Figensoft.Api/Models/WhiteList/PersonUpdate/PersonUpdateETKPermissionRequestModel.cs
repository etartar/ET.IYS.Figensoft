namespace ET.IYS.Figensoft.Api.Models.WhiteList.PersonUpdate
{
    public class PersonUpdateETKPermissionRequestModel
    {
        public string PermissionCode { get; set; }
        public string PermissionText { get; set; }
        public List<PersonUpdateContactRequestModel> Contacts { get; set; }
    }
}
