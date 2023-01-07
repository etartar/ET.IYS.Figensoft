using ET.IYS.Figensoft.Responses.Common;

namespace ET.IYS.Figensoft.Responses.WhiteList.PersonList
{
    public class PersonListResponseResult : PersonResponseBase
    {
        public PersonListKVKResponse KVK { get; set; }
        public PersonListETKResponse ETK { get; set; }
    }
}
