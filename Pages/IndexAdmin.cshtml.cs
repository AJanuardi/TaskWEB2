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
    [Authorize(Roles = "Admin, Supervisor")]
    public class IndexAdminModel : PageModel
    {
        private readonly ILogger<IndexAdminModel> _logger;
        private ApplicationDbContext _appDbContext;

        private readonly UserManager<IdentityUser> _userManager;
        // Inject SignInManager
        private readonly SignInManager<IdentityUser> _signInManager;
        public IndexAdminModel(
            ILogger<IndexAdminModel> logger,
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
    }
}
