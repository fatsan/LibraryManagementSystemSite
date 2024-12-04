

using Core.Entities;

namespace LibraryManagementSystemSite.Model.Entities;

public class Author : Entity<Guid>
{
    public string FullName { get; set; }

}
