using ET.IYS.Figensoft.Responses.Common.Contact;

namespace ET.IYS.Figensoft.Responses.Common.ETK
{
    public class ETKPermissionTimeResponse
    {
        public string PermissionCode { get; set; }
        public string PermissionVersion { get; set; }
        public List<PermissionTimeContactResponse> Contacts { get; set; }
    }
}
