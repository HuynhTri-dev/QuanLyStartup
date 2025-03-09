using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyStartup.Data;
using QuanLyStartup.Models;
using System;

namespace QuanLyStartup.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        


        public IActionResult Register() 
        {
            return View();
        }

        
        public IActionResult Login() => View();
    }
}
