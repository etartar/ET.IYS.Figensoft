namespace ET.IYS.Figensoft.Requests.ElektronikIzin.Person
{
    public class PersonRequest
    {
        public PersonRequest()
        {
        }

        public PersonRequest(string personId, string nameSurname, string informationGsm)
        {
            PersonId = personId;
            NameSurname = nameSurname;
            KVK = new PersonKVKRequest(informationGsm);
            ETK = new PersonETKRequest();
        }

        /// <summary>
        /// Kişinin tarafınızda tutulan tekil anahtarıdır. Maksimum 50 karakter gönderilmelidir. 
        /// String yada int değerler olabilir. Bu alan her bir kişi için farklı olmalıdır. 
        /// Aksi taktirde bir ret hakkı kullanımında yanlış kişilerde ret listesine eklenebilir. 
        /// Bu alan gönderilmesi zorunlu bir alandır.
        /// </summary>
        public string PersonId { get; set; }

        /// <summary>
        /// Kişinin ad soyad bilgisidir. 
        /// Maksimum 500 karakter gönderilmelidir. 
        /// String değerler olabilir. 
        /// Bu alan gönderilmesi zorunlu bir alandır.
        /// </summary>
        public string NameSurname { get; set; }

        /// <summary>
        /// Kişinin kaydedilecek KVK izinlerini ifade eder. 
        /// KVK altındaki Permissions alanı ile birden fazla tipte ve farklı izin metinleri ile KVK izinleri kaydedilebilir.
        /// </summary>
        public PersonKVKRequest KVK { get; set; }

        /// <summary>
        /// Kişinin kaydedilecek elektronik izinlerini ifade eder. 
        /// ETK altındaki Permissions alanı ile birden fazla tipte ve farklı izin metinleri ile ETK izinleri kaydedilebilir. 
        /// İzin alınanan iletişim adresi; gsm numarası, sabit telefon numarası veya email adresi olabilir, bu değerler ETK izninin altında Contacts alanında gönderilecektir.
        /// </summary>
        public PersonETKRequest ETK { get; set; }
    }
}
