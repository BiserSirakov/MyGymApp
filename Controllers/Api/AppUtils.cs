namespace MyGymApp.Controllers.Api
{
    using System.Collections.Generic;
    using AspNetCoreSpa.Server.Entities;
    using Microsoft.AspNetCore.Mvc;

    public class AppUtils
    {
        internal static IActionResult SignIn(ApplicationUser user, IList<string> roles)
        {
            var userResult = new { User = new { DisplayName = user.UserName, Roles = roles } };
            return new ObjectResult(userResult);
        }
    }
}