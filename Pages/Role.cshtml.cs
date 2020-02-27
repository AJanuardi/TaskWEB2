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
    [Authorize(Roles = "Supervisor")]
    public class RoleModel : PageModel
    {
        private readonly ILogger<RoleModel> _logger;
        private ApplicationDbContext _appDbContext;

        private readonly UserManager<IdentityUser> _userManager;
        // Inject SignInManager
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public RoleModel(
            ILogger<RoleModel> logger,
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
        public void OnGet()
        {
            var roles = _roleManager.Roles;
            var user = from i in _appDbContext.Users select i;
            ViewData["Role"] = roles;
            ViewData["User"] = user;
        }
        public async Task<IActionResult> OnPostAsync(string role_name, string delete_id, string user_id, string roleuser)
        {
            if(role_name != null)
            {
                IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(role_name));
            }
            if(delete_id != null)
            {
                IdentityRole role = await _roleManager.FindByIdAsync(delete_id);
                if(role != null)
                {
                    IdentityResult result = await _roleManager.DeleteAsync(role);
                }
            }
            if(user_id != null && roleuser != null)
            {
                var user = await _userManager.FindByIdAsync(user_id);
                await _userManager.AddToRoleAsync(user, roleuser);
            }
            return RedirectToPage();
        }
    }
}
