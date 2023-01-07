namespace ET.IYS.Figensoft.Requests.WhiteList.PersonUpdate
{
    public class PersonUpdatePersonRequest
    {
        public string PersonId { get; set; }
        public string NameSurname { get; set; }
        public List<PersonUpdateETKRequest> ETK { get; set; }
    }
}
