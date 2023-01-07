namespace ET.IYS.Figensoft.Requests.WhiteList.PersonList
{
    public class PersonListRequest
    {
        public PersonListRequest()
        {
        }

        public PersonListRequest(int page, int pageSize)
        {
            Page = page;
            PageSize = pageSize;
        }

        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
