using kodlamaio.DataAccess.Abstract;
using kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlamaio.Business;


public class CategoryManager
{
    //DI
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    public List<Category> GetAll()
    {


        return _categoryDal.GetAll();

    }
}
