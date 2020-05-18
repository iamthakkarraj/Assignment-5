using CRUD.BLL.Interface;
using CRUD.DAL.Interface;
using CRUD.DAL.Repository;
using CRUD.BLL.ViewModels;
using CRUD.DAL.Database;

namespace CRUD.BLL.Service {

    public class AuthenticationService : IAuthenticationService {

        private readonly IAuthenticationRepository _AuthenticationRepository;

        public AuthenticationService() {
            _AuthenticationRepository = new AuthenticationRepository();
        }

        public bool VerifyUser(LoginModel login) {
            return _AuthenticationRepository
                    .VerifyUser(ModelMapperService
                    .Map<LoginModel,Login>(login));
        }

    }

}