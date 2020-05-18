using CRUD.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.DAL.Interface;

namespace CRUD.DAL.Repository {
    
    public class AuthenticationRepository : IAuthenticationRepository {

        private readonly CRUDAssignmentEntities DBContext;

        public AuthenticationRepository() {
            DBContext = new CRUDAssignmentEntities();
        }

        public bool VerifyUser(Login login) {
            return (DBContext
                    .Logins
                    .Where(x => x.Username == login.Username)
                    .Where(x => x.Password == login.Password)
                    .Count() == 1);
        }

    }

}