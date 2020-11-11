using Api.Model;
using System.Collections.Generic;

namespace Api.Repository.Interface
{
    public interface IAssignmentRepository : IRepository<Assignment>
    {
        IEnumerable<Assignment> GetAssignment();
    }
}
