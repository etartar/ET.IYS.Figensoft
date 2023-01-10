namespace ET.IYS.Figensoft.Requests.Common
{
    public class ContactRequest : ContactRequestBase
    {
        public ContactRequest()
        {
        }

        public ContactRequest(string permissionChannel, string receiverType, string receiver)
        {
            PermissionChannel = permissionChannel;
            ReceiverType = receiverType;
            Receiver = receiver;
            PermissionTime = DateTime.Now.ToString();
        }

        public string PermissionTime { get; set; }
    }
}
