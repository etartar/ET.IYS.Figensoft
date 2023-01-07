namespace ET.IYS.Figensoft.Api.Models.ElektronikIzın.PersonAdd
{
    public class PersonAddWithDoubleOptinRequestModel : PersonAddRequestModel
    {
        public string VerificationGsmNo { get; set; }
        public string VerificationCode { get; set; }
    }
}
