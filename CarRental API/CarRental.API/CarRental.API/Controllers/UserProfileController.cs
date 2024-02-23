﻿using CarRental.API.Data.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : Controller
    {
            private UserManager<Users> _userManager;
            public UserProfileController(UserManager<Users> userManager)
            {
                _userManager = userManager;
            }

            [HttpGet]
            [Authorize]
            //GET : /api/UserProfile
            public async Task<Object> GetUserProfile()
            {
                string userId = User.Claims.First(c => c.Type == "UserID").Value;
                var user = await _userManager.FindByIdAsync(userId);
                return new
                {
                   
                    user.Email,
                   
                };
            }

            [HttpGet]
            [Authorize(Roles = "Admin")]
            [Route("ForAdmin")]
            public string GetForAdmin()
            {
                return "Web method for Admin";
            }

            [HttpGet]
            [Authorize(Roles = "Customer")]
            [Route("ForCustomer")]
            public string GetCustomer()
            {
                return "Web method for Customer";
            }

            [HttpGet]
            [Authorize(Roles = "Admin,Customer")]
            [Route("ForAdminOrCustomer")]
            public string GetForAdminOrCustomer()
            {
                return "Web method for Admin or Customer";
            }
        }
    
}
