﻿using LabAuthorizationTS.Authorization.Requirements;
using LabAuthorizationTS.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace LabAuthorizationTS.Authorization.Handlers
{
    public class MinimumAgeHandler : AuthorizationHandler<MinimumAgeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumAgeRequirement requirement)
        {
            //TODO sprawdzenie czy użytkownik jest pełnoletni (metoda rozszerzająca IsAdult)

            return Task.CompletedTask;
        }
    }
}