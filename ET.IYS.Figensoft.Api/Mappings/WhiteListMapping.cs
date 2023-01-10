using AutoMapper;
using ET.IYS.Figensoft.Api.Models.WhiteList.PersonAdd;
using ET.IYS.Figensoft.Api.Models.WhiteList.PersonRemove;
using ET.IYS.Figensoft.Api.Models.WhiteList.PersonUpdate;
using ET.IYS.Figensoft.Requests.Common;
using ET.IYS.Figensoft.Requests.WhiteList.PersonAdd;
using ET.IYS.Figensoft.Requests.WhiteList.PersonRemove;
using ET.IYS.Figensoft.Requests.WhiteList.PersonUpdate;

namespace ET.IYS.Figensoft.Api.Mappings
{
    public class WhiteListMapping : Profile
    {
        public WhiteListMapping()
        {
            CreateMap<WhiteListPersonKVKPermissionRequestModel, KVKPermissionRequest>();
            CreateMap<WhiteListPersonContactRequestModel, ContactRequest>();
            CreateMap<WhiteListPersonETKPermissionRequestModel, WhiteListPersonAddETKPermissionRequest>();

            CreateMap<PersonRemoveContactRequestModel, ContactRequestBase>();
            CreateMap<PersonRemoveETKRequestModel, PersonRemoveETKRequest>();

            CreateMap<PersonUpdateContactRequestModel, ContactRequest>();
            CreateMap<PersonUpdateETKPermissionRequestModel, PersonUpdateETKPermissionRequest>();
        }
    }
}
