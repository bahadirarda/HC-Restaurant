using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using HC_APPLICATION.Models.DTO;
using HC_DOMAIN.Entities.Concrete;
using HC_APPLICATION.Models.VM;

namespace HC_APPLICATION.AutoMapper
{
    public class Mapper: Profile
    {
        public Mapper()
        {
            CreateMap<AppUser, LoginDTO>().ReverseMap();
            CreateMap<AppUser, RegisterDTO>().ReverseMap();
            CreateMap<AppUser, AppUserVM>().ReverseMap();
            CreateMap<UpdateUserDTO, AppUserVM>().ReverseMap();

            CreateMap<IdentityRole, CreateRoleDTO>().ReverseMap();
            CreateMap<AppUserRole, CreateRoleDTO>().ReverseMap();
            CreateMap<IdentityRole, UpdateRoleDTO>().ReverseMap();
            CreateMap<AppUserRole, UpdateRoleDTO>().ReverseMap();
            CreateMap<UpdateRoleDTO, IdentityRole>().ReverseMap();

            CreateMap<Employee, CreateEmployeeDTO>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeDTO>().ReverseMap();
            CreateMap<UpdateEmployeeDTO, EmployeeVM>().ReverseMap();

            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryVM>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
            CreateMap<UpdateCategoryDTO, CategoryVM>().ReverseMap();

            CreateMap<SubCategory, CreateSubCategoryDTO>().ReverseMap();
            CreateMap<SubCategory, SubCategoryVM>().ReverseMap();
            CreateMap<SubCategory, UpdateSubCategoryDTO>().ReverseMap();
            CreateMap<UpdateSubCategoryDTO, SubCategoryVM>().ReverseMap();

            CreateMap<Department, CreateDepartmentDTO>().ReverseMap();
            CreateMap<Department, DepartmentVM>().ReverseMap();
            CreateMap<Department, UpdateDepartmentDTO>().ReverseMap();
            CreateMap<UpdateDepartmentDTO, DepartmentVM>().ReverseMap();

            CreateMap<OrderVM, Order>().ReverseMap();

        }
    }
}
