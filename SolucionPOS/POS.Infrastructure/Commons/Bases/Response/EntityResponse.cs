namespace POS.Infrastructure.Commons.Bases.Response
{
    public class EntityResponse<T>
    {
        public int TotalRecords { get; set; }
        public List<T> Items { get; set; }
    }
}