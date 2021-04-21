using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movieshop.Areas.Identity
{
    public class UserModel
    {
        [Key]        
        public string Id { get; set; }        
        public string Email { get; set; }        
        public string Name { get; set; }        
        public string password { get; set; }
        public IQueryable<SelectListItem> Roles{ get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
