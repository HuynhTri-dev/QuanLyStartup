using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using QuanLyStartup.Models;
using System.Threading.Tasks;

public class AccountController : Controller
{
  
    public IActionResult Register() => View();


}
