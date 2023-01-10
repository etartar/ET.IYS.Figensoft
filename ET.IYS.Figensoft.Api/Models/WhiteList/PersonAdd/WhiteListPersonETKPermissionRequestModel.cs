namespace ET.IYS.Figensoft.Api.Models.WhiteList.PersonAdd
{
    public class WhiteListPersonETKPermissionRequestModel
    {
        public string PermissionCode { get; set; }
        public string PermissionText { get; set; }
        public List<WhiteListPersonContactRequestModel> Contacts { get; set; }
    }
}
