

namespace LibraryManagementSystemSite.Model.Entities;

public class User // JWT ye bağlayacağım
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<Book> BooksCreated { get; set; }
    public List<Category> CategoriesCreated { get; set; }
    
}
