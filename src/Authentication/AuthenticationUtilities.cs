using Microsoft.AspNetCore.Http;

namespace NightCloud.Common.Services.Authentication;

public static class AuthenticationUtilities
{
    public static Guid GetUserId(HttpContext httpContext)
    {
        var userIdItem = httpContext.Items["UserId"];
        var userId = Guid.Parse(userIdItem.ToString()!);
        return userId;
    } 
}