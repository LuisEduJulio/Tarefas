using Api.Context;
using Api.Repository;
using Api.Repository.Interface;
using Api.Services.Interface;

namespace Api.Services
{
    public class Service : IService
    {
        private AssignmentRepository _AssignmentRepository;
        private CategoryRepository _CategoryRepository;

        public AppDbContext _context;
        public Service(AppDbContext context)
        {
            _context = context;
        }

        public IAssignmentRepository AssignmentRepository => _AssignmentRepository ??= new AssignmentRepository(_context);

        public ICategoryRepository CategoryRepository => _CategoryRepository ??= new CategoryRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
