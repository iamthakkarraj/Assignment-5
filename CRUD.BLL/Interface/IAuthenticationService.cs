using CRUD.BLL.ViewModels;

namespace CRUD.BLL.Interface {

    public interface IAuthenticationService {

        bool VerifyUser(LoginModel login);

    }

}