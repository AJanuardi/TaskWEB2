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
    public class ViewModel : PageModel
    {
        private readonly ILogger<ViewModel> _logger;
        private ApplicationDbContext _appDbContext;

        private readonly UserManager<IdentityUser> _userManager;
        // Inject SignInManager
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public ViewModel(
            ILogger<ViewModel> logger,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext applicationDbContext
        )
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _appDbContext = applicationDbContext;
        }

        public void OnGet(int id)
        {
            var x = _appDbContext.Articles.Find(id);
            ViewData["Articles"] = x;
            var y = _userManager.GetUserName(User);
            ViewData["User"] = y;
            var z = from i in _appDbContext.Comments where (i.articleid == id) select i;
            ViewData["Comment"] = z;
        }

        public IActionResult OnPost(int id, string user, string comment)
        {
            Comment add = new Comment()
            {
                articleid = id,
                username = user,
                comment = comment,
                created = DateTime.Now
            };
            _appDbContext.Comments.Add(add);
            _appDbContext.SaveChanges();
            return Redirect("View?id="+id);
        }
    }
}
