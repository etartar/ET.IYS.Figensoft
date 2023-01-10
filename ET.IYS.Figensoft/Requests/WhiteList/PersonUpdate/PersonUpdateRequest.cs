namespace ET.IYS.Figensoft.Requests.WhiteList.PersonUpdate
{
    public class PersonUpdateRequest
    {
        public string Reason { get; set; }
        public string MustAddMasterAccount { get; set; }
        public string EvidenceType { get; set; }
        public string EvidenceData { get; set; }
        public PersonUpdatePersonRequest Person { get; set; }

        #region Methods

        public PersonUpdateRequest SetReason(string reason)
        {
            Reason = reason;
            return this;
        }

        public PersonUpdateRequest SetMustAddMasterAccount(string mustAddMasterAccount)
        {
            MustAddMasterAccount = mustAddMasterAccount;
            return this;
        }

        public PersonUpdateRequest SetEvidenceType(string evidenceType)
        {
            EvidenceType = evidenceType;
            return this;
        }

        public PersonUpdateRequest SetEvidenceData(string evidenceData)
        {
            EvidenceData = evidenceData;
            return this;
        }

        public PersonUpdateRequest CreatePerson(string personId, string nameSurname)
        {
            Person = new PersonUpdatePersonRequest(personId, nameSurname);
            return this;
        }

        public PersonUpdateRequest SetETKPermission(List<PersonUpdateETKPermissionRequest> etkPermissions)
        {
            etkPermissions.ForEach(ep =>
            {
                Person.ETK.CreatePermission(ep.PermissionCode, ep.PermissionText, ep.Contacts);
            });

            return this;
        }

        #endregion
    }
}
