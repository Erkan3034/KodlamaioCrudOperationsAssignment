using kodlamaio.DataAccess.Abstract;
using kodlamaio.DataAccess.Concretes;
using kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlamaio.Business;

public class CourseManager
    //DI
{
    private  ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal=courseDal;
    }
    public List<Course> GetAll()
    {
        // Veri kaynağından kurs bilgileri çekilir.

        return _courseDal.GetAll();

    }

}
