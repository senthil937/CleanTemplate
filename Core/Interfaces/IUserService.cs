using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using System.Threading.Tasks;
using Core.ViewModel;
namespace Core.Interfaces
{
    public interface IUserService
    {/// <summary>
     /// get User List
     /// </summary>
     /// <returns></returns>
        Task<List<Users>> GetUsers();

        /// <summary>
        /// get User by Id
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task<Users> GetUserById(int userid);

        /// <summary>
        /// Add user
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        Task<Users> SaveUser(Users users);


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        Task<ResponseModel> UpdateUser(Users users);



        /// <summary>
        /// Delete an Employee
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task<ResponseModel> DeleteUser(int userid);
    }
}
