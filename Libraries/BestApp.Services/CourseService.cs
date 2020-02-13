using BestApp.Core.Models;
using Repository.Repositories;
using Service;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BestApp.Services.CourseService;

namespace BestApp.Services
{

    public class CourseService : Service<Course>, ICourseService 
    {
        public interface ICourseService : IService<Course>
        {
            IQueryable<Course> GetAllCourses();
            Task<IQueryable<Course>> GetAllCoursesAsync();
        }
        private readonly IRepositoryAsync<Course> _repository;
        public CourseService(IRepositoryAsync<Course> repository):base(repository)
        {
            _repository = repository;
        }
        public IQueryable<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Course>> GetAllCoursesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
