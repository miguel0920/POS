using POS.Domain.Entities;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Infrastructure.Persistences.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(PosContext context)
        {
            this.context = context;
            Category = new CategoryRepository(context);
        }

        public ICategoryRepository Category { get; private set; }

        public void Dispose() => context.Dispose();

        public void SaveChange() => context.SaveChanges();

        public async Task SaveChangeAsync() => await context.SaveChangesAsync();

        private readonly PosContext context;
    }
}