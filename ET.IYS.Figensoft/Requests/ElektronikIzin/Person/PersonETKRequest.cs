namespace ET.IYS.Figensoft.Requests.ElektronikIzin.Person
{
    public class PersonETKRequest
    {
        public PersonETKRequest()
        {
            Permissions = new List<PersonETKPermissionRequest>();
        }

        public List<PersonETKPermissionRequest> Permissions { get; set; }

        public void CreatePermission(string permissionCode, string permissionText, List<PersonContactRequest> contactList)
        {
            Permissions.Add(new PersonETKPermissionRequest(permissionCode, permissionText, contactList));
        }
    }
}
