using CRUD.DAL.Database;

namespace CRUD.DAL.Interface {    

    public interface IAuthenticationRepository {        

        bool VerifyUser(Login login);

    }

}