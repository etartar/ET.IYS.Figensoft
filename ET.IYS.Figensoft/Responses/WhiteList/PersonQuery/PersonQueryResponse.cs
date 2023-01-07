using ET.IYS.Figensoft.Responses.Common;

namespace ET.IYS.Figensoft.Responses.WhiteList.PersonQuery
{
    public class PersonQueryResponse : PersonResponseBase
    {
        public PersonQueryKVKResponse KVK { get; set; }
        public PersonQueryETKResponse ETK { get; set; }
    }
}
