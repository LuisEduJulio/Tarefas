using Api.Repository.Interface;

namespace Api.Services.Interface
{
    public interface IService
    {
        IAssignmentRepository AssignmentRepository { get; }
        ICategoryRepository CategoryRepository { get; }

        void Commit();
    }
}
