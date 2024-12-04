

using Core.Repository;
using LibraryManagementSystemSite.Model.Entities;
using LibraryManagementSystemSite.Repository.Contexts;
using LibraryManagementSystemSite.Repository.Repositories.Abstracts;

namespace LibraryManagementSystemSite.Repository.Repositories.Concretes;

public class EfCategoryRepository : EfRepositoryBase<BaseDbContext, Category, Guid>, ICategoryRepository
{
    public EfCategoryRepository(BaseDbContext context) : base(context)
    {
    }
}
