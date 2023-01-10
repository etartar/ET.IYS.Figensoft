using ET.IYS.Figensoft.Requests.Common;

namespace ET.IYS.Figensoft.Requests.WhiteList.PersonAdd
{
    public class WhiteListPersonAddETKPermissionRequest : ETKPermissionRequest
    {
        public WhiteListPersonAddETKPermissionRequest()
        {
        }

        public WhiteListPersonAddETKPermissionRequest(string permissionCode, string permissionText, List<ContactRequest> contacts)
        {
            PermissionCode = permissionCode;
            PermissionText = permissionText;
            Contacts = contacts;
        }

        public List<ContactRequest> Contacts { get; set; }
    }
}
