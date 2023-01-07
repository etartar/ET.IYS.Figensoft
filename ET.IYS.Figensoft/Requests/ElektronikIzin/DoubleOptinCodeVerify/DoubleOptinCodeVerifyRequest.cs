namespace ET.IYS.Figensoft.Requests.ElektronikIzin.DoubleOptinCodeVerify
{
    public class DoubleOptinCodeVerifyRequest
    {
        /// <summary>
        /// Doğrulama kodunun gönderildiği, izin alınan GSM numarası bilgisidir.
        /// </summary>
        public string GsmNo { get; set; }

        /// <summary>
        /// Kullanıcının telefonuna giden SMS’deki doğrulama kodudur.
        /// </summary>
        public string DoubleOptinCode { get; set; }

        public DoubleOptinCodeVerifyRequest()
        {
        }

        public DoubleOptinCodeVerifyRequest(string gsmNo, string doubleOptinCode)
        {
            GsmNo = gsmNo;
            DoubleOptinCode = doubleOptinCode;
        }
    }
}
