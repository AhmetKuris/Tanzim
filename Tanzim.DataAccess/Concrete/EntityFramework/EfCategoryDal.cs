using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess.EntityFramework;
using Tanzim.DataAccess.Abstract;
using Tanzim.Entities.Concrete;

namespace Tanzim.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,TanzimContext>, ICategoryDal
    {
    }
}
