using ET.IYS.Figensoft.Requests.Common;
using ET.IYS.Figensoft.Requests.ElektronikIzin.ExtraIzinIzinData;

namespace ET.IYS.Figensoft.Requests.WhiteList.PersonAdd
{
    public class WhiteListPersonAddRequest
    {
        public string Reason { get; set; }
        public string MustAddMasterAccount { get; set; }
        public string EvidenceType { get; set; }
        public string EvidenceData { get; set; }
        public string EvidenceDataExtension { get; set; } = "txt";
        public WhiteListPersonAddPersonRequest Person { get; set; }
        public ExtraIzinIzinDataRequest? ExtraIzinIzinData { get; set; }

        #region Methods

        public WhiteListPersonAddRequest SetReason(string reason)
        {
            Reason = reason;
            return this;
        }

        public WhiteListPersonAddRequest SetMustAddMasterAccount(string mustAddMasterAccount)
        {
            MustAddMasterAccount = mustAddMasterAccount;
            return this;
        }

        public WhiteListPersonAddRequest SetEvidenceType(string evidenceType)
        {
            EvidenceType = evidenceType;
            return this;
        }

        public WhiteListPersonAddRequest SetEvidenceData(string evidenceData)
        {
            EvidenceData = evidenceData;
            return this;
        }

        public WhiteListPersonAddRequest SetEvidenceDataExtension(string evidenceDataExtension)
        {
            EvidenceDataExtension = evidenceDataExtension;
            return this;
        }

        public WhiteListPersonAddRequest CreatePerson(string personId, string nameSurname)
        {
            Person = new WhiteListPersonAddPersonRequest(personId, nameSurname);
            return this;
        }

        public WhiteListPersonAddRequest SetKVKPermission(List<KVKPermissionRequest> kvkPermissions)
        {
            kvkPermissions.ForEach(kp =>
            {
                Person.KVK.AddKVKPermission(kp.PermissionCode, kp.PermissionType, kp.PermissionText);
            });
            return this;
        }

        public WhiteListPersonAddRequest SetETKPermission(List<WhiteListPersonAddETKPermissionRequest> etkPermissions)
        {
            etkPermissions.ForEach(ep =>
            {
                Person.ETK.CreatePermission(ep.PermissionCode, ep.PermissionText, ep.Contacts);
            });

            return this;
        }

        public WhiteListPersonAddRequest SetExtraIzinIzinData(ExtraIzinIzinDataRequest extraIzinIzinDataRequest)
        {
            ExtraIzinIzinData = extraIzinIzinDataRequest;
            return this;
        }

        #endregion
    }
}
