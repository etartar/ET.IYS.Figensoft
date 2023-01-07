using ET.IYS.Figensoft.Abstract;
using Microsoft.Extensions.Options;

namespace ET.IYS.Figensoft.Api.Configurations
{
    public class IYSConfiguration : IIYSConfiguration
    {
        private readonly IYSConfig _config;

        public IYSConfiguration(IOptionsSnapshot<IYSConfig> config)
        {
            _config = config.Value;
        }

        public string ApiKey => _config.ApiKey;

        public string BaseUrl => _config.BaseUrl;

        public string ElektronikIzin_StartDoubleOptinGSMUrl => _config.ElektronikIzin.StartDoubleOptinGSMUrl;

        public string ElektronikIzin_DoubleOptinCodeVerifyUrl => _config.ElektronikIzin.DoubleOptinCodeVerifyUrl;

        public string ElektronikIzin_PersonAddWithDoubleOptinUrl => _config.ElektronikIzin.PersonAddWithDoubleOptinUrl;

        public string ElektronikIzin_PersonAddUrl => _config.ElektronikIzin.PersonAddUrl;

        public string Whitelist_SmsListUrl => _config.WhiteList.SmsListUrl;

        public string Whitelist_EmailListUrl => _config.WhiteList.EmailListUrl;

        public string Whitelist_CallListUrl => _config.WhiteList.CallListUrl;

        public string Whitelist_KvkListUrl => _config.WhiteList.KvkListUrl;

        public string Whitelist_PersonListUrl => _config.WhiteList.PersonListUrl;

        public string Whitelist_PersonQueryUrl => _config.WhiteList.PersonQueryUrl;

        public string Whitelist_PersonAddUrl => _config.WhiteList.PersonAddUrl;

        public string Whitelist_PersonRemoveUrl => _config.WhiteList.PersonRemoveUrl;

        public string Whitelist_PersonUpdateUrl => _config.WhiteList.PersonUpdateUrl;

        public string Whitelist_ReceiverQueryUrl => _config.WhiteList.ReceiverQueryUrl;
    }
}
