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

namespace TaskWEB2.Pages
{
    [Authorize]
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
            if (_userManager.GetUserId(User) == "176caa26-a9d0-4692-8d8b-74c5de220e4a")
            {
                var x = from i in _appDbContext.Articles select i;
                ViewData["Data"] = x;
            }
            else
            {
                ViewData["Data"] = null;
                ViewData["Warning"] = "You Dont Have Access";
            }
        }

        public void OnGetDelete(int id)
        {
            Console.WriteLine("=================================");
            Console.WriteLine(id);
            var x = _appDbContext.Articles.Find(id);
            _appDbContext.Remove(x);
            _appDbContext.SaveChanges();
        }
    }
}
