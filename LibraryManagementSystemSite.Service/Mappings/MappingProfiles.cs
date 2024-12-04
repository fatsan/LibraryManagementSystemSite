

using AutoMapper;
using LibraryManagementSystemSite.Model.Dtos.Authors.Requests;
using LibraryManagementSystemSite.Model.Dtos.Authors.Responses;
using LibraryManagementSystemSite.Model.Dtos.Books.Requests;
using LibraryManagementSystemSite.Model.Dtos.Books.Responses;
using LibraryManagementSystemSite.Model.Dtos.Categories.Requests;
using LibraryManagementSystemSite.Model.Dtos.Categories.Responses;
using LibraryManagementSystemSite.Model.Entities;

namespace LibraryManagementSystemSite.Service.Mappings;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateBookRequest, Book>();  //reverse de yazabilirisn
        CreateMap<Book, BookResponseDto>();
        CreateMap<CreateAuthorRequest, Author>();
        CreateMap<Author, AuthorResponseDto>();
        CreateMap<CreateCategoryRequest, Category>();
        CreateMap<Category, CategoryResponseDto>();
    }
}
