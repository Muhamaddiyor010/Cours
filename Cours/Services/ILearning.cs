using Cours.Entity;

namespace Course.Services
{
    public interface ILearning
    {
        Task<List<Learning>> Gets();
        Task<Learning> Get(Guid id);
        Task<Learning> CreateCourse(Learning newlearning);
        Task<Learning> UpdateCourse(Learning learning);
        void DeleteCourse(Guid id);
    }
}
