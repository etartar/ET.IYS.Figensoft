namespace ET.IYS.Figensoft.Constants
{
    public static class IYSContants
    {
        public static readonly string SuccessStatusCode = "200";

        public static Dictionary<string, string> StatusCodes => new Dictionary<string, string>()
        {
            { "200", "İşleminiz başarı ile yapıldı." },
            { "100", "Geçersiz Gsm No ya da gerçersiz Email adresi" },
            { "101", "Geçersiz kanıt dosyası. Kanıt dosyası gönderilmemiş olabilir. Kanıt dosyası boş olabilir" },            
            { "102", "Geçersiz açıklama. Gönderilen açıklama boş olabilir" },
            { "103", "Eksik parametre var api doc inceleyiniz. API ye gönderilen en az bir parameter eksik" },
            { "104", "Yapılacak işlem bulunamadı, API’nin yapacağı işlem tanımlı değil" },
            { "105", "Firma profili aktif değil. Bilgi için 0212 349 09 44" },
            { "106", "Bu işlem için yetkiniz yok. Bilgi için 0212 349 09 44. Erişmeye çalıştığınız Metot’a erişim yetkiniz olmayabilir. IP kısıtlaması tanımı yapıldıysa belirlenen IP’lerden gelmiyor olabilirsiniz" },
            { "107", "Firma kullanıcısı aktif değil. Bilgi için 0212 349 09 44" },
            { "500", "İsleminiz yapılırken hata oluştu. Sunucu taraflı hata oluşmuş olabilir." },
            { "108", "Yüklenecek maksimum dosya sayısı aşıldı. Kanıt olarak gönderebileceğiz maksimum dosya sayısını aşmış olabilirsiniz. Sistem genelinde dosya sayısı maksimum 3 adettir." },
            { "109", "Maksimum dosya boyutu aşıldı. Gönderdiğiniz dosyaların boyutu izin verilen maksimum dosya boyutundan fazla olabilir. Sistem genelinde maksimum 1MB’dir." },
            { "110", "Geçersiz içerik. [KEYWORD] anahtar kelimesi bulunamadı" },
            { "111", "API tanımlamalarınız eksik. Bilgi için 0212 349 09 44" },
            { "112", "Tanımlı email bulunamadı. Tanımlama işlemleri için 0212 349 09 44" },
            { "113", "Geçersiz kanıt tipi" },
            { "114", "Kullanılmak istenen \"PersonId\" değeri 50 karakterden uzun yada daha önce kullanılmış" },
            { "115", "Geçerli bir lisansınız yok. Bilgi için 0212 349 09 44" },
            { "116", "Yeterli lisans sayınız yok. Bilgi için 0212 349 09 44" },
            { "117", "Maksimum kayıt sayısı(25000) aşıldı. Lütfen gönderdiğiniz kayıt sayısını azaltınız." },
            { "118", "Maksimum kayıt sayısı(25000) aşıldı. Lütfen To ve From parametreleri ile sorgunuzu daraltınız." },
            { "119", "Double optin kodu geçerli değil." }
        };
    }
}
