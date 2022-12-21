using ET.IYS.Figensoft.Abstract;
using ET.IYS.Figensoft.Responses;

namespace ET.IYS.Figensoft.Concrete
{
    public class IYSServiceApiAdapter : IYSServiceApiAdapterBase, IIYSService
    {
        public IYSServiceApiAdapter(IHttpClientFactory httpClient, IIYSConfiguration configuration) 
            : base(httpClient, configuration)
        {
        }

        public async Task<IYSApiResponse> StartDoubleOptinGSM(string gsmNo, int kvk = 0, int sound = 0, int sms = 0, int email = 0, string language = "tr")
        {
            //
        }

        public async Task<IYSApiResponse> DoubleOptinCodeVerify(string gsmNo, int doubleOptinCode)
        {
            throw new NotImplementedException();
        }
    }
}
