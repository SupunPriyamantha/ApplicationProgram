using MediatR;

namespace ApplicationProgram.Application.Handlers.ProgramForms.Queries.Details
{
    public class ProgramFormDetailsQuery : IRequest<BaseResponse>
    {
        public int Id { get; set; }
    }
}
