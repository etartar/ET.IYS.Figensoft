using ET.IYS.Figensoft.Abstract;
using ET.IYS.Figensoft.Requests.WhiteList.PersonList;
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
using Microsoft.AspNetCore.Mvc;

namespace ET.IYS.Figensoft.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WhiteListController : ControllerBase
    {
        private readonly IIYSServiceAdapter _iysService;

        public WhiteListController(IIYSServiceAdapter iysService)
        {
            _iysService = iysService;
        }

        [HttpGet]
        public async Task<IActionResult> SmsList([FromQuery]int part)
        {
            SmsListResponse response = await _iysService.SmsList(part);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> EmailList([FromQuery]int part)
        {
            EmailListResponse response = await _iysService.EmailList(part);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> CallList([FromQuery]int part)
        {
            CallListResponse response = await _iysService.CallList(part);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> KvkList([FromQuery]int part)
        {
            KvkListResponse response = await _iysService.KvkList(part);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> PersonList([FromQuery]int page, int pageSize)
        {
            PersonListRequest request = new PersonListRequest(page, pageSize);
            PersonListResponse response = await _iysService.PersonList(request);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> PersonQuery([FromQuery]string personId)
        {
            PersonQueryResponse response = await _iysService.PersonQuery(personId);
            return Ok(response);
        }
        
        [HttpGet]
        public async Task<IActionResult> ReceiverQuery([FromQuery]string receiver)
        {
            List<ReceiverQueryResponse> response = await _iysService.ReceiverQuery(receiver);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> PersonAdd()
        {
            WhiteListPersonAddResponse response = await _iysService.WhiteListPersonAdd();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> PersonUpdate()
        {
            PersonUpdateResponse response = await _iysService.PersonUpdate();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> PersonRemove()
        {
            PersonRemoveResponse response = await _iysService.PersonRemove();
            return Ok(response);
        }
    }
}
