using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRESTServiceCRUD.Repositories.RepositoryPattern
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopCourses(int count);
        IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
