using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanzim.Business.Abstract;
using Tanzim.Business.Properties;
using Tanzim.DataAccess.Abstract;
using Tanzim.Entities.Concrete;

namespace Tanzim.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        
        private ICategoryDal _categoryDal;
        private int _loggedInUserId;

        public CategoryManager( ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
            _loggedInUserId = Settings.Default.LoggedInUserId;
        }


        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        //OUTER METHODS
        public List<Category> ShowUserCategories()
        {
          return  GetAllCategoriesByUserId(_loggedInUserId);
        }



        public void SubmitCategoryByUserId(int userId, Category category)
        {
            _categoryDal.Add(new Tanzim.Entities.Concrete.Category
            {
                UserId = userId,
                Name = category.Name
            });
        }


        //INNER METHODS
        public List<Category> GetAllCategoriesByUserId(int userId)
        {
            return _categoryDal.GetList(c => c.UserId == userId).Select(c=>new Category
            {
                Id=c.Id,
                UserId = userId,
                Name = c.Name

            }).ToList();
        }

      

    }
}
