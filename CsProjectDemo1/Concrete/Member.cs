using Library.Entity.Abstract;

namespace Library.Entity.Concrete;

public class Member : BaseEntity, IMember
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string MemberNo { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();


    public Member(string name, string surname, string memberNo)
    {
        Name = name;
        Surname = surname;
        MemberNo = memberNo;
        Books = new List<Book>();
    }

    public void BorrowBook(Book book)
    {
        if (book.BookStatus == Status.OduncAlinabilir)
        {
            book.BookStatus = Status.OduncVerildi;
            Books.Add(book);
            Console.WriteLine($"{book.Title} adlı kitap ödünç alındı.");
        }
        else
        {
            Console.WriteLine($"{book.Title} adlı kitap mevcut değil.");
        }
    }

    public void ReturnBook(Book book)
    {
        if (Books.Contains(book))
        {
            Books.Remove(book);
            book.BookStatus = Status.OduncAlinabilir;
            Console.WriteLine($"{book.Title} adlı kitap iade edildi.");
        }
        else
        {
            Console.WriteLine($"{book.Title} adlı kitap ödünç alınmamış.");
        }
    }

    public void DisplayBorrowedBooks()
    {
        Console.WriteLine($"Üye: {Name} {Surname}, Numara: {MemberNo}");
        Console.WriteLine("Ödünç Alınan Kitaplar:");
        foreach (var book in Books)
        {
            Console.WriteLine($"{book.Title} - {book.Author}");
        }
    }


}