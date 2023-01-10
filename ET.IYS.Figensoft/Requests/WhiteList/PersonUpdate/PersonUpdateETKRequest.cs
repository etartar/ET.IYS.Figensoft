using ET.IYS.Figensoft.Requests.Common;

namespace ET.IYS.Figensoft.Requests.WhiteList.PersonUpdate
{
    public class PersonUpdateETKRequest
    {
        public PersonUpdateETKRequest()
        {
            Permissions = new List<PersonUpdateETKPermissionRequest>();
        }

        public List<PersonUpdateETKPermissionRequest> Permissions { get; set; }


        public void CreatePermission(string permissionCode, string permissionText, List<ContactRequest> contactList)
        {
            Permissions.Add(new PersonUpdateETKPermissionRequest(permissionCode, permissionText, contactList));
        }
    }
}
