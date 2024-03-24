using Library.Entity.Abstract;

namespace Library.Entity.Concrete;

public class Book : BaseEntity
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublicationYear { get; set; }
    public Status? BookStatus { get; set; }

}