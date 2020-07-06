using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanzim.Entities.Concrete;
    
namespace Tanzim.Business.Abstract
{
    public interface IUserService
    {

        void Add(User user);
        void Delete(User user);
        void Update(User user);

        List<User> GetAllUsers();
        string GetLoggedInUserEmail();

        string Login(User user);
        string SignUp(User user);

        void ClearSettingsDefault();



    }
}
