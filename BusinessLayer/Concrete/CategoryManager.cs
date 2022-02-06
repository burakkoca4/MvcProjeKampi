using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> genericRepository = new GenericRepository<Category>();

        public List<Category> GetAllList()
        {
            return genericRepository.List();
        }

        public void CategoryAdd(Category category)
        {
            genericRepository.Insert(category);
            //if (category.Name=="" || category.Name.Length<=3 || category.Description=="" || category.Name.Length>=51)
            //{
            //    //hata mesajı
            //}
            //else
            //{

            //}
        }
    }
}
