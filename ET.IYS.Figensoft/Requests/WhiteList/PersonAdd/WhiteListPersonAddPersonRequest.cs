using ET.IYS.Figensoft.Requests.Common;

namespace ET.IYS.Figensoft.Requests.WhiteList.PersonAdd
{
    public class WhiteListPersonAddPersonRequest
    {
        public WhiteListPersonAddPersonRequest()
        {
        }

        public WhiteListPersonAddPersonRequest(string personId, string nameSurname)
        {
            PersonId = personId;
            NameSurname = nameSurname;
            KVK = new KVKRequest();
            ETK = new WhiteListPersonAddETKRequest();
        }

        public string PersonId { get; set; }
        public string NameSurname { get; set; }
        public KVKRequest KVK { get; set; }
        public WhiteListPersonAddETKRequest ETK { get; set; }
    }
}
