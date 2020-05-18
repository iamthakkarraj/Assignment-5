using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.DAL.Database;
using CRUD.DAL.Interface;

namespace CRUD.DAL.Repository {

    class UserRespository : IUserRepository {
        
        private readonly CRUDAssignmentEntities DBContext;
        
        public UserRespository() {
            DBContext = new CRUDAssignmentEntities();
        }

        public User GetUser(int id) {
            return DBContext
                    .Users
                    .Where(x=>x.UserId == id)
                    .FirstOrDefault();
        }

        public List<User> GetUsers() {
            return DBContext.Users.ToList()
        }

        public bool AddUser(User user) {
            try {
                DBContext.Users.Add(user);
                DBContext.SaveChanges();
                return true;
            } catch (Exception e) {
                return false;
            }
        }

        public bool UpdateUser(User user) {
            try {
                DBContext.Users.Add(user);
                DBContext.SaveChanges();
                return true;
            } catch (Exception e) {
                return false;
            }
        }

        public bool DeleteUser() {
            throw new NotImplementedException();
        }
    }

}