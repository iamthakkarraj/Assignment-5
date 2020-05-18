using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.BLL.ViewModels;
using CRUD.BLL.Interface;
using CRUD.DAL.Interface;
using CRUD.DAL.Repository;
using CRUD.DAL.Database;

namespace CRUD.BLL.Service {

   public class UserService : IUserService {

        IUserRepository _UserRepository;

        public UserService() {
            _UserRepository = new UserRespository();
        }        

        public bool AddUser(UserModel user) {
            return _UserRepository
                    .AddUser(ModelMapperService
                        .Map<UserModel,User>(user));
        }

        public bool DeleteUser(int id) {
            return _UserRepository.DeleteUser(id);
        }

        public UserModel GetUser(int id) {
            return ModelMapperService
                        .Map<User, UserModel>(
                        _UserRepository.GetUser(id));
        }

        public List<UserModel> GetUsers() {
            
            List<UserModel> destination = new List<UserModel>();

            foreach(User user in _UserRepository.GetUsers()) {
                destination.Add(ModelMapperService.Map<User, UserModel>(user));
            }

            return destination;

        }

        public bool UpdateUser(UserModel user) {
            return _UserRepository
                    .UpdateUser(ModelMapperService
                        .Map<UserModel, User>(user));
        }

    }

}