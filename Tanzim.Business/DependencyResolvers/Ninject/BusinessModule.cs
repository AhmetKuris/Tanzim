using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Tanzim.Business.Abstract;
using Tanzim.Business.Concrete;
using Tanzim.DataAccess.Abstract;
using Tanzim.DataAccess.Concrete.EntityFramework;

namespace Tanzim.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<ITrackService>().To<TrackManager>().InSingletonScope();
            Bind<ITrackDal>().To<EfTrackDal>().InSingletonScope();
        }
    }
}
