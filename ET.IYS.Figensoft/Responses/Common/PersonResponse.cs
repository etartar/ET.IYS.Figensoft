using ET.IYS.Figensoft.Responses.Common.ETK;
using ET.IYS.Figensoft.Responses.Common.KVK;

namespace ET.IYS.Figensoft.Responses.Common
{
    public class PersonResponse : PersonResponseBase
    {
        public KVKResponse KVK { get; set; }
        public ETKResponse ETK { get; set; }
    }
}
