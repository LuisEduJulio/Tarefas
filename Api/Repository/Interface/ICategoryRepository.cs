using Api.Model;
using System;
using System.Collections.Generic;

namespace Api.Repository.Interface
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetCategory();
    }
}
