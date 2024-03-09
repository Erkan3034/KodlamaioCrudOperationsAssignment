using kodlamaio.Business;
using kodlamaio.DataAccess.Concretes;
using kodlamaio.Entities;

//Kurs.
CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> courses = courseManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{

    Console.WriteLine($"{i + 1}. kurs = {courses[i].Name} ");
}

Console.WriteLine();
//Eğitmen

InstructorManager ınstructorManager = new InstructorManager(new InstructorDal());
List<Instructor> ınstructors = ınstructorManager.GetAll();
for (int i = 0; i < ınstructors.Count; i++)
{

    Console.WriteLine($"Eğitmen {i + 1} = {ınstructors[i].Name}");
}

Console.ReadLine();
