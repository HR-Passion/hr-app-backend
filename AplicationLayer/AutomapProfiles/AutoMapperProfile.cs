using AplicationLayer.DTOs;
using AplicationLayer.Models;
using AutoMapper;
using DataAccesLayer.Entities.Base;
using DataAccesLayer.Entities.Base.Contracts;
using DataAccesLayer.Entities.Base.Departments;
using DataAccesLayer.Entities.Base.Employees;
using DataAccesLayer.Entities.Base.Groups;
using DataAccesLayer.Entities.Base.Groups.Auxiliar;
//using System.Text.RegularExpressions;

namespace AplicationLayer.AutomapProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Group mapări
            CreateMap<Group, GroupDto>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Group,CreateGroupModel>().ReverseMap();
            CreateMap<ContactEntity, ContactEntityDto>().ReverseMap();
            CreateMap<DetaliiGroupEntity, DetaliiGroupEntityDto>().ReverseMap();
            CreateMap<DomeniuActivitateEntity, DomeniuActivitateEntityDto>().ReverseMap();
            CreateMap<LocalitateEntity, LocalitateEntityDto>().ReverseMap();
            CreateMap<JudetEntity, JudetEntityDto>().ReverseMap();


            // Employee mapări
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<ContractEntity, ContractDto>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();

            // Contract mapări
            CreateMap<ContractStareEntity, ContractStareEntityDto>().ReverseMap();
            CreateMap<CorEntity, CorEntityDto>().ReverseMap();


        }
    }
}
