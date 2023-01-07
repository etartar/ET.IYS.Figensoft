namespace ET.IYS.Figensoft.Api.Models.ElektronikIzın.PersonAdd
{
    public class PersonETKPermissionRequestModel
    {
        public string PermissionCode { get; set; }
        public string PermissionText { get; set; }
        public List<PersonContactRequestModel> Contacts { get; set; }
    }
}
