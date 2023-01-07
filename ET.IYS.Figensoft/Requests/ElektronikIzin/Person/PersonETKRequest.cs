namespace ET.IYS.Figensoft.Requests.ElektronikIzin.Person
{
    public class PersonETKRequest
    {
        private readonly List<PersonContactRequest> _contactList;

        public PersonETKRequest()
        {
            _contactList = new List<PersonContactRequest>();
            Permissions = new List<PersonETKPermissionRequest>();
        }

        public List<PersonETKPermissionRequest> Permissions { get; set; }

        public void CreateContact(string permissionChannel, string receiverType, string receiver, string? informationGsm)
        {
            if (string.IsNullOrEmpty(informationGsm))
                _contactList.Add(new PersonContactRequest(permissionChannel, receiverType, receiver));
            else
                _contactList.Add(new PersonContactRequest(permissionChannel, receiverType, receiver, informationGsm));
        }

        public void CreatePermission(string permissionCode, string permissionText)
        {
            Permissions.Add(new PersonETKPermissionRequest(permissionCode, permissionText, _contactList));
        }
    }
}
