namespace ET.IYS.Figensoft.Requests.WhiteList.PersonUpdate
{
    public class PersonUpdatePersonRequest
    {
        public PersonUpdatePersonRequest()
        {
        }

        public PersonUpdatePersonRequest(string personId, string nameSurname)
        {
            PersonId = personId;
            NameSurname = nameSurname;
            ETK = new PersonUpdateETKRequest();
        }

        public string PersonId { get; set; }
        public string NameSurname { get; set; }
        public PersonUpdateETKRequest ETK { get; set; }
    }
}
