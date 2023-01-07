namespace ET.IYS.Figensoft.Requests.Common
{
    public class KVKRequest
    {
        public KVKRequest()
        {
            Permissions = new List<KVKPermissionRequest>();
        }

        public List<KVKPermissionRequest> Permissions { get; set; }
    }
}
