namespace Library.Entity.Concrete;

public class Library
{
    public List<Book> AllBooks { get; set; }
    public List<Member> Members { get; set; }

    public Library()
    {
        AllBooks = new List<Book>();
        Members = new List<Member>();
    }

    public void AddBook(Book book)
    {
        AllBooks.Add(book);
    }

    public void AddMember(Member member)
    {
        Members.Add(member);
    }

    public void UpdateBookStatus(Book book, Status status)
    {
        book. BookStatus= status;
    }
    
    

    public void ViewLibraryStatus()
    {
        Console.WriteLine("Kütüphane Durumu:");
        Console.WriteLine($"Mevcut Kitaplar: {AllBooks.Count}");
        Console.WriteLine($"Üye Sayısı: {Members.Count}");
        int borrowedBooksCount = 0;
        foreach (var book in AllBooks)
        {
            if (book.BookStatus == Status.OduncVerildi)
            {
                borrowedBooksCount++;
            }
        }
        Console.WriteLine($"Ödünç Alınan Kitaplar : {borrowedBooksCount}");
      
        
    }
    

    public void ViewBookStatus(Book book) {
        if(book.BookStatus==Status.OduncVerildi)
        {
            Console.WriteLine("Kitap başkası tarafından alınmıştır");
        }
        else if (book.BookStatus==Status.MevcutDegil)
        {
            Console.WriteLine("Kitap mevcut değildir.");
        }
        else 
        {
            Console.WriteLine(
                "Kitap ödünç alınabilir.");
        }

    }
}