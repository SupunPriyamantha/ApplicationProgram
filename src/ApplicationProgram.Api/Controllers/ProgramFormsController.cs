using ApplicationProgram.Api.Models;
using ApplicationProgram.Api.Models.ProgramForms.Commands.Create;
using ApplicationProgram.Api.Models.ProgramForms.Commands.Update;
using Asp.Versioning;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationProgram.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/ProgramForms")]
    [ApiController]
    public class ProgramFormsController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ProgramFormsController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProgramFormDetails([FromRoute] int id, CancellationToken cancellationToken)
        {
            var applicationQuery = new Application.Handlers.ProgramForms.Queries.Details.ProgramFormDetailsQuery() { Id = id };
            
            var applicationResult = await _mediator.Send(applicationQuery, cancellationToken);
            var result = _mapper.Map<Models.BaseResponse>(applicationResult);
            //BaseResponse result = (BaseResponse)_mapper.Map(applicationResult, applicationResult.GetType(), typeof(BaseResponse));

            return ToActionResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePrgramForm([FromBody] CreateProgramFormCommand command, CancellationToken cancellationToken)
        {
            var applicationCommand = _mapper.Map<Application.Handlers.ProgramForms.Commands.Create.CreateProgramFormCommand>(command);

            var applicationResult = await _mediator.Send(applicationCommand, cancellationToken);
            var result = _mapper.Map<Models.BaseResponse>(applicationResult);


            return ToActionResult(result);
        }

        [HttpPut("{id:int}")]

        public async Task<ActionResult> UpdatePrgramForm([FromRoute] int id, [FromBody] UpdateProgramFormCommand command, CancellationToken cancellationToken)
        {
            var applicationCommand = _mapper.Map<Application.Handlers.ProgramForms.Commands.Update.UpdateProgramFormCommand>(command);
            applicationCommand.FormId = id;

            var applicationResult = await _mediator.Send(applicationCommand, cancellationToken);
            var result = _mapper.Map<Models.BaseResponse>(applicationResult);

            return Ok(result);
        }
    }
}
