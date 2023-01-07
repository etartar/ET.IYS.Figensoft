using ET.IYS.Figensoft.Requests.Common;

namespace ET.IYS.Figensoft.Requests.WhiteList.PersonAdd
{
    public class WhiteListPersonAddETKPermissionRequest : ETKPermissionRequest
    {
        public List<ContactRequest> Contacts { get; set; }
    }
}
