using Microsoft.AspNetCore.Http;

namespace ApplicationProgram.Application.Handlers
{
    public abstract class BaseResponse
    {
        protected BaseResponse(int statusCode)
        {
            if (statusCode != StatusCodes.Status200OK &&
                statusCode != StatusCodes.Status404NotFound)
            {
                throw new ArgumentException(nameof(statusCode), "Status code is not valid");
            }

            StatusCode = statusCode;
        }

        public int StatusCode { get; }
    }
}
