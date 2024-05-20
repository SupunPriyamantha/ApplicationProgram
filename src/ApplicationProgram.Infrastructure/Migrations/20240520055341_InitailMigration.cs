using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationProgram.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitailMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgramForm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramForm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramForm_CustomQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionType = table.Column<int>(type: "int", nullable: false),
                    OtherEnabled = table.Column<bool>(type: "bit", nullable: true),
                    MaxChoice = table.Column<int>(type: "int", nullable: true),
                    ProgramFormId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramForm_CustomQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramForm_CustomQuestion_ProgramForm_ProgramFormId",
                        column: x => x.ProgramFormId,
                        principalTable: "ProgramForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Question_AnswerChoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Choice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomQuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question_AnswerChoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_AnswerChoice_ProgramForm_CustomQuestion_CustomQuestionId",
                        column: x => x.CustomQuestionId,
                        principalTable: "ProgramForm_CustomQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramForm_CustomQuestion_ProgramFormId",
                table: "ProgramForm_CustomQuestion",
                column: "ProgramFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_AnswerChoice_CustomQuestionId",
                table: "Question_AnswerChoice",
                column: "CustomQuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question_AnswerChoice");

            migrationBuilder.DropTable(
                name: "ProgramForm_CustomQuestion");

            migrationBuilder.DropTable(
                name: "ProgramForm");
        }
    }
}
