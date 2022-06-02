using NotasFiscaisAPI.Data;
using NotasFiscaisAPI.Models;
using NotasFiscaisAPI.Repository.IRepository;

namespace NotasFiscaisAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext _UserContext;

        public UserRepository(DataBaseContext userContext)
        {
            _UserContext = userContext;
        }

        public bool Delete(Guid id)
        {
            var user = _UserContext.Users.Find(id);
            if (user == null)
            {
                return false;
            }
            else
            {
                _UserContext.Users.Remove(user);
                return true;
            }
        }

        public User Edit(Guid id, string name, string password)
        {
            
            if (UserExists(id))
            {
                var user = _UserContext.Users.Find(id);
                if(name != user.Name)
                {
                    user.Name = name;
                }
                if(password != user.Password)
                {
                    password = user.Password;
                }
                return user;
            }
            else
            {
                return null;
            }
        }

        public User Get(Guid id)
        {
            var user = _UserContext.Users.Find(id);
            if (UserExists(id))
            {
                return user;
            }
            else
            {
                return null;

            }


        }

        public IEnumerable<User> GetAll( )
        {
            var users = _UserContext.Users.ToList();
            return users;
        }

        public bool Save(string name, string password)
        {
            User user = new User();
            user.Name = name;
            user.Password = password;
            if (user.Password != null && user.Name != null)
            {
                _UserContext.Users.Add(user);
                return true;
            }
            else
            {
                return false;
            }

        }


        private bool UserExists(Guid id)
        {
            return (_UserContext.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
