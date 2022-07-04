namespace ShushannaHakobyan9.ViewModels
{
    public class BookViewModel
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int productionYear { get; set; }
        public int TotalCount { get; set; }
        public int AvailibleForBorrowingCount { get; set; }
        public int AvailibleForUsingInLibraryCount { get; set; }
        public string Genre { get; set; }
    }
}