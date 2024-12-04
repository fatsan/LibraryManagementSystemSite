namespace LibraryManagementSystemSite.Model.Dtos.Books.Responses;

public sealed record BookResponseDto(
string Title,
string Description,
int PageSize,
string PublishDate,
string ISBN);


