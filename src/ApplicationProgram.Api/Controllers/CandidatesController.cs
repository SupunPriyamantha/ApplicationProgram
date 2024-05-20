using ApplicationProgram.Api.Models.Candidates.Commands.Create;
using Asp.Versioning;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationProgram.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/Candidates")]
    [ApiController]
    public class CandidatesController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public CandidatesController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCandidate([FromBody] CreateCandidateCommand command, CancellationToken cancellationToken)
        {
            var applicationCommand = _mapper.Map<Application.Handlers.Candidates.Commands.Create.CreateCandidateCommand>(command);

            var applicationResult = await _mediator.Send(applicationCommand, cancellationToken);
            var result = _mapper.Map<Models.BaseResponse>(applicationResult);


            return ToActionResult(result);
        }
    }
}
