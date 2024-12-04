

using Core.Entities;
using LibraryManagementSystemSite.Model.Dtos.Authors.Requests;
using LibraryManagementSystemSite.Model.Dtos.Authors.Responses;

namespace LibraryManagementSystemSite.Service.Abstracts;

public interface IAuthorService
{
    ReturnModel<AuthorResponseDto> Add(CreateAuthorRequest dto);
    ReturnModel<List<AuthorResponseDto>> GetAll();
    ReturnModel<AuthorResponseDto> GetById(Guid id);
    ReturnModel<AuthorResponseDto> Update(UpdateAuthorRequest dto);
    ReturnModel<AuthorResponseDto> Delete(Guid id);
}
