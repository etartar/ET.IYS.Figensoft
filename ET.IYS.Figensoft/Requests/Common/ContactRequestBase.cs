namespace ET.IYS.Figensoft.Requests.Common
{
    public class ContactRequestBase
    {
        /// <summary>
        /// Alınan iznin hangi iletişim kanalları için geçerli olduğunu ifade etmektedir. 
        /// Bu alan gönderilmesi zorunlu bir alandır. 
        /// Bu alanın alabileceği değerler;
        /// <list type="bullet">
        /// <item>SMS: Alınan iznin SMS gönderebilmek için uygun olduğunu ifade eder.</item>
        /// <item>SES: Alınan iznin sesli arama için uygun olduğunu ifade eder.</item>
        /// <item>EPOSTA: Alınan iznin eposta gönderebilmek için uygun olduğunu ifade eder.</item>
        /// </list>
        /// </summary>
        public string PermissionChannel { get; set; }

        /// <summary>
        /// İzin alınınan iletişim adresinin(Receiver parametresinin değeri) hangi tipini ifade etmektedir. 
        /// Bu alan gönderilmesi zorunlu bir alandır. 
        /// Bu alanın alabileceği değerler;
        /// <list type="bullet">
        /// <item>GSM: Receiver parametresinin bir GSM numarası olduğunu ifade eder.</item>
        /// <item>EPOSTA: Receiver parametresinin bir eposta adresi olduğunu ifade eder.</item>
        /// <item>SABIT_TELEFON: Receiver parametresinin bir sabit telefon numarası olduğunu ifade eder.</item>
        /// </list>
        /// </summary>
        public string ReceiverType { get; set; }

        public string Receiver { get; set; }
    }
}
