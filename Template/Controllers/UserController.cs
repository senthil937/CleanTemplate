using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core.Interfaces;
using Core.Entities;

namespace WebApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }




        /// <summary>
        /// GetUsers
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var usr = await service.GetUsers();
                if (usr == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(usr);
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        /// <summary>
        /// GetUsers
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUserById/{userid}")]
        public async Task<IActionResult> GetUserById(int userid)
        {
            try
            {
                var usr = await service.GetUserById(userid);
                if (usr == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(usr);
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        /// <summary>
        /// Add User
        /// </summary>
        /// <param name="usr"></param>
        /// <returns></returns>
        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser(Users usr)
        {
            try
            {
                return Ok( await service.SaveUser(usr));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <returns></returns>
        [HttpPatch("UpdateUser")]
        public async Task<IActionResult> UpdateUser(Users usr)
        {

            try
            {
                return Ok(await service.UpdateUser(usr));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpDelete("DeleteUser/{userid}")]

        public async Task<IActionResult> DeletUser(int userid)
        {
            return Ok(await service.DeleteUser(userid));
        }
    }

}
