namespace LibraryManagementSystem
{
    internal class Literature
    {
        internal int Id {  get; set; }
        internal string Name { get; set; }
        internal DateTime ReleaseDate { get; set; }
        internal string Writer {  get; set; }

        public Literature(int _id, string _name, DateTime _releaseDate, string _writer)
        {
            Id = _id;
            Name = _name;
            ReleaseDate = _releaseDate;
            Writer = _writer;
        }
    }
}
