using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanzim.Entities.Concrete;

namespace Tanzim.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);

        //OUTER METHODS
        List<Category> ShowUserCategories();

        //INNER METHODS
        void SubmitCategoryByUserId(int userId, Category category);

        List<Category> GetAllCategoriesByUserId(int userId);
    }
}
