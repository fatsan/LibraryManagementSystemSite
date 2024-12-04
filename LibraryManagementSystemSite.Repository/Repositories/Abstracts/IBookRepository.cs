

using Core.Repository;
using LibraryManagementSystemSite.Model.Entities;

namespace LibraryManagementSystemSite.Repository.Repositories.Abstracts;

public interface IBookRepository : IRepository<Book,Guid>
{
}
