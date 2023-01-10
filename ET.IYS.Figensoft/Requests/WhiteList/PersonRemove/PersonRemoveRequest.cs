namespace ET.IYS.Figensoft.Requests.WhiteList.PersonRemove
{
    public class PersonRemoveRequest
    {
        public string Reason { get; set; }
        public string MustRemoveMasterAccount { get; set; }
        public string MustRemoveOtherDealers { get; set; }
        public string PersonId { get; set; }
        public string RemoveKVKPermission { get; set; }
        public PersonRemoveETKRequest ETK { get; set; }

        #region Methods

        public PersonRemoveRequest SetReason(string reason)
        {
            Reason = reason;
            return this;
        }

        public PersonRemoveRequest SetMustRemoveMasterAccount(string mustRemoveMasterAccount)
        {
            MustRemoveMasterAccount = mustRemoveMasterAccount;
            return this;
        }

        public PersonRemoveRequest SetMustRemoveOtherDealers(string mustRemoveOtherDealers)
        {
            MustRemoveOtherDealers = mustRemoveOtherDealers;
            return this;
        }

        public PersonRemoveRequest SetPersonId(string personId)
        {
            PersonId = personId;
            return this;
        }

        public PersonRemoveRequest SetRemoveKVKPermission(string removeKVKPermission)
        {
            RemoveKVKPermission = removeKVKPermission;
            return this;
        }
        
        public PersonRemoveRequest SetETK(PersonRemoveETKRequest etk)
        {
            ETK = etk;
            return this;
        }

        #endregion
    }
}
