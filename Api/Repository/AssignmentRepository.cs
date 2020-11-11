using Api.Context;
using Api.Model;
using Api.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Api.Repository
{
    public class AssignmentRepository : Repository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(AppDbContext context) : base(context)
        {

        }

        public IEnumerable<Assignment> GetAssignment()
        {
            return Get().Include(assignment => assignment.Category).ToList();
        }
    }
}
