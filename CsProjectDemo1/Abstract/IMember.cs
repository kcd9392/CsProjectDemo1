using Library.Entity.Concrete;

namespace Library.Entity.Abstract;

public interface IMember
{
    void BorrowBook(Book book);
    void ReturnBook(Book kitap);
    void DisplayBorrowedBooks();
    
}