using kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlamaio.DataAccess.Abstract;

public interface ICourseDal 
{
    List<Course> GetAll();

    void Add(Course course);

    void Remove(Course course);

    void Update(Course course);


}
