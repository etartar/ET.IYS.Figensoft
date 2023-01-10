using ET.IYS.Figensoft.Requests.Common;

namespace ET.IYS.Figensoft.Api.Models.WhiteList.PersonRemove
{
    public class PersonRemoveETKRequestModel
    {
        public string RemoveETKPermissionType { get; set; }
        public List<PersonRemoveContactRequestModel> Contacts { get; set; }
    }
}
