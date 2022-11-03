namespace POS.Infrastructure.Commons.Bases.Request
{
    public class PaginationRequest
    {
        public int NumPage { get; set; } = 1;
        public int NumRecordsPage { get; set; } = 10;
        public bool OrderAsc { get; set; } = false;
        public string Sort { get; set; } = null;

        public int Records
        {
            get => NumRecordsPage;
            set
            {
                NumRecordsPage = value > NumMaxRecordsPage ? NumMaxRecordsPage : value;
            }
        }

        public readonly int NumMaxRecordsPage = 50;
    }
}