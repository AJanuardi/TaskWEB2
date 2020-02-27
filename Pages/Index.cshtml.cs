using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TaskWEB2.Data;

namespace TaskWEB2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ApplicationDbContext _appDbContext;

        private readonly UserManager<IdentityUser> _userManager;
        // Inject SignInManager
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public IndexModel(
            ILogger<IndexModel> logger,
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
        public IActionResult OnGet()
        {
            var userid = _userManager.GetUserId(User);
            var userrole = from i in _appDbContext.UserRoles where i.UserId == userid select i.RoleId;
            foreach (var i in userrole)
            {
            if (i == "86453ab0-9663-4641-8876-2c8fe1e7f606")
            {
                return new RedirectToPageResult("IndexAdmin");
            }
            if (i == "8979ec23-a4de-40b2-85c3-b465f394b1a5")
            {
                return new RedirectToPageResult("IndexAdmin");   
            }
            }
            return new RedirectToPageResult("IndexUser");
        }
    }
}
