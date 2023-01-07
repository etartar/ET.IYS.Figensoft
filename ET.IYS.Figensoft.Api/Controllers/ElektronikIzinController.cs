using AutoMapper;
using ET.IYS.Figensoft.Abstract;
using ET.IYS.Figensoft.Api.Models.ElektronikIzın.PersonAdd;
using ET.IYS.Figensoft.Requests.Common;
using ET.IYS.Figensoft.Requests.ElektronikIzin.DoubleOptinCodeVerify;
using ET.IYS.Figensoft.Requests.ElektronikIzin.ExtraIzinIzinData;
using ET.IYS.Figensoft.Requests.ElektronikIzin.Person;
using ET.IYS.Figensoft.Requests.ElektronikIzin.PersonAdd;
using ET.IYS.Figensoft.Requests.ElektronikIzin.PersonAddWithDoubleOptin;
using ET.IYS.Figensoft.Requests.ElektronikIzin.StartDoubleOptinGSM;
using ET.IYS.Figensoft.Responses.ElektronikIzin.DoubleOptinCodeVerify;
using ET.IYS.Figensoft.Responses.ElektronikIzin.PersonAdd;
using ET.IYS.Figensoft.Responses.ElektronikIzin.PersonAddWithDoubleOptin;
using ET.IYS.Figensoft.Responses.ElektronikIzin.StartDoubleOptinGSM;
using Microsoft.AspNetCore.Mvc;

namespace ET.IYS.Figensoft.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ElektronikIzinController : ControllerBase
    {
        private readonly IIYSServiceAdapter _iysService;
        private readonly IMapper _mapper;

        public ElektronikIzinController(IIYSServiceAdapter iysService, IMapper mapper)
        {
            _iysService = iysService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> StartDoubleOptin([FromQuery] string gsmNo, bool sms, bool audio, bool email)
        {
            StartDoubleOptinGSMRequest request = new StartDoubleOptinGSMRequest(gsmNo, sms, audio, email);
            StartDoubleOptinGSMResponse response = await _iysService.StartDoubleOptinGSM(request);
            
            if (response.IsSuccess)
                return Ok(response);
            else
                return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> DoubleOptinCodeVerify([FromQuery] string gsmNo, string doubleOptinCode)
        {
            DoubleOptinCodeVerifyRequest request = new DoubleOptinCodeVerifyRequest(gsmNo, doubleOptinCode);
            DoubleOptinCodeVerifyResponse response = await _iysService.DoubleOptinCodeVerify(request);

            if (response.IsSuccess)
                return Ok(response);
            else
                return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> PersonAdd([FromBody] PersonAddRequestModel request)
        {
            List<KVKPermissionRequest> kvkPermissions = _mapper.Map<List<KVKPermissionRequest>>(request.KVK);
            List<PersonETKPermissionRequest> etkPermissions = _mapper.Map<List<PersonETKPermissionRequest>>(request.ETK);
            ExtraIzinIzinDataRequest extraIzinIzinData = _mapper.Map<ExtraIzinIzinDataRequest>(request.ExtraIzinIzinData);

            PersonAddRequest createPersonAddRequest = new PersonAddRequest()
                .SetReason(request.Reason)
                .SetEvidenceData("buraya figensofttan evidence data formatı öğrenilip custom olarak kendi projenize uyarlayacaksınız.")
                .SetMustAddMasterAccount(request.MustAddMasterAccount)
                .CreatePerson(request.PersonId, request.NameSurname, request.GsmNumber)
                .SetKVKPermission(kvkPermissions)
                .SetETKPermission(etkPermissions)
                .SetExtraIzinIzinData(extraIzinIzinData);

            PersonAddResponse response = await _iysService.PersonAdd(createPersonAddRequest);

            if (response.IsSuccess)
                return Ok(response);
            else
                return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> PersonAddWithDoubleOptin([FromBody] PersonAddWithDoubleOptinRequestModel request)
        {
            List<KVKPermissionRequest> kvkPermissions = _mapper.Map<List<KVKPermissionRequest>>(request.KVK);
            List<PersonETKPermissionRequest> etkPermissions = _mapper.Map<List<PersonETKPermissionRequest>>(request.ETK);
            ExtraIzinIzinDataRequest extraIzinIzinData = _mapper.Map<ExtraIzinIzinDataRequest>(request.ExtraIzinIzinData);

            PersonAddWithDoubleOptinRequest createPersonAddRequest = new PersonAddWithDoubleOptinRequest()
                .SetReason(request.Reason)
                .SetEvidenceData("buraya figensofttan evidence data formatı öğrenilip custom olarak kendi projenize uyarlayacaksınız.")
                .SetMustAddMasterAccount(request.MustAddMasterAccount)
                .SetVerificationGsmNo(request.VerificationGsmNo)
                .SetVerificationCode(request.VerificationCode)
                .CreatePerson(request.PersonId, request.NameSurname, request.GsmNumber)
                .SetKVKPermission(kvkPermissions)
                .SetETKPermission(etkPermissions)
                .SetExtraIzinIzinData(extraIzinIzinData);

            PersonAddWithDoubleOptinResponse response = await _iysService.PersonAddWithDoubleOptin(createPersonAddRequest);

            if (response.IsSuccess)
                return Ok(response);
            else
                return BadRequest(response);
        }
    }
}
