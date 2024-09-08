using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SalesSystem.Areas.Users.Models;
using SalesSystem.Library;

namespace SalesSystem.Areas.Users.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private LUsersRoles _UserRole;

        public RegisterModel(
            SignInManager<IdentityUser> signInManager, 
            UserManager<IdentityUser> userManager, 
            RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _UserRole = new LUsersRoles();
        }

        public void OnGet()
        {
            Input = new InputModel 
            {
                rolesLista = _UserRole.GetRoles(_roleManager)
            };
        }
        [BindProperty]
        public InputModel Input { get; set; }
        
        public class InputModel : InputModelRegister
        {
            public List<SelectListItem> rolesLista {  get; set; }

            public IFormFile AvatarImage { get; set; }
           public string ErrorMessage { get; set; }
            
        }
    }
}
