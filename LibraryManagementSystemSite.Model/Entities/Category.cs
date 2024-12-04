

using Core.Entities;

namespace LibraryManagementSystemSite.Model.Entities;

public class Category : Entity<Guid>
{
    public string Name { get; set; }
}
