using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        private readonly IWebHostEnvironment he;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AddModel(
            ILogger<AddModel> logger,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IWebHostEnvironment environment,
            ApplicationDbContext applicationDbContext
        )
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            he = environment;
            _appDbContext = applicationDbContext;
        }

        public void OnPost(string judul, string highlight, string body, string publisher, IFormFile picture, string category, DateTime created)
        {
            if (picture != null)
            {
            var path = "wwwroot//images";
            Directory.CreateDirectory(path);
            var FileName= Path.Combine(path, Path.GetFileName(picture.FileName));
            picture.CopyTo(new FileStream(FileName, FileMode.Create));
            var file = FileName.Substring(8).Replace(@"\","/");
            Article article = new Article()
            {
                judul = judul,
                highlight = highlight,
                body = body,
                publisher = publisher,
                category = category,
                picture = file,
                created = created
            };
            _appDbContext.Articles.Add(article);
            }
            _appDbContext.SaveChanges();
        }
    }
}
