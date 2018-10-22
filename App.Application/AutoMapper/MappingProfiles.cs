using App.Application.ViewModels.Products;
using App.Application.ViewModels.Roles;
using App.Application.ViewModels.Users;
using App.Data.Entities.Products;
using App.Data.Entities.Roles;
using App.Data.Entities.Users;
using AutoMapper;

namespace App.Application.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<Role, RoleViewModel>();
            CreateMap<UserRole, UserRolesViewModel>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
        }
    }
}