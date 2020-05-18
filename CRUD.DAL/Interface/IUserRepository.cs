using System.Collections.Generic;
using CRUD.DAL.Database;

namespace CRUD.DAL.Interface {

    public interface IUserRepository {

        List<User> GetUsers();
        User GetUser(int id);
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);

    }

}