using ET.IYS.Figensoft.Responses.Common.Contact;

namespace ET.IYS.Figensoft.Responses.Common.ETK
{
    public class ETKPermissionResponse
    {
        public string PermissionCode { get; set; }
        public List<StatusContactResponse> Contacts { get; set; }
    }
}
