using ET.IYS.Figensoft.Responses;

namespace ET.IYS.Figensoft.Abstract
{
    public interface IIYSService
    {
        /// <summary>
        /// İzinli Pazarlama Sistemi üzerinden double optin izin alma işlemini başlatmak için kullanılacak metottur. 
        /// Bu api ile başlatılan izin alma işlerinde gsm numarasına bir kod gönderilir ve ardından bu kod ile beraber WhiteListPersonAddWithDoubleOptin metodunun çağrılması beklenir.
        /// </summary>
        /// <param name="gsmNo">Doğrulama kodunun gönderileceği, izin alınan GSM numarası bilgisidir. Bu parametre zorunludur.</param>
        /// <param name="kvk">kvk (opsiyonel): alacağınız izinde KVK izni varsa 1 yoksa 0 gönderilmelidir. Default değeri 0 dir.</param>
        /// <param name="sound">sound (opsiyonel): alacağınız izinde SES izni varsa 1 yoksa 0 gönderilmelidir. Default değeri 0 dir.</param>
        /// <param name="sms">sms (opsiyonel): alacağınız izinde SMS izni varsa 1 yoksa 0 gönderilmelidir. Default değeri 0 dir.</param>
        /// <param name="email">email (opsiyonel): alacağınız izinde eposta izni varsa 1 yoksa 0 gönderilmelidir.Default değeri 0 dir.</param>
        /// <param name="language">language (opsiyonel) : Doğrulama kodu mesajı için dil tercihidir. Alabileceği değerler : 'tr', 'en' | Default değeri 'tr' dir.</param>
        /// <returns>StatusCode, StatusDescription, Results</returns>
        Task<IYSApiResponse> StartDoubleOptinGSM(string gsmNo, int kvk = 0, int sound = 0, int sms = 0, int email = 0, string language = "tr");

        /// <summary>
        /// İzinli Pazarlama Sistemi üzerinden double optin izin alma işlemi sırasında StartDoubleOptin metodu ile gönderilen kodların kontrol edilebilmesi için kullanılacak metottur. 
        /// Bu metot herhangi bir WhiteList işlemi yapmaz. 
        /// Sadece gönderilen doğruma kodunun geçerli olup olmadığını bilgisini verir.
        /// </summary>
        /// <param name="gsmNo">Doğrulama kodunun gönderildiği, izin alınan GSM numarası bilgisidir.</param>
        /// <param name="doubleOptinCode">Kullanıcının telefonuna giden SMS’deki doğrulama kodudur.</param>
        /// <returns>StatusCode, StatusDescription, Results</returns>
        Task<IYSApiResponse> DoubleOptinCodeVerify(string gsmNo, int doubleOptinCode);
    }
}
