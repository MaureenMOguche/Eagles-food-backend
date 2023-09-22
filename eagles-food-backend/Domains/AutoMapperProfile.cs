﻿using eagles_food_backend.Domains.DTOs;
using eagles_food_backend.Domains.Models;

namespace eagles_food_backend.Domains
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateUserDTO, User>();
            CreateMap<User, CreateUserDTO>();
            CreateMap<CreateLunchDTO, Lunch>();
            CreateMap<Lunch, ResponseLunchDTO>();
            CreateMap<CreateStaffDTO, User>();
            CreateMap<User, CreateStaffDTO>();

        }
    }
}
