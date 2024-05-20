using ApplicationProgram.Application.Handlers.ProgramForms.Queries.Details;
using ApplicationProgram.Domain.Models.ProgramForms;
using FluentAssertions;
using Moq;
using System.ComponentModel;

namespace ApplicationProgram.Test.ProgramForms
{
    public class ProgramFormDetailsQueryHandlerTest
    {
        private readonly ProgramFormDetailsQueryHandler _handler;

        private readonly Mock<IProgramFormRepository> _programFormRepository;
        private readonly ProgramForm _programForm;

        public ProgramFormDetailsQueryHandlerTest()
        {
            _programFormRepository = new Mock<IProgramFormRepository>();

            _programForm = new ProgramForm(
                "Summer Program",
                "Summer Internship for students");


            _programFormRepository.Setup(s => s.Get(It.IsAny<int>()))
                .ReturnsAsync((int formId) => (_programForm.Id == formId) ? _programForm : null);

            _handler = new ProgramFormDetailsQueryHandler(_programFormRepository.Object);
        }

        [Fact]
        [Category("Application")]
        public async Task Handle_GivenValidInput_ReturnsResponseModel()
        {
            var query = new ProgramFormDetailsQuery
            {
                Id = _programForm.Id
            };

            var result = await _handler.Handle(query, default);
            result.Should().BeOfType<ProgramFormDetailsQueryResponse>();
            result.StatusCode.Should().Be(200);
            (result as ProgramFormDetailsQueryResponse).ProgramForm.Title.Should().Be("Summer Program");
            (result as ProgramFormDetailsQueryResponse).ProgramForm.Description.Should().Be("Summer Internship for students");
        }
    }
}
