﻿using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Commons.Bases.Response;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Infrastructure.Persistences.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(PosContext context)
        {
            this.context = context;
        }

        public async Task<EntityResponse<Category>> ListCategories(FiltersRequest filters)
        {
            EntityResponse<Category> response = new();

            IQueryable<Category> categories = (from c in context.Categories
                                               where c.AuditDeleteUser == null && c.AuditDeleteDate == null
                                               select c).AsNoTracking().AsQueryable();

            if (filters.NumFilter is not null && !string.IsNullOrEmpty(filters.TextFilter))
            {
                switch (filters.NumFilter)
                {
                    case 1:
                        categories = categories.Where(c => c.Name!.Contains(filters.TextFilter));
                        break;
                    case 2:
                        categories = categories.Where(c => c.Description!.Contains(filters.TextFilter));
                        break;
                }
            }

            if (filters.StateFilter is not null)
                categories = categories.Where(x => x.State.Equals(filters.StateFilter));

            if (!string.IsNullOrEmpty(filters.StartDate) && !string.IsNullOrEmpty(filters.EndDate))
                categories = categories.Where(x => x.AuditCreateDate >= Convert.ToDateTime(filters.StartDate) && x.AuditCreateDate <= Convert.ToDateTime(filters.EndDate));

            filters.Sort ??= "CategoryId";

            response.TotalRecords = await categories.CountAsync();
            response.Items = await Ordering<Category, Category>(filters, categories, (Category) => null, !filters.Download).ToListAsync();

            return response;
        }

        public Task<EntityResponse<Category>> ListCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> CategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        private readonly PosContext context;
    }
}