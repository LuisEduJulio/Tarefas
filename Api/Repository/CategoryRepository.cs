using Api.Context;
using Api.Model;
using Api.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }
        public IEnumerable<Category> GetCategory()
        {
            return Get().Include(category => category.Assignment);
        }

    }
}
