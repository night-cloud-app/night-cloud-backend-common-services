using NightCloud.Common.Middlewares.ExceptionHandling.Exceptions;

namespace NightCloud.Common.Services.Authentication;

public class InvalidUserIdHeaderBadRequestException : BadRequestException
{
    public InvalidUserIdHeaderBadRequestException() : base("User id header is not valid or present")
    {
    }
}