using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CRUD.DAL.Database;
using CRUD.DAL.Interface;

namespace CRUD.DAL.Repository {

    public class UserRespository : IUserRepository {
        
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
            return DBContext.Users.ToList();
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
                DBContext
                    .Entry(user)
                    .State = EntityState.Modified;
                DBContext.SaveChanges();
                return true;
            } catch (Exception e) {
                return false;
            }
        }

        public bool DeleteUser(int id) {
            try {
                DBContext
                .Users
                .Remove(
                    DBContext
                    .Users
                    .Where(x => x.UserId == id)
                    .FirstOrDefault());
                DBContext.SaveChanges();

                return true;
            } catch (Exception e) {
                return false;
            }
        }

    }

}