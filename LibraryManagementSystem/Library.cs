namespace LibraryManagementSystem
{
    internal class Library : IPrintable
    {
        private List<Book> Books = new();
        private List<Member> Members = new();

        public Library() { }
        public Library(List<Book> _books, List<Member> _members)
        {
            Books = _books;
            Members = _members;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
        public void AddMember(Member member)
        {
            Members.Add(member);
        }
        public void RemoveMember(Member member)
        {
            Members.Remove(member);
        }

        public void BorrowBook(Book book, Member member)
        {
            member.BorrowedBooks.Add(book);
            Console.WriteLine($"{book.Name} was borrowed by {member.Name}\n");
            Books.Remove(book);
        }

        public void ReturnBook(Book book, Member member)
        {

            member.BorrowedBooks.Remove(book);
            Console.WriteLine($"{book.Name} was returned by {member.Name}\n");
            Books.Add(book);
        }

        public void Print()
        {
            Console.WriteLine("Current Library Status:");
            Console.WriteLine("-----------------------\n");

            if (Books.Count == 0) Console.WriteLine("There are no books in the library now.\n");
            else
            {
                foreach (var book in Books)
                {
                    book.Print();
                }
            }


            foreach (var member in Members)
            {
                member.Print();
            }
        }
    }
}
