using ET.IYS.Figensoft.Requests.Common;
using ET.IYS.Figensoft.Requests.ElektronikIzin.ExtraIzinIzinData;
using ET.IYS.Figensoft.Requests.ElektronikIzin.Person;

namespace ET.IYS.Figensoft.Requests.ElektronikIzin.PersonAdd
{
    public class PersonAddRequest
    {
        /// <summary>
        /// Merkez/Bayi ilişkisi bulunan firmaların kullanacağı bir alandır. 
        /// Öncesinde Merkez/Bayi ilişkisi olan hesaplar sisteme Figensoft tarafından tanımlanmalıdır. 
        /// Bu alan aşağıdaki değerleri alabilir;
        /// <list type="number">
        /// <item>Bayi için eklenen alıcı Merkez içinde eklensin</item>
        /// <item>Bu alıcı sadece bayi için eklensin</item>
        /// </list>
        /// </summary>
        public string MustAddMasterAccount { get; set; }

        /// <summary>
        /// Yapılan işlem için girilecek yorum bilgisidir.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// İstekle beraber gönderilecek olan delil dosyası veya delil dosyası için oluşturulmuş metin base64 encodelanarak bu alanda gönderilmelidir. 
        /// Ses, metin ya da benzeri kanıt olabilecek dosyalar gönderilecektir. 
        /// Kanıt olarak sadece metin gönderilirse, tarafımızda bu metin txt dosya uzantısı ile kaydedilecektir.
        /// </summary>
        public string EvidenceData { get; set; }

        /// <summary>
        /// İstekle gönderilecek kanıt dosyasınını uzantısıdır. Boş gönderilirse kanıt dosyasının uzantısı .txt olacaktır.
        /// </summary>
        public string EvidenceDataExtension { get; set; } = "txt";

        /// <summary>
        /// Gönderilmesi zorunlu bir parametre değildir. Gönderilmezse default “tr” değeri alır. 
        /// Bu parametre izin aldığınız kişiye gönderilecek bilgilendirme mesajının dilini ifade eder.
        /// Alabileceği değerler : tr , en
        /// </summary>
        public string Language { get; set; } = "tr";

        public PersonRequest Person { get; set; }

        /// <summary>
        /// Bu alan gönderilmesi zorunlu bir alan değildir.
        /// IzinIzin Platformu üzerinde tutulmak istenen veriler için bu alan kullanılacaktır. 
        /// Veriler Figensoft tarafından sağlanan formatta gönderilmelidir. Öncesinde Figensoft tarafında tanım yapılmalıdır.
        /// Gönderilen values dizisindeki label değerleri de ön tanımlı olmalıdır.
        /// </summary>
        public ExtraIzinIzinDataRequest? ExtraIzinIzinData { get; set; }

        #region Methods

        public PersonAddRequest SetReason(string reason)
        {
            Reason = reason;
            return this;
        }

        public PersonAddRequest SetMustAddMasterAccount(string mustAddMasterAccount)
        {
            MustAddMasterAccount = mustAddMasterAccount;
            return this;
        }

        public PersonAddRequest SetEvidenceData(string evidenceData)
        {
            EvidenceData = evidenceData;
            return this;
        }

        public PersonAddRequest SetEvidenceDataExtension(string evidenceDataExtension)
        {
            EvidenceDataExtension = evidenceDataExtension;
            return this;
        }

        public PersonAddRequest SetLanguage(string language)
        {
            Language = language;
            return this;
        }

        public PersonAddRequest CreatePerson(string personId, string nameSurname, string informationGsm)
        {
            Person = new PersonRequest(personId, nameSurname, informationGsm);
            return this;
        }

        public PersonAddRequest SetKVKPermission(List<KVKPermissionRequest> kvkPermissions)
        {
            kvkPermissions.ForEach(kp =>
            {
                Person.KVK.AddKVKPermission(kp.PermissionCode, kp.PermissionType, kp.PermissionText);
            });
            return this;
        }

        public PersonAddRequest SetETKPermission(List<PersonETKPermissionRequest> etkPermissions)
        {
            etkPermissions.ForEach(ep =>
            {
                Person.ETK.CreatePermission(ep.PermissionCode, ep.PermissionText, ep.Contacts);
            });

            return this;
        }

        public PersonAddRequest SetExtraIzinIzinData(ExtraIzinIzinDataRequest extraIzinIzinDataRequest)
        {
            ExtraIzinIzinData = extraIzinIzinDataRequest;
            return this;
        }

        #endregion
    }
}
