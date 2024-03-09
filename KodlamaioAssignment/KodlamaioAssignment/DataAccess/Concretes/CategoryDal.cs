using kodlamaio.DataAccess.Abstract;
using kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlamaio.DataAccess.Concretes;

public class CategoryDal:ICategoryDal
{
    List<Category> categories;
    public CategoryDal()
    {
        Category category1 = new Category();
        category1.Id = 1;
        category1.Name = "Yazılım";

        Category category2 = new Category();
        category2.Id = 2;
        category2.Name = "Kişisel Gelişim";
        
        categories = new List<Category> { category1, category2 };
    }

    public List<Category> GetAll()
    {
        return categories;

    }

    public void Add(Category category)
    {
        categories.Add(category);
        Console.WriteLine(" Kategori eklendi..");
    }

    public void Remove(Category category)
    {
        categories.Remove(category);

        Console.WriteLine("Kategori silindi..");

    }

    public void Update(Category category)
    {

        Console.WriteLine("Kategori güncellendi...");


    }
}
