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
    public class AddModel : PageModel
    {
        private readonly ILogger<AddModel> _logger;
        private ApplicationDbContext _appDbContext;

        private readonly UserManager<IdentityUser> _userManager;
        // Inject SignInManager
        private readonly SignInManager<IdentityUser> _signInManager;
        public AddModel(
            ILogger<AddModel> logger,
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

        public void OnPost(string judul, string highlight, string body, string publisher, DateTime created)
        {
            Article article = new Article()
            {
                judul = judul,
                highlight = highlight,
                body = body,
                publisher = publisher,
                created = created
            };
            _appDbContext.Articles.Add(article);
            _appDbContext.SaveChanges();
        }
    }
}
