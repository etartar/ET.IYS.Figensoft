using AutoMapper;
using ET.IYS.Figensoft.Abstract;
using ET.IYS.Figensoft.Api.Models.WhiteList.PersonAdd;
using ET.IYS.Figensoft.Api.Models.WhiteList.PersonRemove;
using ET.IYS.Figensoft.Api.Models.WhiteList.PersonUpdate;
using ET.IYS.Figensoft.Requests.Common;
using ET.IYS.Figensoft.Requests.ElektronikIzin.ExtraIzinIzinData;
using ET.IYS.Figensoft.Requests.WhiteList.PersonAdd;
using ET.IYS.Figensoft.Requests.WhiteList.PersonList;
using ET.IYS.Figensoft.Requests.WhiteList.PersonRemove;
using ET.IYS.Figensoft.Requests.WhiteList.PersonUpdate;
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
        private readonly IMapper _mapper;

        public WhiteListController(IIYSServiceAdapter iysService, IMapper mapper)
        {
            _iysService = iysService;
            _mapper = mapper;
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
        public async Task<IActionResult> PersonAdd([FromBody] WhiteListPersonAddRequestModel request)
        {
            List<KVKPermissionRequest> kvkPermissions = _mapper.Map<List<KVKPermissionRequest>>(request.KVK);
            List<WhiteListPersonAddETKPermissionRequest> etkPermissions = _mapper.Map<List<WhiteListPersonAddETKPermissionRequest>>(request.ETK);
            ExtraIzinIzinDataRequest extraIzinIzinData = _mapper.Map<ExtraIzinIzinDataRequest>(request.ExtraIzinIzinData);

            WhiteListPersonAddRequest createWhiteListPersonAddRequest = new WhiteListPersonAddRequest()
                .SetReason(request.Reason)
                .SetMustAddMasterAccount(request.MustAddMasterAccount)
                .SetEvidenceData("buraya figensofttan evidence data formatı öğrenilip custom olarak kendi projenize uyarlayacaksınız.")
                .SetEvidenceType(request.EvidenceType)
                .CreatePerson(request.PersonId, request.NameSurname)
                .SetKVKPermission(kvkPermissions)
                .SetETKPermission(etkPermissions)
                .SetExtraIzinIzinData(extraIzinIzinData);

            WhiteListPersonAddResponse response = await _iysService.WhiteListPersonAdd(createWhiteListPersonAddRequest);

            if (response.IsSuccess)
                return Ok(response);
            else
                return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> PersonUpdate([FromBody] PersonUpdateRequestModel request)
        {
            List<PersonUpdateETKPermissionRequest> etkPermissions = _mapper.Map<List<PersonUpdateETKPermissionRequest>>(request.ETK);
            
            PersonUpdateRequest createPersonUpdateRequest = new PersonUpdateRequest()
                .SetReason(request.Reason)
                .SetMustAddMasterAccount(request.MustAddMasterAccount)
                .SetEvidenceData("buraya figensofttan evidence data formatı öğrenilip custom olarak kendi projenize uyarlayacaksınız.")
                .SetEvidenceType(request.EvidenceType)
                .CreatePerson(request.PersonId, request.NameSurname)
                .SetETKPermission(etkPermissions);

            PersonUpdateResponse response = await _iysService.PersonUpdate(createPersonUpdateRequest);

            if (response.IsSuccess)
                return Ok(response);
            else
                return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> PersonRemove(PersonRemoveRequestModel request)
        {
            PersonRemoveETKRequest personRemoveETKRequest = _mapper.Map<PersonRemoveETKRequest>(request.ETK);

            PersonRemoveRequest createPersonRemoveRequest = new PersonRemoveRequest()
                .SetReason(request.Reason)
                .SetMustRemoveMasterAccount(request.MustRemoveMasterAccount)
                .SetMustRemoveOtherDealers(request.MustRemoveOtherDealers)
                .SetPersonId(request.PersonId)
                .SetRemoveKVKPermission(request.RemoveKVKPermission)
                .SetETK(personRemoveETKRequest);

            PersonRemoveResponse response = await _iysService.PersonRemove(createPersonRemoveRequest);

            if (response.IsSuccess)
                return Ok(response);
            else
                return BadRequest(response);
        }
    }
}
