using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Activities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Activity, ActivityDto>();
            CreateMap<UserActivity, AttendeeDto>()
                    .ForMember(d => d.Username, o => o.MapFrom(s => s.AppUser.UserName))
                    .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.AppUser.DisplayName));

        }
    }
}
