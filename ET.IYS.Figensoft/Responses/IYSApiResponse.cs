using ET.IYS.Figensoft.Constants;

namespace ET.IYS.Figensoft.Responses
{
    public class IYSApiResponse
    {
        public IYSApiResponse(bool isSuccess, string statusCode, string statusDescription)
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
            StatusDescription = statusDescription;
        }

        public IYSApiResponse(bool isSuccess, string statusCode, string statusDescription, string results) 
            : this(isSuccess, statusCode, statusDescription)
        {
            Results = results;
        }

        public bool IsSuccess { get; set; }
        public string StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public string Results { get; set; }
        public string Message => $"{StatusDescription} | {GetMessage}";

        private string GetMessage()
        {
            string message = string.Empty;

            IYSContants.StatusCodes.TryGetValue(StatusCode, out message);

            return message;
        }
    }
}
