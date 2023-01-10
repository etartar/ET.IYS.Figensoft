using ET.IYS.Figensoft.Requests.Common;

namespace ET.IYS.Figensoft.Requests.WhiteList.PersonUpdate
{
    public class PersonUpdateETKPermissionRequest : ETKPermissionRequest
    {
        public PersonUpdateETKPermissionRequest()
        {
        }

        public PersonUpdateETKPermissionRequest(string permissionCode, string permissionText, List<ContactRequest> contacts)
        {
            PermissionCode = permissionCode;
            PermissionText = permissionText;
            Contacts = contacts;
        }

        public List<ContactRequest> Contacts { get; set; }
    }
}
