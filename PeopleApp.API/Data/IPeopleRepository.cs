using System.Collections.Generic;
using System.Threading.Tasks;
using PeopleApp.API.Models;

namespace PeopleApp.API.Data
{
    public interface IPeopleRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T> (T entity) where T:class;

         Task<bool> SaveAll();
         Task <IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}