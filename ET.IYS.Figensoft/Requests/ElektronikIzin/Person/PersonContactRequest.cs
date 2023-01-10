using ET.IYS.Figensoft.Requests.Common;

namespace ET.IYS.Figensoft.Requests.ElektronikIzin.Person
{
    public class PersonContactRequest : ContactRequest
    {
        public PersonContactRequest()
        {
        }

        public PersonContactRequest(string permissionChannel, string receiverType, string receiver) 
            : base(permissionChannel, receiverType, receiver)
        {
        }

        public PersonContactRequest(string permissionChannel, string receiverType, string receiver, string informationGsm)
            : base(permissionChannel, receiverType, receiver)
        {
            InformationGsm = informationGsm;
        }

        /// <summary>
        /// Elektronik izin toplama işlemi sonrası izin alınan kişiye bilgilendirme yapılması zorunluluğu bulunmaktadır. 
        /// Etk izinleri için ReceiverType parametresinin değerinin SABIT_TELEFON ve EPOSTA olduğu durumlarda veya sadece KVK izni alındığı durumlarda SMS ile bilgilendirme yapılabilmesi için Gsm numarası gerekmektedir. 
        /// Bu alana bu bilgilendirme yapılacak Gsm numarası girilmelidir.
        /// </summary>
        public string InformationGsm { get; set; }
    }
}
