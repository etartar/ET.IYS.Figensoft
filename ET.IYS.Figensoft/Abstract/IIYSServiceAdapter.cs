using ET.IYS.Figensoft.Requests.ElektronikIzin.DoubleOptinCodeVerify;
using ET.IYS.Figensoft.Requests.ElektronikIzin.PersonAdd;
using ET.IYS.Figensoft.Requests.ElektronikIzin.PersonAddWithDoubleOptin;
using ET.IYS.Figensoft.Requests.ElektronikIzin.StartDoubleOptinGSM;
using ET.IYS.Figensoft.Requests.WhiteList.PersonAdd;
using ET.IYS.Figensoft.Requests.WhiteList.PersonList;
using ET.IYS.Figensoft.Requests.WhiteList.PersonRemove;
using ET.IYS.Figensoft.Requests.WhiteList.PersonUpdate;
using ET.IYS.Figensoft.Responses.ElektronikIzin.DoubleOptinCodeVerify;
using ET.IYS.Figensoft.Responses.ElektronikIzin.PersonAdd;
using ET.IYS.Figensoft.Responses.ElektronikIzin.PersonAddWithDoubleOptin;
using ET.IYS.Figensoft.Responses.ElektronikIzin.StartDoubleOptinGSM;
using ET.IYS.Figensoft.Responses.WhiteList.CallList;
using ET.IYS.Figensoft.Responses.WhiteList.EmailList;
using ET.IYS.Figensoft.Responses.WhiteList.KvkList;
using ET.IYS.Figensoft.Responses.WhiteList.PersonAdd;
using ET.IYS.Figensoft.Responses.WhiteList.PersonList;
using ET.IYS.Figensoft.Responses.WhiteList.PersonQuery;
using ET.IYS.Figensoft.Responses.WhiteList.PersonRemove;
using ET.IYS.Figensoft.Responses.WhiteList.PersonUpdate;
using ET.IYS.Figensoft.Responses.WhiteList.ReceiverQuery;
using ET.IYS.Figensoft.Responses.WhiteList.SmsList;

namespace ET.IYS.Figensoft.Abstract
{
    public interface IIYSServiceAdapter
    {
        /// <summary>
        /// İzinli Pazarlama Sistemi üzerinden double optin izin alma işlemini başlatmak için kullanılacak metottur. 
        /// Bu api ile başlatılan izin alma işlerinde gsm numarasına bir kod gönderilir ve ardından bu kod ile beraber 
        /// WhiteListPersonAddWithDoubleOptin metodunun çağrılması beklenir.
        /// </summary>
        /// <returns>StatusCode, StatusDescription, Results</returns>
        Task<StartDoubleOptinGSMResponse> StartDoubleOptinGSM(StartDoubleOptinGSMRequest request);

        /// <summary>
        /// İzinli Pazarlama Sistemi üzerinden double optin izin alma işlemi sırasında StartDoubleOptin metodu ile 
        /// gönderilen kodların kontrol edilebilmesi için kullanılacak metottur. 
        /// Bu metot herhangi bir WhiteList işlemi yapmaz. 
        /// Sadece gönderilen doğruma kodunun geçerli olup olmadığını bilgisini verir.
        /// </summary>
        /// <returns>StatusCode, StatusDescription, Results</returns>
        Task<DoubleOptinCodeVerifyResponse> DoubleOptinCodeVerify(DoubleOptinCodeVerifyRequest request);

        /// <summary>
        /// İzinli Pazarlama Sistemine double optin yöntemi ile yeni kişi eklemek için kullanılacak metot dur. 
        /// Eğer ETK’ye göre Whitelist’e eklenmek istenen kişinin istek ile gönderilen iletişim adresleri daha önceden Blacklist’de yer alıyorsa, kişinin bu adresleri Blacklist’den silinir ve Whitelist’e eklenir.
        /// Gerektiğinde ilgili Whitelist’den çıkarma metotları ile listeden çıkarma işlemleri yapılabilir.
        /// </summary>
        /// <returns></returns>
        Task<PersonAddWithDoubleOptinResponse> PersonAddWithDoubleOptin(PersonAddWithDoubleOptinRequest request);

        /// <summary>
        /// İzinli Pazarlama Sistemine yeni kişi eklemek için kullanılacak metot dur. 
        /// Eğer ETK’ye göre Whitelist’e eklenmek istenen kişinin istek ile gönderilen iletişim adresleri daha önceden Blacklist’de yer alıyorsa, kişinin bu adresleri Blacklist’den silinir ve Whitelist’e eklenir. 
        /// Gerektiğinde ilgili Whitelist’den çıkarma metotları ile listeden çıkarma işlemleri yapılabilir.
        /// </summary>
        /// <returns></returns>
        Task<PersonAddResponse> PersonAdd(PersonAddRequest request);

        /// <summary>
        /// İzinli Pazarlama Sisteminde kayıtlı ve SMS gönderme izni alınmış numaralarının listesini veren uygulamadır.
        /// </summary>
        /// <param name="part">
        /// İstek sonucunda dönülecek SMS izinli listesi en fazla 25 bin olabilir. 
        /// Part parametresi ile alfabetik sıra ile sıralanmış kayıtlarınız arasından hangi 25 bin kaydı istediğinizi belirtebilirsiniz. 
        /// Boş gönderilirse 1 olarak kabul edilir ve istek sonucu ilk 25 bin kayıt döner. 
        /// 2 gönderilirse 25.001’den 50.000 inci kaydınıza kadar 25 bin kayıt döner.
        /// </param>
        /// <returns></returns>
        Task<SmsListResponse> SmsList(int part = 1);

        /// <summary>
        /// İzinli Pazarlama Sisteminde kayıtlı ve izin alınmış email adreslerin listesini veren uygulamadır.
        /// </summary>
        /// <param name="part">
        /// İstek sonucunda dönülecek SMS izinli listesi en fazla 25 bin olabilir. 
        /// Part parametresi ile alfabetik sıra ile sıralanmış kayıtlarınız arasından hangi 25 bin kaydı istediğinizi belirtebilirsiniz. 
        /// Boş gönderilirse 1 olarak kabul edilir ve istek sonucu ilk 25 bin kayıt döner. 
        /// 2 gönderilirse 25.001’den 50.000 inci kaydınıza kadar 25 bin kayıt döner.
        /// </param>
        /// <returns></returns>
        Task<EmailListResponse> EmailList(int part = 1);

        /// <summary>
        /// İzinli Pazarlama Sisteminde kayıtlı ve arama izni alınmış telefon numarası adreslerin listesini veren uygulamadır.
        /// </summary>
        /// <param name="part">
        /// İstek sonucunda dönülecek SMS izinli listesi en fazla 25 bin olabilir. 
        /// Part parametresi ile alfabetik sıra ile sıralanmış kayıtlarınız arasından hangi 25 bin kaydı istediğinizi belirtebilirsiniz. 
        /// Boş gönderilirse 1 olarak kabul edilir ve istek sonucu ilk 25 bin kayıt döner. 
        /// 2 gönderilirse 25.001’den 50.000 inci kaydınıza kadar 25 bin kayıt döner.
        /// </param>
        /// <returns></returns>
        Task<CallListResponse> CallList(int part = 1);

        /// <summary>
        /// İzinli Pazarlama Sisteminde kayıtlı ve KVK izni alınmış kişi bilgilerini veren uygulamadır.
        /// </summary>
        /// <param name="part">
        /// İstek sonucunda dönülecek SMS izinli listesi en fazla 25 bin olabilir. 
        /// Part parametresi ile alfabetik sıra ile sıralanmış kayıtlarınız arasından hangi 25 bin kaydı istediğinizi belirtebilirsiniz. 
        /// Boş gönderilirse 1 olarak kabul edilir ve istek sonucu ilk 25 bin kayıt döner. 
        /// 2 gönderilirse 25.001’den 50.000 inci kaydınıza kadar 25 bin kayıt döner.
        /// </param>
        /// <returns></returns>
        Task<KvkListResponse> KvkList(int part = 1);

        /// <summary>
        /// İzinli Pazarlama Sisteminde kayıtlı kişilerinizin bilgilerini veren uygulamadır.
        /// </summary>
        /// <returns></returns>
        Task<PersonListResponse> PersonList(PersonListRequest request);

        /// <summary>
        /// İzinli Pazarlama Sisteminde kayıtlı kişinin alınmış tüm izinlerini ve iletişim bilgilerini dönen uygulamadır. 
        /// Person id bilgisi gönderilen tek kişinin detaylarını döner.
        /// </summary>
        /// <param name="personId">İzin alınırken sisteme verilen tekil kişi bilgisini ifade eder. Bu parametre zorunludur.</param>
        /// <returns></returns>
        Task<PersonQueryResponse> PersonQuery(string personId);

        /// <summary>
        /// İzinli Pazarlama Sistemine yeni kişi eklemek için kullanılacak metot dur. 
        /// Eğer Whitelist’e eklenmek istenen kişinin istek ile gönderilen gsm numarası ya da email adresi daha önceden Blacklist’de yer alıyorsa, kişinin bu adresleri Blacklist’den silinir ve Whitelist’e eklenir. 
        /// ÖNEMLİ NOT: Elektronik izin toplama için Elektronik Izin Toplama sekmesindeki metotlar kullanılmalıdır. Aksi halde kanuni yükümlülük çözüm ortağına aittir. 
        /// </summary>
        /// <returns></returns>
        Task<WhiteListPersonAddResponse> WhiteListPersonAdd(WhiteListPersonAddRequest request);

        /// <summary>
        /// İzinli Pazarlama Sistemin’inde kişilerinizi WhiteList’den çıkarmak için kullanılacak metotdur. 
        /// İşlem sonunda sadece listeden çıkarılan kayıtlar döndürülecektir.
        /// </summary>
        /// <returns></returns>
        Task<PersonRemoveResponse> PersonRemove(PersonRemoveRequest request);

        /// <summary>
        /// İzinli Pazarlama Sistemine var olan PersonId’ye bağlı ETK iletişim izinlerinin kaldırılarak gönderilen yeni iletişim adreslerini ve izinleri eklemek için kullanılacak metotdur. 
        /// Bu metodda mevcut KVK izinleri için herhangi bir işlem yapılmaz. Yeni KVK izni eklenmez.
        /// Eğer Whitelist’ e eklenmek istenen kişinin istek ile gönderilen gsm numarası ya da email adresi daha önceden Blacklist’de yer alıyorsa, kişinin bu adresleri Blacklist’den silinir ve Whitelist’e eklenir.
        /// </summary>
        /// <returns></returns>
        Task<PersonUpdateResponse> PersonUpdate(PersonUpdateRequest request);

        /// <summary>
        /// İzinli Pazarlama Sisteminde kayıtlı adrese (GSM,Eposta,Sabit no) sahip tüm kişilerin (Person) listesini ve adresin hangi izinleri olduğunu bilgisini döner. 
        /// IVT sisteminde kişiler adres tekilliği ile değil person id tekilliği ile yönetilir. 
        /// Bir numaranın farklı zamanlarda alınmış izinleri varsa ve person id boş gönderildiyse, veya farklı person idler ile izinleri kaydedildiyse bu sorgu sonucunda aynı adrese sahip birden fazla kişiye ait izinler dönebilir.
        /// </summary>
        /// <returns></returns>
        Task<List<ReceiverQueryResponse>> ReceiverQuery(string receiver);
    }
}
