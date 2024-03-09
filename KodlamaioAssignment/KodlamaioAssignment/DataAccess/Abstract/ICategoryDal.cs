using kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlamaio.DataAccess.Abstract;

public interface ICategoryDal
{
    List<Category> GetAll();

    void Add(Category category);

    void Remove(Category category);

    void Update(Category category);
}
