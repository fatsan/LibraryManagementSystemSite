namespace LibraryManagementSystemSite.Model.Dtos.Books.Requests;

public sealed record UpdateBookRequest(
Guid Id,
string Title,
string Description,
int PageSize,
string PublishDate,
string ISBN);


