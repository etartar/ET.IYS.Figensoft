namespace ET.IYS.Figensoft.Abstract
{
    public interface IIYSConfiguration
    {
        string ApiKey { get; }
        string BaseUrl { get; }
        string StartDoubleOptinGSMUrl { get; }
        string DoubleOptinCodeVerifyUrl { get; }
    }
}
