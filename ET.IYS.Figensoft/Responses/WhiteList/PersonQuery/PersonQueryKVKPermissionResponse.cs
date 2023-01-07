using ET.IYS.Figensoft.Responses.Common.KVK;

namespace ET.IYS.Figensoft.Responses.WhiteList.PersonQuery
{
    public class PersonQueryKVKPermissionResponse : KVKPermissionResponse
    {
        public string PermissionVersion { get; set; }
        public string LastPermissionVersion { get; set; }
        public string PermissionTime { get; set; }
    }
}
