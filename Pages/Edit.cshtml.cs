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
    public class EditModel : PageModel
    {
        private readonly ILogger<EditModel> _logger;
        private ApplicationDbContext _appDbContext;

        private readonly UserManager<IdentityUser> _userManager;
        // Inject SignInManager
        private readonly SignInManager<IdentityUser> _signInManager;
        public EditModel(
            ILogger<EditModel> logger,
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

        public IActionResult OnPost(int id, string judul, string highlight, string body, string publisher, DateTime created)
        {
            var x = _appDbContext.Articles.Find(id);
            x.judul = judul;
            x.highlight = highlight;
            x.body = body;
            x.publisher = publisher;
            x.created = created;
            _appDbContext.SaveChanges();
            return RedirectToPage("Edit");
        }
    }
}
