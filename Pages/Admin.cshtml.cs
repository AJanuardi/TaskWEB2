using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TaskWEB2.Data;
using TaskWEB2.Models;

namespace TaskWEB2.Pages
{
    [Authorize(Roles = "Admin, Supervisor")]
    public class AdminModel : PageModel
    {
        private readonly ILogger<AdminModel> _logger;
        private ApplicationDbContext _appDbContext;

        private readonly UserManager<IdentityUser> _userManager;
        // Inject SignInManager
        private readonly SignInManager<IdentityUser> _signInManager;
        public AdminModel(
            ILogger<AdminModel> logger,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ApplicationDbContext applicationDbContext
        )
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _appDbContext = applicationDbContext;
        }

        public void OnGet()
        {
                var x = from i in _appDbContext.Articles select i;
                ViewData["Data"] = x;
        }

        public IActionResult OnPost(string id, string judul, string highlight, string body, string publisher, string edit)
        {
            if (id.Contains("remove"))
            {
                var text = id.Replace("remove-","");
                var angka = Convert.ToInt32(text);
                var x = _appDbContext.Articles.Find(angka);
                _appDbContext.Remove(x);
                _appDbContext.SaveChanges();
            }
            else if (edit.Contains("edit"))
            {
                var angka = Convert.ToInt32(id);
                var x = _appDbContext.Articles.Find(angka);
                x.judul = judul;
                x.highlight = highlight;
                x.body = body;
                x.publisher = publisher;
                x.created = DateTime.Now;
                _appDbContext.SaveChanges();
            }
            return RedirectToPage("Admin");
        }
    }
}
