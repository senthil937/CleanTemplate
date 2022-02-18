using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Core.Contracts;
namespace Core.Entities
{
   public class Users : BaseEntity , ITenant 
    {
        [Key]
        public int UserId
        {
            get;
            set;
        }
        public string TenantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        
    }
}
