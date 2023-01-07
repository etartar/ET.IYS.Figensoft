namespace ET.IYS.Figensoft.Abstract
{
    public interface IIYSConfiguration
    {
        string ApiKey { get; }
        string BaseUrl { get; }
        string ElektronikIzin_StartDoubleOptinGSMUrl { get; }
        string ElektronikIzin_DoubleOptinCodeVerifyUrl { get; }
        string ElektronikIzin_PersonAddWithDoubleOptinUrl { get; }
        string ElektronikIzin_PersonAddUrl { get; }
        string Whitelist_SmsListUrl { get; }
        string Whitelist_EmailListUrl { get; }
        string Whitelist_CallListUrl { get; }
        string Whitelist_KvkListUrl { get; }
        string Whitelist_PersonListUrl { get; }
        string Whitelist_PersonQueryUrl { get; }
        string Whitelist_PersonAddUrl { get; }
        string Whitelist_PersonRemoveUrl { get; }
        string Whitelist_PersonUpdateUrl { get; }
        string Whitelist_ReceiverQueryUrl { get; }
    }
}
