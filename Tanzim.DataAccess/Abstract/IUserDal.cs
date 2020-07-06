using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess;
using Tanzim.Entities.Concrete;

namespace Tanzim.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
    }
}
