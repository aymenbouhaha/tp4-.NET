using tp4.Models;

namespace tp4.Data
{
    public class StudentRepository
    {
        UniversityContext universityContext;

        public StudentRepository(UniversityContext context)
        {
            this.universityContext = context;
        } 

        public List<Student> getStudents()
        {
            return universityContext.Student.ToList();
        }

        public Student getById(int id)
        {
            try
            {
                return universityContext.Student.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public List<Student> getStudentsBasedOnCourse(string courseName)
        {
            try
            {
                return universityContext.Student.Where((student) => student.course.ToLower() == courseName.ToLower()).ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        

        public List<string> getCourses()
        { 
            return universityContext.Student.Select((student) => student.course).Distinct().ToList();
        }
    }
}
