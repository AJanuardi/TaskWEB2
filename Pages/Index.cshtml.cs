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
            if (i == "8d8a6be5-70b7-49d4-861e-82ce45ba2fa7")
            {
                return new RedirectToPageResult("IndexAdmin");
            }
            if (i == "d8c75bb8-f5a5-42a0-afdf-d197dc8a5a60")
            {
                return new RedirectToPageResult("IndexAdmin");   
            }
            }
            return new RedirectToPageResult("IndexUser");
        }
    }
}
