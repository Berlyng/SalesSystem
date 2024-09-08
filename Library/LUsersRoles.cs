using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.Library
{
    public class LUsersRoles
    {
        public List<SelectListItem> GetRoles(RoleManager<IdentityRole> roleManager)
        {
            // Crear una lista de elementos para el dropdown
            List<SelectListItem> _selectList = new List<SelectListItem>();

            // Obtener la lista de roles desde el RoleManager
            var roles = roleManager.Roles.ToList();

            // Iterar sobre los roles y agregarlos a la lista de SelectListItem
            roles.ForEach(role =>
            {
                _selectList.Add(new SelectListItem
                {
                    Value = role.Id,
                    Text = role.Name
                });
            });

            // Retornar la lista de SelectListItem
            return _selectList;
        }
    }
}

