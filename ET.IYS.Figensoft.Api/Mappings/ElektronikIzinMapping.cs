using AutoMapper;
using ET.IYS.Figensoft.Api.Models.ElektronikIzın.PersonAdd;
using ET.IYS.Figensoft.Requests.Common;
using ET.IYS.Figensoft.Requests.ElektronikIzin.ExtraIzinIzinData;
using ET.IYS.Figensoft.Requests.ElektronikIzin.Person;

namespace ET.IYS.Figensoft.Api.Mappings
{
    public class ElektronikIzinMapping : Profile
    {
        public ElektronikIzinMapping()
        {
            CreateMap<PersonKVKPermissionRequestModel, KVKPermissionRequest>();
            CreateMap<PersonContactRequestModel, PersonContactRequest>();
            CreateMap<PersonETKPermissionRequestModel, PersonETKPermissionRequest>();
            CreateMap<ExtraIzinIzinDataRequestModel, ExtraIzinIzinDataRequest>();
            CreateMap<ExtraIzinIzinDataValueRequestModel, ExtraIzinIzinDataValueRequest>();
        }
    }
}
