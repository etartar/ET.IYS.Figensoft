using ET.IYS.Figensoft.Requests.Common;

namespace ET.IYS.Figensoft.Requests.WhiteList.PersonUpdate
{
    public class PersonUpdateETKPermissionRequest : ETKPermissionRequest
    {
        public List<ContactRequest> Contacts { get; set; }
    }
}
