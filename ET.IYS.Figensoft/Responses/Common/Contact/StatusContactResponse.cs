using ET.IYS.Figensoft.Constants;

namespace ET.IYS.Figensoft.Responses.Common.Contact
{
    public class StatusContactResponse : ContactResponse
    {
        public string Status { get; set; }
        public string StatusDescription => GetMessage;

        private string GetMessage
        {
            get
            {
                IYSContants.StatusCodes.TryGetValue(Status, out string message);
                return message;
            }
        }
    }
}
