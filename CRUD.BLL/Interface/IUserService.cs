using System.Collections.Generic;
using CRUD.BLL.ViewModels;

namespace CRUD.BLL.Interface {

    public interface IUserService {

        List<UserModel> GetUsers();
        UserModel GetUser(int id);
        bool AddUser(UserModel user);
        bool UpdateUser(UserModel user);
        bool DeleteUser(int id);

    }

}