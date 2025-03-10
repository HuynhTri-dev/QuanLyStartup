using Microsoft.AspNetCore.Mvc;
using QuanLyStartup.Data;
using QuanLyStartup.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;

public class AccountController : Controller
{
    private readonly ApplicationDbContext _db;

    public AccountController(ApplicationDbContext db)
    {
        _db = db;
    }

    // Hiển thị form đăng ký
    public IActionResult Register() => View();

    // Xử lý đăng ký
    [HttpPost]
    public IActionResult Register(NguoiDung model)
    {
        if (ModelState.IsValid)
        {
            var existingUser = _db.NguoiDungs.FirstOrDefault(u => u.Email == model.Email);
            if (existingUser != null)
            {
                ViewBag.Error = "Tài khoản đã tồn tại!";
                return View();
            }

            _db.NguoiDungs.Add(model);
            _db.SaveChanges();

            ViewBag.Success = "Đăng ký thành công! Vui lòng đăng nhập.";
            return RedirectToAction("Login");
        }

        return View(model);
    }

    // Hiển thị form đăng nhập
    public IActionResult Login() => View();

    // Xử lý đăng nhập
    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        var user = _db.NguoiDungs.FirstOrDefault(u => u.Email == email);
        if (user == null)
        {
            ViewBag.Error = "Tài khoản không tồn tại!";
            return View();
        }

        // Kiểm tra mật khẩu
        if (password != user.MatKhau)
        {
            ViewBag.Error = "Sai mật khẩu!";
            return View();
        }

        // Lưu thông tin đăng nhập vào session
        HttpContext.Session.SetString("UserName", user.IDNguoiDung.ToString());

        return RedirectToAction("Index", "Home");
    }

    // Đăng xuất
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }
}
