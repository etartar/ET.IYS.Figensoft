namespace ET.IYS.Figensoft.Requests.Common
{
    public class KVKPermissionRequest
    {
        /// <summary>
        /// Bu alan izin alan firmanın kendi tarafında tuttuğu izin metni yada aydınlatma metninin kodu veya versiyon bilgisini ifade eder. 
        /// Onaylatılan izin metinleri değiştirildiğinde PermissionCode alanına yeni bir kod verilmelidir. 
        /// Bu sayede hangi izinin hangi izin metni verisyonu ile alındığı bilgisi tutulabilecektir. 
        /// İleride olabilecek yönetmelik değişikliklerinde hangi izinlerin geçersiz sayılabileceği konusunda bize yön gösterecek bir alandır. 
        /// Bu alan gönderilmesi zorunlu bir alandır.
        /// </summary>
        public string PermissionCode { get; set; }

        /// <summary>
        /// Bu alan izin alınan kişinin hangi izinlere onay verdiğini ifade etmektedir. 
        /// Bu alan gönderilmesi zorunlu bir alandır. 
        /// Alabileceği değerler ve anlamları: KVK izni için;
        /// <list type="bullet">
        /// <item>AYDINLATMA: İzin alınan kişinin KVK aydınlatma metnini onayladığını ifade eder.</item>
        /// <item>GENEL: İzin alınan kişinin KVK izni verdiği anlamına gelir.</item>
        /// </list>
        /// </summary>
        public string PermissionType { get; set; }

        /// <summary>
        /// İzin alırken kişiye onaylatılan izin metnidir. 
        /// Onaylatılan izin metinleri değiştirildiğinde PermissionCode alanına yeni bir kod verilmelidir. 
        /// Bu sayede hangi izinin hangi izin metni versiyonu ile alındığı bilgisi tutulabilecektir. 
        /// İleride olabilecek yönetmelik değişikliklerinde hangi izinlerin geçersiz sayılabileceği konusunda bize yön gösterecek bir alandır. 
        /// Bu alan gönderilmesi zorunlu bir alandır.
        /// </summary>
        public string PermissionText { get; set; }
        public string PermissionTime { get; set; }
    }
}
