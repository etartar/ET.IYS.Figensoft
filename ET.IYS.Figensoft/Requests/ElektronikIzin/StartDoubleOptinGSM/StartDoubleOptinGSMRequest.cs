namespace ET.IYS.Figensoft.Requests.ElektronikIzin.StartDoubleOptinGSM
{
    public class StartDoubleOptinGSMRequest
    {
        /// <summary>
        /// Doğrulama kodunun gönderileceği, izin alınan GSM numarası bilgisidir. Bu parametre zorunludur.
        /// </summary>
        public string GsmNo { get; set; }

        /// <summary>
        /// kvkk (opsiyonel): alacağınız izinde KVK izni varsa 1 yoksa 0 gönderilmelidir. Default değeri 0 dir.
        /// </summary>
        public int Kvkk { get; set; } = 1;

        /// <summary>
        /// sms (opsiyonel): alacağınız izinde SMS izni varsa 1 yoksa 0 gönderilmelidir. Default değeri 0 dir.
        /// </summary>
        public int Sms { get; set; } = 0;

        /// <summary>
        /// audio (opsiyonel): alacağınız izinde SES izni varsa 1 yoksa 0 gönderilmelidir. Default değeri 0 dir.
        /// </summary>
        public int Audio { get; set; } = 0;

        /// <summary>
        /// email (opsiyonel): alacağınız izinde eposta izni varsa 1 yoksa 0 gönderilmelidir.Default değeri 0 dir.
        /// </summary>
        public int Email { get; set; } = 0;

        /// <summary>
        /// language (opsiyonel) : Doğrulama kodu mesajı için dil tercihidir. 
        /// Alabileceği değerler : 'tr', 'en' | Default değeri 'tr' dir.
        /// </summary>
        public string Language { get; set; } = "tr";

        public StartDoubleOptinGSMRequest()
        {
        }

        public StartDoubleOptinGSMRequest(string gsmNo, bool sms, bool audio, bool email, string language)
        {
            GsmNo = gsmNo;
            Kvkk = 1;
            Sms = sms ? 1 : 0;
            Audio = audio ? 1 : 0;
            Email = email ? 1 : 0;
            Language = language;
        }

        public StartDoubleOptinGSMRequest(string gsmNo, bool sms, bool audio, bool email)
        {
            GsmNo = gsmNo;
            Kvkk = 1;
            Sms = sms ? 1 : 0;
            Audio = audio ? 1 : 0;
            Email = email ? 1 : 0;
        }
    }
}
