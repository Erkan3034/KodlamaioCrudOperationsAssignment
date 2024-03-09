using kodlamaio.DataAccess.Abstract;
using kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlamaio.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "JAVA";
        course1.Description = "Java v.15";
        course1.Price = 00.00;

        Course course2 = new Course();
        course2.Id = 1;
        course2.Name = "C#";
        course2.Description = ".Net vs.7 ";
        course2.Price = 00.00;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "PYTHON";
        course3.Description = "Python v.3 ";
        course3.Price = 0;

        courses = new List<Course> { course1, course2, course3 };


    }
    public List<Course> GetAll()
    {
        return courses;

    }

    public void Add(Course course)
    {
        courses.Add(course);
        Console.WriteLine("Kurs eklendi..");
    }

    public void Remove(Course course)
    {
        courses.Remove(course);

        Console.WriteLine("Kurs silindi..");

    }

    public void Update(Course course)
    {

        Console.WriteLine("Kurs güncellendi...");


    }
}
