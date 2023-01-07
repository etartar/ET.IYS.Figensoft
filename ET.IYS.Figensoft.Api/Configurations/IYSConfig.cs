namespace ET.IYS.Figensoft.Api.Configurations
{
    public class IYSConfig
    {
        public string ApiKey { get; set; }
        public string BaseUrl { get; set; }
        public ElektronikIzinConfig ElektronikIzin { get; set; }
        public WhiteListConfig WhiteList { get; set; }
    }
}
