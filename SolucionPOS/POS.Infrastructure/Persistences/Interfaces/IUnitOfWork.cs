namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public ICategoryRepository Category { get; }
        void SaveChange();
        Task SaveChangeAsync();
    }
}