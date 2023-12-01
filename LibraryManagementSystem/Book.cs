
namespace LibraryManagementSystem
{
    internal class Book : Literature
    {
        public Book(int id, string name, DateTime releaseDate, string writer) : base(id, name, releaseDate, writer)
        {
        }

        public void Print()
        {
            Console.WriteLine($"Book ID: {Id}, Book Name: {Name}, Release Date: {ReleaseDate.Year}, Writer: {Writer}\n");
        }
    }
}
