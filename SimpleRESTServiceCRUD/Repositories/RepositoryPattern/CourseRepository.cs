using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleRESTServiceCRUD.Repositories.RepositoryPattern
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        //public PlutoContext PlutoContext
        //{
        //    get { return Context as PlutoContext; }
        //}

        public CourseRepository(/*PlutoContext context*/) 
            //: base(context)
        {

        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetTopCourses(int count)
        {
            throw new NotImplementedException();
        }
    }
}