using kodlamaio.DataAccess.Abstract;
using kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlamaio.Business;

public class InstructorManager
{
    //DI

    private readonly IInstructorDal _ınstructorDal;

    public InstructorManager(IInstructorDal ınstructorDal)
    {
        _ınstructorDal = ınstructorDal;
    }
    public List<Instructor> GetAll()
    {


        return _ınstructorDal.GetAll();

    }
}
