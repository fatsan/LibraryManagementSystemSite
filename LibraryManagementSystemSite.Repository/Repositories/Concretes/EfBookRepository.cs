
using Core.Repository;
using LibraryManagementSystemSite.Model.Entities;
using LibraryManagementSystemSite.Repository.Contexts;
using LibraryManagementSystemSite.Repository.Repositories.Abstracts;

namespace LibraryManagementSystemSite.Repository.Repositories.Concretes;

public class EfBookRepository : EfRepositoryBase<BaseDbContext, Book, Guid>, IBookRepository
{
    public EfBookRepository(BaseDbContext context) : base(context)
    {
    }
}
