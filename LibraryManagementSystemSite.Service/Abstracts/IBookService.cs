

using Core.Entities;
using LibraryManagementSystemSite.Model.Dtos.Books.Requests;
using LibraryManagementSystemSite.Model.Dtos.Books.Responses;

namespace LibraryManagementSystemSite.Service.Abstracts;

public interface IBookService
{
    ReturnModel<BookResponseDto> Add(CreateBookRequest dto);
    ReturnModel<List<BookResponseDto>> GetAll();
    ReturnModel<BookResponseDto> GetById(Guid id);
    ReturnModel<BookResponseDto> Update(UpdateBookRequest dto);
    ReturnModel<BookResponseDto> Delete(Guid id);
}
