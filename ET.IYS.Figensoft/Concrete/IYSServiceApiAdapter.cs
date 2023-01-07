using ET.IYS.Figensoft.Abstract;
using ET.IYS.Figensoft.Requests.ElektronikIzin.DoubleOptinCodeVerify;
using ET.IYS.Figensoft.Requests.ElektronikIzin.PersonAdd;
using ET.IYS.Figensoft.Requests.ElektronikIzin.PersonAddWithDoubleOptin;
using ET.IYS.Figensoft.Requests.ElektronikIzin.StartDoubleOptinGSM;
using ET.IYS.Figensoft.Requests.WhiteList.PersonAdd;
using ET.IYS.Figensoft.Requests.WhiteList.PersonList;
using ET.IYS.Figensoft.Requests.WhiteList.PersonRemove;
using ET.IYS.Figensoft.Requests.WhiteList.PersonUpdate;
using ET.IYS.Figensoft.Responses.ElektronikIzin.DoubleOptinCodeVerify;
using ET.IYS.Figensoft.Responses.ElektronikIzin.PersonAdd;
using ET.IYS.Figensoft.Responses.ElektronikIzin.PersonAddWithDoubleOptin;
using ET.IYS.Figensoft.Responses.ElektronikIzin.StartDoubleOptinGSM;
using ET.IYS.Figensoft.Responses.WhiteList.CallList;
using ET.IYS.Figensoft.Responses.WhiteList.EmailList;
using ET.IYS.Figensoft.Responses.WhiteList.KvkList;
using ET.IYS.Figensoft.Responses.WhiteList.PersonAdd;
using ET.IYS.Figensoft.Responses.WhiteList.PersonList;
using ET.IYS.Figensoft.Responses.WhiteList.PersonQuery;
using ET.IYS.Figensoft.Responses.WhiteList.PersonRemove;
using ET.IYS.Figensoft.Responses.WhiteList.PersonUpdate;
using ET.IYS.Figensoft.Responses.WhiteList.ReceiverQuery;
using ET.IYS.Figensoft.Responses.WhiteList.SmsList;
using Newtonsoft.Json;
using System.Text;

namespace ET.IYS.Figensoft.Concrete
{
    public class IYSServiceApiAdapter : IYSServiceApiAdapterBase, IIYSServiceAdapter
    {
        public IYSServiceApiAdapter(IHttpClientFactory httpClient, IIYSConfiguration configuration) 
            : base(httpClient, configuration)
        {
        }

        #region Elektronik İzin Toplama

        public async Task<StartDoubleOptinGSMResponse> StartDoubleOptinGSM(StartDoubleOptinGSMRequest request)
        {
            StringBuilder url = new();
            url.Append($"{_configuration.ElektronikIzin_StartDoubleOptinGSMUrl}{BaseData}");
            url.Append($"?gsmNo={request.GsmNo}&kvk={request.Kvkk}&ses={request.Audio}&sms={request.Sms}&eposta={request.Email}&language={request.Language}");

            HttpResponseMessage result = await SendAsync(HttpMethod.Get, url.ToString());
            string data = await result.Content.ReadAsStringAsync();
            StartDoubleOptinGSMResponse response = JsonConvert.DeserializeObject<StartDoubleOptinGSMResponse>(data);
            return response;
        }

        public async Task<DoubleOptinCodeVerifyResponse> DoubleOptinCodeVerify(DoubleOptinCodeVerifyRequest request)
        {
            StringBuilder url = new();
            url.Append($"{_configuration.ElektronikIzin_DoubleOptinCodeVerifyUrl}{BaseData}");
            url.Append($"?gsmNo={request.GsmNo}&doubleOptionCode={request.DoubleOptinCode}");

            HttpResponseMessage result = await SendAsync(HttpMethod.Get, url.ToString());
            string data = await result.Content.ReadAsStringAsync();
            DoubleOptinCodeVerifyResponse response = JsonConvert.DeserializeObject<DoubleOptinCodeVerifyResponse>(data);
            return response;
        }

        public async Task<PersonAddResponse> PersonAdd(PersonAddRequest request)
        {
            string url = $"{_configuration.ElektronikIzin_PersonAddUrl}{BaseData}";

            HttpResponseMessage result = await SendAsync(HttpMethod.Post, url.ToString(), GetRequestData(request));
            string data = await result.Content.ReadAsStringAsync();
            PersonAddResponse response = JsonConvert.DeserializeObject<PersonAddResponse>(data);
            return response;
        }

        public async Task<PersonAddWithDoubleOptinResponse> PersonAddWithDoubleOptin(PersonAddWithDoubleOptinRequest request)
        {
            string url = $"{_configuration.ElektronikIzin_PersonAddWithDoubleOptinUrl}{BaseData}";

            HttpResponseMessage result = await SendAsync(HttpMethod.Post, url.ToString(), GetRequestData(request));
            string data = await result.Content.ReadAsStringAsync();
            PersonAddWithDoubleOptinResponse response = JsonConvert.DeserializeObject<PersonAddWithDoubleOptinResponse>(data);
            return response;
        }

        #endregion

        #region İzinli Veritabanı Yönetimi

        public async Task<SmsListResponse> SmsList(int part = 1)
        {
            StringBuilder url = new();
            url.Append($"{_configuration.Whitelist_SmsListUrl}{BaseData}");
            url.Append($"?Part={part}");

            HttpResponseMessage result = await SendAsync(HttpMethod.Get, url.ToString());
            string data = await result.Content.ReadAsStringAsync();
            SmsListResponse response = JsonConvert.DeserializeObject<SmsListResponse>(data);
            return response;
        }

        public async Task<EmailListResponse> EmailList(int part = 1)
        {
            StringBuilder url = new();
            url.Append($"{_configuration.Whitelist_EmailListUrl}{BaseData}");
            url.Append($"?Part={part}");

            HttpResponseMessage result = await SendAsync(HttpMethod.Get, url.ToString());
            string data = await result.Content.ReadAsStringAsync();
            EmailListResponse response = JsonConvert.DeserializeObject<EmailListResponse>(data);
            return response;
        }
        
        public async Task<CallListResponse> CallList(int part = 1)
        {
            StringBuilder url = new();
            url.Append($"{_configuration.Whitelist_CallListUrl}{BaseData}");
            url.Append($"?Part={part}");

            HttpResponseMessage result = await SendAsync(HttpMethod.Get, url.ToString());
            string data = await result.Content.ReadAsStringAsync();
            CallListResponse response = JsonConvert.DeserializeObject<CallListResponse>(data);
            return response;
        }
        
        public async Task<KvkListResponse> KvkList(int part = 1)
        {
            StringBuilder url = new();
            url.Append($"{_configuration.Whitelist_KvkListUrl}{BaseData}");
            url.Append($"?Part={part}");

            HttpResponseMessage result = await SendAsync(HttpMethod.Get, url.ToString());
            string data = await result.Content.ReadAsStringAsync();
            KvkListResponse response = JsonConvert.DeserializeObject<KvkListResponse>(data);
            return response;
        }

        public async Task<PersonListResponse> PersonList(PersonListRequest request)
        {
            StringBuilder url = new();
            url.Append($"{_configuration.Whitelist_PersonListUrl}{BaseData}");
            url.Append($"?page={request.Page}&pageSize={request.PageSize}");

            HttpResponseMessage result = await SendAsync(HttpMethod.Get, url.ToString());
            string data = await result.Content.ReadAsStringAsync();
            PersonListResponse response = JsonConvert.DeserializeObject<PersonListResponse>(data);
            return response;
        }

        public async Task<PersonQueryResponse> PersonQuery(string personId)
        {
            StringBuilder url = new();
            url.Append($"{_configuration.Whitelist_PersonQueryUrl}{BaseData}");
            url.Append($"?PersonId={personId}");

            HttpResponseMessage result = await SendAsync(HttpMethod.Get, url.ToString());
            string data = await result.Content.ReadAsStringAsync();
            PersonQueryResponse response = JsonConvert.DeserializeObject<PersonQueryResponse>(data);
            return response;
        }

        public async Task<WhiteListPersonAddResponse> WhiteListPersonAdd(WhiteListPersonAddRequest request)
        {
            string url = $"{_configuration.Whitelist_PersonAddUrl}{BaseData}";

            HttpResponseMessage result = await SendAsync(HttpMethod.Post, url.ToString(), GetRequestData(request));
            string data = await result.Content.ReadAsStringAsync();
            WhiteListPersonAddResponse response = JsonConvert.DeserializeObject<WhiteListPersonAddResponse>(data);
            return response;
        }

        public async Task<PersonRemoveResponse> PersonRemove(PersonRemoveRequest request)
        {
            string url = $"{_configuration.Whitelist_PersonRemoveUrl}{BaseData}";

            HttpResponseMessage result = await SendAsync(HttpMethod.Post, url.ToString(), GetRequestData(request));
            string data = await result.Content.ReadAsStringAsync();
            PersonRemoveResponse response = JsonConvert.DeserializeObject<PersonRemoveResponse>(data);
            return response;
        }

        public async Task<PersonUpdateResponse> PersonUpdate(PersonUpdateRequest request)
        {
            string url = $"{_configuration.Whitelist_PersonUpdateUrl}{BaseData}";

            HttpResponseMessage result = await SendAsync(HttpMethod.Post, url.ToString(), GetRequestData(request));
            string data = await result.Content.ReadAsStringAsync();
            PersonUpdateResponse response = JsonConvert.DeserializeObject<PersonUpdateResponse>(data);
            return response;
        }

        public async Task<List<ReceiverQueryResponse>> ReceiverQuery(string receiver)
        {
            StringBuilder url = new();
            url.Append($"{_configuration.Whitelist_ReceiverQueryUrl}{BaseData}");
            url.Append($"?Receiver={receiver}");

            HttpResponseMessage result = await SendAsync(HttpMethod.Get, url.ToString());
            string data = await result.Content.ReadAsStringAsync();
            List<ReceiverQueryResponse> response = JsonConvert.DeserializeObject<List<ReceiverQueryResponse>>(data);
            return response;
        }

        #endregion
    }
}
