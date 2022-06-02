using NotasFiscaisAPI.Models;

namespace NotasFiscaisAPI.Repository.IRepository
{
    public interface IUserRepository
    {

        public bool Save(string name,string password);

        public bool Delete(Guid id);

        public User Get (Guid id);

        public IEnumerable<User> GetAll();

        public User Edit (Guid id ,string name, string password);
    }
}
