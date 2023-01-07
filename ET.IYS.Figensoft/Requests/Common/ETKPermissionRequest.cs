namespace ET.IYS.Figensoft.Requests.Common
{
    public class ETKPermissionRequest
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
        /// İzin alırken kişiye onaylatılan izin metnidir. 
        /// Onaylatılan izin metinleri değiştirildiğinde PermissionCode alanına yeni bir kod verilmelidir. 
        /// Bu sayede hangi izinin hangi izin metni verisyonu ile alındığı bilgisi tutulabilecektir. 
        /// İleride olabilecek yönetmelik değişikliklerinde hangi izinlerin geçersiz sayılabileceği konusunda bize yön gösterecek bir alandır. 
        /// Bu alan gönderilmesi zorunlu bir alandır.
        /// </summary>
        public string PermissionText { get; set; }
    }
}
