namespace ShushannaHakobyan9.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int ProductionYear { get; set; }
        public string Description { get; set; }
        public int PagesCount { get; set; }
        public int TotalCount { get; set; }
        public int AvailibleForBorrowingCount { get; set; }
        public int AvailibleForUsingInLibraryCount { get; set; }
        public string Genre { get; set; }
    }
}