using Cours.DataLayer;
using Cours.Entity;
using Microsoft.EntityFrameworkCore;

namespace Course.Services
{
    public class LearningServices : ILearning
    {
        private readonly AppDbContext dbContext;

        public LearningServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<Learning> CreateCourse(Learning newlearning)
        {
            dbContext.Course.Add(newlearning);
            dbContext.SaveChanges();
            return Task.FromResult(newlearning);
        }

        public void DeleteCourse(Guid id)
        {
            var request = dbContext.Course.FirstOrDefault(c => c.Id == id);
            dbContext.Course.Remove(request);
        }

        public Task<Learning> Get(Guid id)
        {
            var request = dbContext.Course.FirstOrDefault(c => c.Id == id);
            return Task.FromResult(request);
        }

        public Task<List<Learning>> Gets() => dbContext.Course.ToListAsync();
        

        public Task<Learning> UpdateCourse(Learning learning)
        {
            dbContext.Course.Update(learning);
            dbContext.SaveChanges();
            return Task.FromResult(learning);
        }
    }
}
