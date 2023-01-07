using ET.IYS.Figensoft.Constants;

namespace ET.IYS.Figensoft.Responses
{
    public class IYSApiResponse
    {
        private string _statusDescription;

        public IYSApiResponse()
        {
        }

        public bool IsSuccess
        {
            get { return StatusCode.Equals(IYSContants.SuccessStatusCode); }
        }
        public string StatusCode { get; set; }
        public string StatusDescription
        {
            get { return IsSuccess ? _statusDescription : GetMessage; }
            set { _statusDescription = value; }
        }

        private string GetMessage
        {
            get
            {
                IYSContants.StatusCodes.TryGetValue(StatusCode, out string message);
                return message;
            }
        }
    }
}
