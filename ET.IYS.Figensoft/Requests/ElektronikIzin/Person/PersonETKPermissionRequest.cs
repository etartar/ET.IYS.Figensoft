using ET.IYS.Figensoft.Requests.Common;

namespace ET.IYS.Figensoft.Requests.ElektronikIzin.Person
{
    public class PersonETKPermissionRequest : ETKPermissionRequest
    {
        public List<PersonContactRequest> Contacts { get; set; }
    }
}
