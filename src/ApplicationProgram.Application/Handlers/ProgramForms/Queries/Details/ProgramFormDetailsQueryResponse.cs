using Microsoft.AspNetCore.Http;

namespace ApplicationProgram.Application.Handlers.ProgramForms.Queries.Details
{
    public class ProgramFormDetailsQueryResponse : BaseResponse
    {
        public ProgramFormDetailsQueryResponse(ProgramFormModel programForm)
            : base(StatusCodes.Status200OK)
        {
            ProgramForm = programForm;
        }

        public ProgramFormModel ProgramForm { get; private set; }
    }
}
