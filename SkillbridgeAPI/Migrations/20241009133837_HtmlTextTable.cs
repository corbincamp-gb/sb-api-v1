using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillBridgeAPI.Migrations
{
    /// <inheritdoc />
    public partial class HtmlTextTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dss");

            migrationBuilder.EnsureSchema(
                name: "TaskHosting");

           
            migrationBuilder.CreateTable(
                name: "HtmlText",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alias = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    HTML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HtmlText__3214EC07174C01A2", x => x.Id);
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "agent_instance",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "agent_version",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "APIState");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserAuthorities");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Audits");

            migrationBuilder.DropTable(
                name: "configuration",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "DeliveryMethods");

            migrationBuilder.DropTable(
                name: "EmailLogs");

            migrationBuilder.DropTable(
                name: "EntryStatusTracking");

            migrationBuilder.DropTable(
                name: "EnumType",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "FormResponseChoices");

            migrationBuilder.DropTable(
                name: "FormResponseFiles");

            migrationBuilder.DropTable(
                name: "FormResponseRows");

            migrationBuilder.DropTable(
                name: "HtmlText");

            migrationBuilder.DropTable(
                name: "JobFamilies");

            migrationBuilder.DropTable(
                name: "MessageQueue",
                schema: "TaskHosting");

            migrationBuilder.DropTable(
                name: "MetaInformation",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "MouFiles");

            migrationBuilder.DropTable(
                name: "OpportunityGroups");

            migrationBuilder.DropTable(
                name: "OrganizationFiles");

            migrationBuilder.DropTable(
                name: "ParticipationPopulations");

            migrationBuilder.DropTable(
                name: "PendingOpportunityAdditions");

            migrationBuilder.DropTable(
                name: "PendingOpportunityChanges");

            migrationBuilder.DropTable(
                name: "PendingOrganizationChanges");

            migrationBuilder.DropTable(
                name: "PendingProgramAdditions");

            migrationBuilder.DropTable(
                name: "PendingProgramAdditionsDeliveryMethod");

            migrationBuilder.DropTable(
                name: "PendingProgramAdditionsJobFamily");

            migrationBuilder.DropTable(
                name: "PendingProgramAdditionsParticipationPopulation");

            migrationBuilder.DropTable(
                name: "PendingProgramAdditionsService");

            migrationBuilder.DropTable(
                name: "PendingProgramChanges");

            migrationBuilder.DropTable(
                name: "PendingProgramDeliveryMethod");

            migrationBuilder.DropTable(
                name: "PendingProgramJobFamily");

            migrationBuilder.DropTable(
                name: "PendingProgramParticipationPopulation");

            migrationBuilder.DropTable(
                name: "PendingProgramService");

            migrationBuilder.DropTable(
                name: "PendingProgramServiceOLD");

            migrationBuilder.DropTable(
                name: "ProgramDeliveryMethod");

            migrationBuilder.DropTable(
                name: "ProgramJobFamily");

            migrationBuilder.DropTable(
                name: "ProgramParticipationPopulation");

            migrationBuilder.DropTable(
                name: "ProgramService");

            migrationBuilder.DropTable(
                name: "ProgramServiceOLD");

            migrationBuilder.DropTable(
                name: "ProgramStates");

            migrationBuilder.DropTable(
                name: "ProgramTrainingPlans");

            migrationBuilder.DropTable(
                name: "QPPdfs");

            migrationBuilder.DropTable(
                name: "QPResponseQuestionAnswers");

            migrationBuilder.DropTable(
                name: "QPResponseQuestions");

            migrationBuilder.DropTable(
                name: "QPResponses");

            migrationBuilder.DropTable(
                name: "scaleunitlimits",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "ScheduleTask",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "ScheduleTask",
                schema: "TaskHosting");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "SiteConfiguration");

            migrationBuilder.DropTable(
                name: "syncgroupmember",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "SyncObjectData",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "taskdependency",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "TrainingPlanBreakdowns");

            migrationBuilder.DropTable(
                name: "TrainingPlanInstructionalMethods");

            migrationBuilder.DropTable(
                name: "UIHistory",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "agent",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "FormResponses");

            migrationBuilder.DropTable(
                name: "Job",
                schema: "TaskHosting");

            migrationBuilder.DropTable(
                name: "Mous");

            migrationBuilder.DropTable(
                name: "Opportunities");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "Schedule",
                schema: "TaskHosting");

            migrationBuilder.DropTable(
                name: "syncgroup",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "task",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "InstructionalMethods");

            migrationBuilder.DropTable(
                name: "TrainingPlans");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "userdatabase",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "ActionModel");

            migrationBuilder.DropTable(
                name: "TrainingPlanLengths");

            migrationBuilder.DropTable(
                name: "Entries");

            migrationBuilder.DropTable(
                name: "FormTemplates");

            migrationBuilder.DropTable(
                name: "subscription",
                schema: "dss");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
