using Microsoft.AspNetCore.Http;

namespace ApplicationProgram.Application.Handlers
{
    public class NotFoundResponse : BaseResponse
    {
        public NotFoundResponse()
            : base(StatusCodes.Status404NotFound)
        {
        }
    }
}
