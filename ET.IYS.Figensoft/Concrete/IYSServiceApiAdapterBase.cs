using ET.IYS.Figensoft.Abstract;

namespace ET.IYS.Figensoft.Concrete
{
    public class IYSServiceApiAdapterBase
    {
        private readonly IHttpClientFactory _httpClient;
        private readonly IIYSConfiguration _configuration;

        public IYSServiceApiAdapterBase(IHttpClientFactory httpClient, IIYSConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
    }
}
