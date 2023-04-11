namespace Library
{
  class Book
  {
    public string title = "";
    public string author = "";
    public int pages;

// learning about constructors
    public Book(string aTitle, string aAuthor, int aPages)
    {
      author = aAuthor;
      title = aTitle;
      pages = aPages;
    }
  }
}
