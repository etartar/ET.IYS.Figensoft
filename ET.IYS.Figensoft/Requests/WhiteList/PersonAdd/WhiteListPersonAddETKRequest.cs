using ET.IYS.Figensoft.Requests.Common;

namespace ET.IYS.Figensoft.Requests.WhiteList.PersonAdd
{
    public class WhiteListPersonAddETKRequest
    {
        public WhiteListPersonAddETKRequest()
        {
            Permissions = new List<WhiteListPersonAddETKPermissionRequest>();
        }

        public List<WhiteListPersonAddETKPermissionRequest> Permissions { get; set; }

        public void CreatePermission(string permissionCode, string permissionText, List<ContactRequest> contactList)
        {
            Permissions.Add(new WhiteListPersonAddETKPermissionRequest(permissionCode, permissionText, contactList));
        }
    }
}
