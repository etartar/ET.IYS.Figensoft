using ET.IYS.Figensoft.Requests.Common;

namespace ET.IYS.Figensoft.Requests.ElektronikIzin.Person
{
    public class PersonETKPermissionRequest : ETKPermissionRequest
    {
        public PersonETKPermissionRequest()
        {
        }

        public PersonETKPermissionRequest(string permissionCode, string permissionText, List<PersonContactRequest> contacts)
        {
            PermissionCode = permissionCode;
            PermissionText = permissionText;
            Contacts = contacts;
        }

        public List<PersonContactRequest> Contacts { get; set; }
    }
}
