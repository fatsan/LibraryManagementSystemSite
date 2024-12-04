
using Core.Repository;
using LibraryManagementSystemSite.Model.Entities;
using LibraryManagementSystemSite.Repository.Contexts;
using LibraryManagementSystemSite.Repository.Repositories.Abstracts;

namespace LibraryManagementSystemSite.Repository.Repositories.Concretes;

public class EfAuthorRepository : EfRepositoryBase<BaseDbContext, Author, Guid>, IAuthorRepository
{
    public EfAuthorRepository(BaseDbContext context) : base(context)
    {
    }
}