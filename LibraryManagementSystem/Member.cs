namespace LibraryManagementSystem
{
    internal class Member : IPrintable
    {
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal int No {  get; set; }
        internal List<Book> BorrowedBooks { get; set; } = new();

        public Member() { }

        public Member(string _name, string _surname, int _no, List<Book> _borrowedbooks)
        {
            Name = _name;
            Surname = _surname;
            No = _no;
            BorrowedBooks = _borrowedbooks;
        }

        public void Print()
        {
            Console.WriteLine($"Member Name: {Name}, Member Surname: {Surname}, Member No: {No}");
            Console.WriteLine("Books borrowed by the member:");
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine($"  - NONE\n");
            }
            else
            {
                foreach (var borrowedBook in BorrowedBooks)
                {
                    Console.WriteLine($"  - {borrowedBook.Name}\n");
                }
            }
        }

    }
}
