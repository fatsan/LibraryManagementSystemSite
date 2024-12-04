

using Core.Entities;
using System.Reflection.Metadata;

namespace LibraryManagementSystemSite.Model.Entities;

public class Book : Entity<Guid>
{
    public string Title             { get; set; }
    public string Description       { get; set; }
    public int PageSize             { get; set; }
    public string PublishDate       { get; set; }
    public string ISBN              { get; set; }
}

