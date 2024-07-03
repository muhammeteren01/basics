namespace basics.Models;

public class Repository
{
    private static readonly List<Course> _courses = new();

    static Repository()
    {
        _courses = new List<Course>()
        {
             new Course() {
                 Id = 1,Title = "aspnet kursu",
                 Description = "Güzel bir kurs",
                 Image="1.jpg",
                 Tags = new string[]{"aspnet","web geliştirme"},
                 isActive=true,
                 isHome=true
             },
             new Course() {
                 Id = 2,Title = "php kursu",
                 Description = "Güzel bir kurs",
                 Image = "2.png",
                 Tags = new string[]{"php","web geliştirme"},
                 isActive=false,
                 isHome=true
             },
             new Course() {
                 Id = 3,Title = "django kursu",
                 Description = "Güzel bir kurs",
                 Image = "3.png",
                 isActive=true,
                 isHome=false
             }
        };
    }
    public static List<Course> Courses
    {
        get
        {
            return _courses;
        }

    }

    public static Course? GetById(int? id)
    {
        return _courses.FirstOrDefault(c => c.Id == id);
    }
}