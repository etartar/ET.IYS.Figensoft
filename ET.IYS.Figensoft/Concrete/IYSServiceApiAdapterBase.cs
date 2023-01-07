using ET.IYS.Figensoft.Abstract;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace ET.IYS.Figensoft.Concrete
{
    public class IYSServiceApiAdapterBase
    {
        private readonly IHttpClientFactory _httpClient;
        protected readonly IIYSConfiguration _configuration;

        public IYSServiceApiAdapterBase(IHttpClientFactory httpClient, IIYSConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;

            ApiBaseUrl = _configuration.BaseUrl;
        }

        protected string ApiBaseUrl { get; set; }
        protected string ContentType { get; set; } = "application/json";
        protected string BaseData => _configuration.ApiKey;

        protected HttpClient CreateClient()
        {
            HttpClient client = _httpClient.CreateClient();

            client.BaseAddress = new Uri(ApiBaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ContentType));

            return client;
        }

        protected JsonSerializerSettings GetJsonSerializerSettings
        {
            get
            {
                return new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Include,
                    Culture = CultureInfo.InvariantCulture,
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                    Converters = new List<JsonConverter>
                    {
                        new StringEnumConverter()
                    }
                };
            }
        }

        protected string GetRequestData(object value) => JsonConvert.SerializeObject(value, GetJsonSerializerSettings);

        protected async Task<HttpResponseMessage> SendAsync(HttpMethod httpMethod, string url, string requestData = "")
        {
            using HttpClient client = CreateClient();
            HttpRequestMessage request = new HttpRequestMessage(httpMethod, url);

            if (!string.IsNullOrEmpty(requestData))
                request.Content = new StringContent(requestData, Encoding.UTF8, ContentType);

            return await client.SendAsync(request);
        }
    }
}
