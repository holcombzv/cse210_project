public class Bookcase {
    private List<Book> _books = new List<Book>();

    public void addBook(Book book) {
        _books.Add(book);
    }
    public int countBooks() {
        return _books.Count();
    }
}