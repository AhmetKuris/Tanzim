using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanzim.Business.Properties;
using Tanzim.DataAccess.Abstract;
using Tanzim.Entities.Concrete;



namespace Tanzim.Business.Concrete
{
    using Abstract;


    public class UserManager:IUserService
    {
        private IUserDal _userDal;
        private ICategoryDal _categoryDal;

        private string _loggedInUserEmail;
        private int _loggedInUserId;


        //CRUD Create-Delete-Update
        public UserManager(IUserDal userDal, ICategoryDal categoryDal)
        {
            _userDal = userDal;
            _categoryDal = categoryDal;

        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }


        //GETS
        public List<User> GetAllUsers()
        {
            return _userDal.GetList().Select(p => new User
            {
                Id = p.Id,
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Email,
                Password = p.Password

            }).ToList();
        }

        public string GetLoggedInUserEmail()
        {
            return Settings.Default.LoggedInUserEmail;
        }


        //Authorization
        public string Login(User user)
        {
            User dbQueryUser = _userDal.Get(u => u.Email == user.Email);

            if (dbQueryUser != null)
            {
                if (dbQueryUser.Password == user.Password)
                {
                    //IN the future make this part a unique timed id which expires over time
                    //Just like in the cookie authentication implementation
                    Settings.Default["LoggedInUserEmail"] = dbQueryUser.Email;
                    Settings.Default.Save();
                    _loggedInUserId = Settings.Default.LoggedInUserId;

                    _loggedInUserId = GenerateUserIdFromEmail();

                    return "True";
                }
                else
                {
                    return "FalsePassword";
                }
            }
            else
            {
                return "FalseUser";
            }
        }

        public string SignUp(User user)
        {
            User dboQueryUser = _userDal.Get(u => u.Email == user.Email);

            if (dboQueryUser is null)
            {
                User newUser = new User();
                newUser.Name = user.Name;
                newUser.Surname = user.Surname;
                newUser.Email = user.Email;
                newUser.Password = user.Password;
                
                Add(newUser);
                
                //Ekstra sonradan kategori eklemek için koydum.
              User tempUser=  _userDal.Get(u => u.Email == newUser.Email);

              AddDefaultCategories(tempUser.Id);

                return "Added";
            }
            else
            {
                return "AlreadyExists";
            }
        }

        public void ClearSettingsDefault()
        {
            Settings.Default.LoggedInUserEmail = "";
        }

        private void AddDefaultCategories(int userId)
        {
            _categoryDal.Add(new Category
            {
                UserId = userId,
                Name = "C#"
            }); 
            
            _categoryDal.Add(new Category
            {
                UserId = userId,
                Name = "Xamarin"
            }); 
            
            _categoryDal.Add(new Category
            {
                UserId = userId,
                Name = "ASPNET"
            });
        }

        private int GenerateUserIdFromEmail()
        {

            ReadDefaultSettings();
            User user = _userDal.Get(u => u.Email == _loggedInUserEmail);

            Settings.Default.LoggedInUserId = user.Id;
            return user.Id;
        }

        private void ReadDefaultSettings()
        {

            _loggedInUserEmail = Settings.Default.LoggedInUserEmail;
        }

    }
}
