using Core.Entities;
using Core.Interfaces;
using Core.ViewModel;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext context;

        public UserService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ResponseModel> DeleteUser(int userid)
        {
            ResponseModel response = new ResponseModel();

            try
            {
                Users usr = await GetUserById(userid);
                if (usr != null)
                {
                    context.Remove<Users>(usr);
                    await context.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Messsage = "User Deleted Successfully";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Messsage = "User doesn't exist";
                    throw new KeyNotFoundException();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }

        public async Task<Users> GetUserById(int userid)
        {
            return await context.Users.FindAsync(userid);
        }

        public async Task<List<Users>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<Users> SaveUser(Users users)
        {
            context.Users.Add(users);
            await context.SaveChangesAsync();
            //context.Entry(users).GetDatabaseValues();
            return users;
        }


        public async Task<ResponseModel> UpdateUser(Users users)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                Users usr = await GetUserById(users.UserId);
                if (usr != null)
                {
                    usr.FirstName = users.FirstName;
                    usr.LastName = users.LastName;
                    usr.Password = users.Password;
                    usr.Email = users.Email;
                    usr.Phone = users.Phone;
                    usr.IsActive = users.IsActive;
                    context.Update<Users>(usr);
                    await context.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Messsage = "User Updated Successfully";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Messsage = "User Not Found Successfully";
                    throw new KeyNotFoundException();
                }

                return response;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
