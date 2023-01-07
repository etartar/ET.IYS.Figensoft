using ET.IYS.Figensoft.Requests.Common;

namespace ET.IYS.Figensoft.Requests.WhiteList.PersonRemove
{
    public class PersonRemoveETKRequest
    {
        public string RemoveETKPermissionType { get; set; }
        public List<ContactRequestBase> Contacts { get; set; }
    }
}
