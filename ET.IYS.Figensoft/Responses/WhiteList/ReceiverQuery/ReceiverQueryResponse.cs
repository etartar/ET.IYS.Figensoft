using ET.IYS.Figensoft.Responses.Common.Contact;

namespace ET.IYS.Figensoft.Responses.WhiteList.ReceiverQuery
{
    public class ReceiverQueryResponse
    {
        public string PersonId { get; set; }
        public string NameSurname { get; set; }
        public List<PermissionTimeContactResponse> ETKPermissions { get; set; }
    }
}
