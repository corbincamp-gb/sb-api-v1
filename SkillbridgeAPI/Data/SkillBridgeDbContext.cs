using Microsoft.EntityFrameworkCore;
using SkillBridgeAPI.Models.Db;


namespace SkillBridgeAPI.Data;

public partial class SkillBridgeDbContext : DbContext
{
    public SkillBridgeDbContext()
    {
    }

    public SkillBridgeDbContext(DbContextOptions<SkillBridgeDbContext> options)
        : base(options)
    {
    }

    
    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<AgentInstance> AgentInstances { get; set; }

    public virtual DbSet<AgentVersion> AgentVersions { get; set; }

    public virtual DbSet<Apistate> Apistates { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserAuthority> AspNetUserAuthorities { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<Audit> Audits { get; set; }

    public virtual DbSet<Configuration> Configurations { get; set; }

    public virtual DbSet<DeliveryMethod> DeliveryMethods { get; set; }

    public virtual DbSet<EmailLog> EmailLogs { get; set; }

    public virtual DbSet<Entry> Entries { get; set; }

    public virtual DbSet<EntryStatusTracking> EntryStatusTrackings { get; set; }

    public virtual DbSet<EnumType> EnumTypes { get; set; }

    public virtual DbSet<FileModel> Files { get; set; }

    public virtual DbSet<Form> Forms { get; set; }

    public virtual DbSet<FormResponse> FormResponses { get; set; }

    public virtual DbSet<FormResponseChoice> FormResponseChoices { get; set; }

    public virtual DbSet<FormResponseFile> FormResponseFiles { get; set; }

    public virtual DbSet<FormResponseRow> FormResponseRows { get; set; }

    public virtual DbSet<FormTemplate> FormTemplates { get; set; }
    public virtual DbSet<HtmlText> HtmlTexts { get; set; }

    public virtual DbSet<InstructionalMethod> InstructionalMethods { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobFamily> JobFamilies { get; set; }

    public virtual DbSet<MessageQueue> MessageQueues { get; set; }

    public virtual DbSet<MetaInformation> MetaInformations { get; set; }

    
    public virtual DbSet<MouModel> Mous { get; set; }

    public virtual DbSet<MouFile> MouFiles { get; set; }

    public virtual DbSet<OpportunityModel> Opportunities { get; set; }

    public virtual DbSet<OpportunityGroupModel> OpportunityGroups { get; set; }

    public virtual DbSet<OrganizationModel> Organizations { get; set; }

    public virtual DbSet<OrganizationFile> OrganizationFiles { get; set; }

    public virtual DbSet<ParticipationPopulation> ParticipationPopulations { get; set; }

    public virtual DbSet<PendingOpportunityAddition> PendingOpportunityAdditions { get; set; }

    public virtual DbSet<PendingOpportunityChange> PendingOpportunityChanges { get; set; }

    public virtual DbSet<PendingOrganizationChange> PendingOrganizationChanges { get; set; }

    public virtual DbSet<PendingProgramAddition> PendingProgramAdditions { get; set; }

    public virtual DbSet<PendingProgramAdditionsDeliveryMethod> PendingProgramAdditionsDeliveryMethods { get; set; }

    public virtual DbSet<PendingProgramAdditionsJobFamily> PendingProgramAdditionsJobFamilies { get; set; }

    public virtual DbSet<PendingProgramAdditionsParticipationPopulation> PendingProgramAdditionsParticipationPopulations { get; set; }

    public virtual DbSet<PendingProgramAdditionsService> PendingProgramAdditionsServices { get; set; }

    public virtual DbSet<PendingProgramChange> PendingProgramChanges { get; set; }

    public virtual DbSet<PendingProgramDeliveryMethod> PendingProgramDeliveryMethods { get; set; }

    public virtual DbSet<PendingProgramJobFamily> PendingProgramJobFamilies { get; set; }

    public virtual DbSet<PendingProgramParticipationPopulation> PendingProgramParticipationPopulations { get; set; }

    public virtual DbSet<PendingProgramService> PendingProgramServices { get; set; }

    public virtual DbSet<PendingProgramServiceOld> PendingProgramServiceOlds { get; set; }

    public virtual DbSet<ProgramModel> Programs { get; set; }

    public virtual DbSet<ProgramDeliveryMethod> ProgramDeliveryMethods { get; set; }

    public virtual DbSet<ProgramJobFamily> ProgramJobFamilies { get; set; }

    public virtual DbSet<ProgramParticipationPopulation> ProgramParticipationPopulations { get; set; }

    public virtual DbSet<ProgramService> ProgramServices { get; set; }

    public virtual DbSet<ProgramServiceOld> ProgramServiceOlds { get; set; }

    public virtual DbSet<ProgramState> ProgramStates { get; set; }

    public virtual DbSet<ProgramTrainingPlan> ProgramTrainingPlans { get; set; }

    public virtual DbSet<Qppdf> Qppdfs { get; set; }

    public virtual DbSet<Qpresponse> Qpresponses { get; set; }

    public virtual DbSet<QpresponseQuestion> QpresponseQuestions { get; set; }

    public virtual DbSet<QpresponseQuestionAnswer> QpresponseQuestionAnswers { get; set; }

    public virtual DbSet<Scaleunitlimit> Scaleunitlimits { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }

    public virtual DbSet<ScheduleTask1> ScheduleTasks1 { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<SiteConfiguration> SiteConfigurations { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<SyncObjectDatum> SyncObjectData { get; set; }

    public virtual DbSet<Syncgroup> Syncgroups { get; set; }

    public virtual DbSet<Syncgroupmember> Syncgroupmembers { get; set; }

    public virtual DbSet<TaskModel> Tasks { get; set; }

    public virtual DbSet<TrainingPlan> TrainingPlans { get; set; }

    public virtual DbSet<TrainingPlanBreakdown> TrainingPlanBreakdowns { get; set; }

    public virtual DbSet<TrainingPlanInstructionalMethod> TrainingPlanInstructionalMethods { get; set; }

    public virtual DbSet<TrainingPlanLength> TrainingPlanLengths { get; set; }

    public virtual DbSet<Uihistory> Uihistories { get; set; }

    public virtual DbSet<Userdatabase> Userdatabases { get; set; }

    public virtual DbSet<VChangeRequest> VChangeRequests { get; set; }

    public virtual DbSet<VwQuestionProSummaryDatum> VwQuestionProSummaryData { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<ActionModel>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__action__3213E83FCFE3BFCA");

        //    entity.ToTable("action", "dss");

        //    entity.HasIndex(e => new { e.State, e.LastUpdateTime }, "index_action_state_lastupdatetime");

        //    entity.Property(e => e.Id)
        //        .HasDefaultValueSql("(newid())")
        //        .HasColumnName("id");
        //    entity.Property(e => e.CreationTime)
        //        .HasDefaultValueSql("(getutcdate())")
        //        .HasColumnType("datetime")
        //        .HasColumnName("creationtime");
        //    entity.Property(e => e.LastUpdateTime)
        //        .HasColumnType("datetime")
        //        .HasColumnName("lastupdatetime");
        //    entity.Property(e => e.State).HasColumnName("state");
        //    entity.Property(e => e.SyncGroupId).HasColumnName("syncgroupid");
        //    entity.Property(e => e.Type).HasColumnName("type");
        //});

        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__agent__3213E83F25CC6877");

            entity.ToTable("agent", "dss");

            entity.HasIndex(e => new { e.Subscriptionid, e.Name }, "IX_Agent_SubId_Name").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.IsOnPremise).HasColumnName("is_on_premise");
            entity.Property(e => e.Lastalivetime)
                .HasColumnType("datetime")
                .HasColumnName("lastalivetime");
            entity.Property(e => e.Name)
                .HasMaxLength(140)
                .HasColumnName("name");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(256)
                .HasColumnName("password_hash");
            entity.Property(e => e.PasswordSalt)
                .HasMaxLength(256)
                .HasColumnName("password_salt");
            entity.Property(e => e.State)
                .HasDefaultValue(1)
                .HasColumnName("state");
            entity.Property(e => e.Subscriptionid).HasColumnName("subscriptionid");
            entity.Property(e => e.Version)
                .HasMaxLength(40)
                .HasColumnName("version");

            entity.HasOne(d => d.Subscription).WithMany(p => p.Agents)
                .HasForeignKey(d => d.Subscriptionid)
                .HasConstraintName("FK__agent__subscript");
        });

        modelBuilder.Entity<AgentInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__agent_in__3213E83F88F6C2A7");

            entity.ToTable("agent_instance", "dss");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Agentid).HasColumnName("agentid");
            entity.Property(e => e.Lastalivetime)
                .HasColumnType("datetime")
                .HasColumnName("lastalivetime");
            entity.Property(e => e.Version)
                .HasMaxLength(40)
                .HasColumnName("version");

            entity.HasOne(d => d.Agent).WithMany(p => p.AgentInstances)
                .HasForeignKey(d => d.Agentid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__agent_ins__agent");
        });

        modelBuilder.Entity<AgentVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__agent_ve__3214EC07C2508AA3");

            entity.ToTable("agent_version", "dss");

            entity.HasIndex(e => e.Version, "UQ__agent_ve__0F540134A7F387AA").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Comment).HasMaxLength(200);
            entity.Property(e => e.ExpiresOn)
                .HasDefaultValue(new DateTime(9999, 12, 31, 23, 59, 59, 997, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.Version).HasMaxLength(50);
        });

        modelBuilder.Entity<Apistate>(entity =>
        {
            entity.ToTable("APIState");

            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserAuthority>(entity =>
        {
            entity.Property(e => e.ApplicationUserId).HasMaxLength(450);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);

            entity.HasOne(d => d.ApplicationUser).WithMany(p => p.AspNetUserAuthorities)
                .HasForeignKey(d => d.ApplicationUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AspNetUserAuthority_UserId");

            entity.HasOne(d => d.OrganizationModel).WithMany(p => p.AspNetUserAuthorities)
                .HasForeignKey(d => d.OrganizationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AspNetUserAuthority_OrganizationId");

            entity.HasOne(d => d.Program).WithMany(p => p.AspNetUserAuthorities)
                .HasForeignKey(d => d.ProgramId)
                .HasConstraintName("FK_AspNetUserAuthority_ProgramId");
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Audit>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Configuration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__configur__3214EC0732B9447E");

            entity.ToTable("configuration", "dss");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ConfigKey).HasMaxLength(100);
            entity.Property(e => e.ConfigValue).HasMaxLength(256);
            entity.Property(e => e.LastModified)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<EmailLog>(entity =>
        {
            entity.Property(e => e.Body).HasMaxLength(255);
            entity.Property(e => e.SendBy).HasMaxLength(255);
            entity.Property(e => e.SendFrom).HasMaxLength(255);
            entity.Property(e => e.SendTo).HasMaxLength(255);
            entity.Property(e => e.Subject).HasMaxLength(255);
        });

        modelBuilder.Entity<Entry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Entries__3214EC276A234091");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.Address1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Ein)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EntryStatusId).HasColumnName("EntryStatusID");
            entity.Property(e => e.ExternalNotes)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.InternalNotes)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PocEmail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PocFirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PocLastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PocPhoneNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PocTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RejectionReason)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.SubmissionDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ZohoTicketId)
                .HasMaxLength(25)
                .HasColumnName("ZohoTicketID");

            entity.HasOne(d => d.State).WithMany(p => p.Entries)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Entries_StateID");
        });

        modelBuilder.Entity<EntryStatusTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EntrySta__3214EC2778DF6B4D");

            entity.ToTable("EntryStatusTracking");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedBy).HasMaxLength(255);
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.EntryId).HasColumnName("EntryID");
            entity.Property(e => e.NewEntryStatusId).HasColumnName("NewEntryStatusID");
            entity.Property(e => e.OldEntryStatusId).HasColumnName("OldEntryStatusID");
            entity.Property(e => e.Role).HasMaxLength(25);

            entity.HasOne(d => d.Entry).WithMany(p => p.EntryStatusTrackings)
                .HasForeignKey(d => d.EntryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntryStatusTracking_EntryID");
        });

        modelBuilder.Entity<EnumType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EnumType__3214EC0722AC1444");

            entity.ToTable("EnumType", "dss");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LastModified)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FileModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Files__3214EC27E6E24DA3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.ContentType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EntryId).HasColumnName("EntryID");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Entry).WithMany(p => p.Files)
                .HasForeignKey(d => d.EntryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Files_EntryID");
        });

        modelBuilder.Entity<Form>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Forms__3214EC27BB5FE2BB");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.EntryId).HasColumnName("EntryID");
            entity.Property(e => e.FormTemplateId).HasColumnName("FormTemplateID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Entry).WithMany(p => p.Forms)
                .HasForeignKey(d => d.EntryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forms_EntryID");

            entity.HasOne(d => d.FormTemplate).WithMany(p => p.Forms)
                .HasForeignKey(d => d.FormTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forms_FormTemplateID");
        });

        modelBuilder.Entity<FormResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FormResp__3214EC27175BD260");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.Answer).IsUnicode(false);
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.PartId).HasColumnName("PartID");
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Form).WithMany(p => p.FormResponses)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormResponses_FormID");
        });

        modelBuilder.Entity<FormResponseChoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FormResp__3214EC2726D32332");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.AnswerChoiceId).HasColumnName("AnswerChoiceID");
            entity.Property(e => e.FormResponseId).HasColumnName("FormResponseID");

            entity.HasOne(d => d.FormResponse).WithMany(p => p.FormResponseChoices)
                .HasForeignKey(d => d.FormResponseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormResponseChoices_FormResponseID");
        });

        modelBuilder.Entity<FormResponseFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FormResp__3214EC27B8EE55A1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnName("FileID");
            entity.Property(e => e.FormResponseId).HasColumnName("FormResponseID");

            entity.HasOne(d => d.FileModel).WithMany(p => p.FormResponseFiles)
                .HasForeignKey(d => d.FileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormResponseFile_FileID");

            entity.HasOne(d => d.FormResponse).WithMany(p => p.FormResponseFiles)
                .HasForeignKey(d => d.FormResponseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormResponseFiles_FormResponseID");
        });

        modelBuilder.Entity<FormResponseRow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FormResp__3214EC2749EAE2BA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.Answer).IsUnicode(false);
            entity.Property(e => e.ColumnId).HasColumnName("ColumnID");
            entity.Property(e => e.FormResponseId).HasColumnName("FormResponseID");
            entity.Property(e => e.RowId).HasColumnName("RowID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.FormResponse).WithMany(p => p.FormResponseRows)
                .HasForeignKey(d => d.FormResponseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormResponseRows_FormResponseID");
        });

        modelBuilder.Entity<FormTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FormTemp__3214EC2775CD995E");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AddedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.RetiredDate).HasColumnType("datetime");
            entity.Property(e => e.SerializedFormTemplate).IsUnicode(false);
            entity.Property(e => e.TemplateTypeId).HasColumnName("TemplateTypeID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<HtmlText>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HtmlText__3214EC07174C01A2");

            entity.ToTable("HtmlText");

            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Html).HasColumnName("HTML");
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
        });


        modelBuilder.Entity<InstructionalMethod>(entity =>
        {
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.DisplayText).HasMaxLength(255);
            entity.Property(e => e.UpdateBy).HasMaxLength(255);
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PK__Job__056690C2E81B322D");

            entity.ToTable("Job", "TaskHosting");

            entity.HasIndex(e => e.IsCancelled, "index_job_iscancelled");

            entity.Property(e => e.JobId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InitialInsertTimeUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("InitialInsertTimeUTC");
        });

        modelBuilder.Entity<MessageQueue>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PK__MessageQ__C87C0C9C6BDFABD0");

            entity.ToTable("MessageQueue", "TaskHosting");

            entity.HasIndex(e => new { e.QueueId, e.UpdateTimeUtc, e.InsertTimeUtc, e.ExecTimes, e.Version }, "index_messagequeue_getnextmessage");

            entity.HasIndex(e => new { e.QueueId, e.MessageType, e.UpdateTimeUtc, e.InsertTimeUtc, e.ExecTimes, e.Version }, "index_messagequeue_getnextmessagebytype");

            entity.HasIndex(e => e.JobId, "index_messagequeue_jobid");

            entity.Property(e => e.MessageId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InitialInsertTimeUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("InitialInsertTimeUTC");
            entity.Property(e => e.InsertTimeUtc)
                .HasColumnType("datetime")
                .HasColumnName("InsertTimeUTC");
            entity.Property(e => e.UpdateTimeUtc)
                .HasColumnType("datetime")
                .HasColumnName("UpdateTimeUTC");

            entity.HasOne(d => d.Job).WithMany(p => p.MessageQueues)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__MessageQu__JobId__20B7BF83");
        });

        modelBuilder.Entity<MetaInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MetaInfo__3214EC0769EE8144");

            entity.ToTable("MetaInformation", "dss");

            entity.Property(e => e.State).HasDefaultValue(true);
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VersionString)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("1.0.0.0");
        });

       
        modelBuilder.Entity<MouModel>(entity =>
        {
            entity.Property(e => e.CreationDate).HasColumnName("Creation_Date");
            entity.Property(e => e.ExpirationDate).HasColumnName("Expiration_Date");
            entity.Property(e => e.ExtensionDate).HasColumnName("ExtensionDate");
            entity.Property(e => e.IsOsd).HasColumnName("Is_OSD");
            entity.Property(e => e.LegacyProviderId).HasColumnName("Legacy_Provider_Id");
            entity.Property(e => e.NotificationDate30Days).HasColumnType("datetime");
            entity.Property(e => e.NotificationDate60Days).HasColumnType("datetime");
            entity.Property(e => e.NotificationDate90Days).HasColumnType("datetime");
            entity.Property(e => e.OrganizationName).HasColumnName("Organization_Name");
            entity.Property(e => e.ZohoTicketId).HasMaxLength(255);
        });

        modelBuilder.Entity<MouFile>(entity =>
        {
            entity.Property(e => e.ContentType).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(255);

            entity.HasOne(d => d.MouModel).WithMany(p => p.MouFiles)
                .HasForeignKey(d => d.MouId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MouFiles_MouId");
        });

        modelBuilder.Entity<OpportunityModel>(entity =>
        {
            entity.Property(e => e.AdminPocEmail).HasColumnName("Admin_Poc_Email");
            entity.Property(e => e.AdminPocFirstName).HasColumnName("Admin_Poc_First_Name");
            entity.Property(e => e.AdminPocLastName).HasColumnName("Admin_Poc_Last_Name");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.DateCreated).HasColumnName("Date_Created");
            entity.Property(e => e.DateDeactivated).HasColumnName("Date_Deactivated");
            entity.Property(e => e.DateProgramInitiated).HasColumnName("Date_Program_Initiated");
            entity.Property(e => e.DateUpdated).HasColumnName("Date_Updated");
            entity.Property(e => e.DeliveryMethod).HasColumnName("Delivery_Method");
            entity.Property(e => e.EmployerPocEmail).HasColumnName("Employer_Poc_Email");
            entity.Property(e => e.EmployerPocName).HasColumnName("Employer_Poc_Name");
            entity.Property(e => e.EnrollmentDates).HasColumnName("Enrollment_Dates");
            entity.Property(e => e.ForSpouses).HasColumnName("For_Spouses");
            entity.Property(e => e.GroupId).HasColumnName("Group_Id");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.JobFamilies).HasColumnName("Job_Families");
            entity.Property(e => e.JobsDescription).HasColumnName("Jobs_Description");
            entity.Property(e => e.LegacyOpportunityId).HasColumnName("Legacy_Opportunity_Id");
            entity.Property(e => e.LegacyProgramId).HasColumnName("Legacy_Program_Id");
            entity.Property(e => e.LegacyProviderId).HasColumnName("Legacy_Provider_Id");
            entity.Property(e => e.LinksToProspectiveJobs).HasColumnName("Links_To_Prospective_Jobs");
            entity.Property(e => e.LocationsOfProspectiveJobsByState).HasColumnName("Locations_Of_Prospective_Jobs_By_State");
            entity.Property(e => e.MouExpirationDate).HasColumnName("Mou_Expiration_Date");
            entity.Property(e => e.MouLink).HasColumnName("Mou_Link");
            entity.Property(e => e.MultipleLocations).HasColumnName("Multiple_Locations");
            entity.Property(e => e.NumLocations).HasColumnName("Num_Locations");
            entity.Property(e => e.OpportunityUrl).HasColumnName("Opportunity_Url");
            entity.Property(e => e.OrganizationId).HasColumnName("Organization_Id");
            entity.Property(e => e.OrganizationName).HasColumnName("Organization_Name");
            entity.Property(e => e.OtherEligibilityFactors).HasColumnName("Other_Eligibility_Factors");
            entity.Property(e => e.ParticipationPopulations).HasColumnName("Participation_Populations");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
            entity.Property(e => e.ProgramName).HasColumnName("Program_Name");
            entity.Property(e => e.ProgramType).HasColumnName("Program_Type");
            entity.Property(e => e.ProspectiveJobLaborDemand).HasColumnName("Prospective_Job_Labor_Demand");
            entity.Property(e => e.SummaryDescription).HasColumnName("Summary_Description");
            entity.Property(e => e.SupportCohorts).HasColumnName("Support_Cohorts");
            entity.Property(e => e.TargetMocs).HasColumnName("Target_Mocs");
            entity.Property(e => e.TrainingDuration).HasColumnName("Training_Duration");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
        });

      

        modelBuilder.Entity<OrganizationModel>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.DateCreated).HasColumnName("Date_Created");
            entity.Property(e => e.DateDeactivated).HasColumnName("Date_Deactivated");
            entity.Property(e => e.DateUpdated).HasColumnName("Date_Updated");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.IsMouParent).HasColumnName("Is_MOU_Parent");
            entity.Property(e => e.LegacyMouId).HasColumnName("Legacy_MOU_Id");
            entity.Property(e => e.LegacyProviderId).HasColumnName("Legacy_Provider_Id");
            entity.Property(e => e.MouId).HasColumnName("Mou_Id");
            entity.Property(e => e.OrganizationType).HasColumnName("Organization_Type");
            entity.Property(e => e.OrganizationUrl).HasColumnName("Organization_Url");
            entity.Property(e => e.ParentOrganizationName).HasColumnName("Parent_Organization_Name");
            entity.Property(e => e.PocEmail).HasColumnName("Poc_Email");
            entity.Property(e => e.PocFirstName).HasColumnName("Poc_First_Name");
            entity.Property(e => e.PocLastName).HasColumnName("Poc_Last_Name");
            entity.Property(e => e.PocPhone).HasColumnName("Poc_Phone");
            entity.Property(e => e.StatesOfProgramDelivery).HasColumnName("States_Of_Program_Delivery");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
        });

        modelBuilder.Entity<OrganizationFile>(entity =>
        {
            entity.Property(e => e.ContentType).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(255);
            entity.Property(e => e.FileType).HasMaxLength(255);

            entity.HasOne(d => d.OrganizationModel).WithMany(p => p.OrganizationFiles)
                .HasForeignKey(d => d.OrganizationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrganizationFiles_OrganizationId");
        });

        modelBuilder.Entity<PendingOpportunityAddition>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.DateCreated).HasColumnName("Date_Created");
            entity.Property(e => e.DateProgramInitiated).HasColumnName("Date_Program_Initiated");
            entity.Property(e => e.DateUpdated).HasColumnName("Date_Updated");
            entity.Property(e => e.DeliveryMethod).HasColumnName("Delivery_Method");
            entity.Property(e => e.EmployerPocEmail).HasColumnName("Employer_Poc_Email");
            entity.Property(e => e.EmployerPocName).HasColumnName("Employer_Poc_Name");
            entity.Property(e => e.EnrollmentDates).HasColumnName("Enrollment_Dates");
            entity.Property(e => e.ForSpouses).HasColumnName("For_Spouses");
            entity.Property(e => e.GroupId).HasColumnName("Group_Id");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.JobFamilies).HasColumnName("Job_Families");
            entity.Property(e => e.JobsDescription).HasColumnName("Jobs_Description");
            entity.Property(e => e.LastAdminActionTime).HasColumnName("Last_Admin_Action_Time");
            entity.Property(e => e.LastAdminActionType)
                .HasMaxLength(10)
                .HasColumnName("Last_Admin_Action_Type");
            entity.Property(e => e.LastAdminActionUser)
                .HasMaxLength(100)
                .HasColumnName("Last_Admin_Action_User");
            entity.Property(e => e.LegacyOpportunityId).HasColumnName("Legacy_Opportunity_Id");
            entity.Property(e => e.LegacyProgramId).HasColumnName("Legacy_Program_Id");
            entity.Property(e => e.LegacyProviderId).HasColumnName("Legacy_Provider_Id");
            entity.Property(e => e.LinksToProspectiveJobs).HasColumnName("Links_To_Prospective_Jobs");
            entity.Property(e => e.LocationsOfProspectiveJobsByState).HasColumnName("Locations_Of_Prospective_Jobs_By_State");
            entity.Property(e => e.MultipleLocations).HasColumnName("Multiple_Locations");
            entity.Property(e => e.NumLocations).HasColumnName("Num_Locations");
            entity.Property(e => e.OpportunityId).HasColumnName("Opportunity_Id");
            entity.Property(e => e.OpportunityUrl).HasColumnName("Opportunity_Url");
            entity.Property(e => e.OrganizationId).HasColumnName("Organization_Id");
            entity.Property(e => e.OtherEligibilityFactors).HasColumnName("Other_Eligibility_Factors");
            entity.Property(e => e.ParticipationPopulations).HasColumnName("Participation_Populations");
            entity.Property(e => e.PendingChangeStatus).HasColumnName("Pending_Change_Status");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
            entity.Property(e => e.ProgramName).HasColumnName("Program_Name");
            entity.Property(e => e.ProgramType).HasColumnName("Program_Type");
            entity.Property(e => e.ProspectiveJobLaborDemand).HasColumnName("Prospective_Job_Labor_Demand");
            entity.Property(e => e.RejectionReason).HasColumnName("Rejection_Reason");
            entity.Property(e => e.RequiresOsdReview).HasColumnName("Requires_OSD_Review");
            entity.Property(e => e.SummaryDescription).HasColumnName("Summary_Description");
            entity.Property(e => e.SupportCohorts).HasColumnName("Support_Cohorts");
            entity.Property(e => e.TargetMocs).HasColumnName("Target_Mocs");
            entity.Property(e => e.TrainingDuration).HasColumnName("Training_Duration");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.Zip).HasMaxLength(5);
        });

        modelBuilder.Entity<PendingOpportunityChange>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.DateCreated).HasColumnName("Date_Created");
            entity.Property(e => e.DateProgramInitiated).HasColumnName("Date_Program_Initiated");
            entity.Property(e => e.DateUpdated).HasColumnName("Date_Updated");
            entity.Property(e => e.DeliveryMethod).HasColumnName("Delivery_Method");
            entity.Property(e => e.EmployerPocEmail).HasColumnName("Employer_Poc_Email");
            entity.Property(e => e.EmployerPocName).HasColumnName("Employer_Poc_Name");
            entity.Property(e => e.EnrollmentDates).HasColumnName("Enrollment_Dates");
            entity.Property(e => e.ForSpouses).HasColumnName("For_Spouses");
            entity.Property(e => e.GroupId).HasColumnName("Group_Id");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.JobFamilies).HasColumnName("Job_Families");
            entity.Property(e => e.JobsDescription).HasColumnName("Jobs_Description");
            entity.Property(e => e.LastAdminActionTime).HasColumnName("Last_Admin_Action_Time");
            entity.Property(e => e.LastAdminActionType)
                .HasMaxLength(10)
                .HasColumnName("Last_Admin_Action_Type");
            entity.Property(e => e.LastAdminActionUser)
                .HasMaxLength(100)
                .HasColumnName("Last_Admin_Action_User");
            entity.Property(e => e.LegacyOpportunityId).HasColumnName("Legacy_Opportunity_Id");
            entity.Property(e => e.LegacyProgramId).HasColumnName("Legacy_Program_Id");
            entity.Property(e => e.LegacyProviderId).HasColumnName("Legacy_Provider_Id");
            entity.Property(e => e.LinksToProspectiveJobs).HasColumnName("Links_To_Prospective_Jobs");
            entity.Property(e => e.LocationsOfProspectiveJobsByState).HasColumnName("Locations_Of_Prospective_Jobs_By_State");
            entity.Property(e => e.MultipleLocations).HasColumnName("Multiple_Locations");
            entity.Property(e => e.NumLocations).HasColumnName("Num_Locations");
            entity.Property(e => e.OpportunityId).HasColumnName("Opportunity_Id");
            entity.Property(e => e.OpportunityUrl).HasColumnName("Opportunity_Url");
            entity.Property(e => e.OrganizationId).HasColumnName("Organization_Id");
            entity.Property(e => e.OtherEligibilityFactors).HasColumnName("Other_Eligibility_Factors");
            entity.Property(e => e.ParticipationPopulations).HasColumnName("Participation_Populations");
            entity.Property(e => e.PendingChangeStatus).HasColumnName("Pending_Change_Status");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
            entity.Property(e => e.ProgramName).HasColumnName("Program_Name");
            entity.Property(e => e.ProgramType).HasColumnName("Program_Type");
            entity.Property(e => e.ProspectiveJobLaborDemand).HasColumnName("Prospective_Job_Labor_Demand");
            entity.Property(e => e.RejectionReason).HasColumnName("Rejection_Reason");
            entity.Property(e => e.RequiresOsdReview).HasColumnName("Requires_OSD_Review");
            entity.Property(e => e.SummaryDescription).HasColumnName("Summary_Description");
            entity.Property(e => e.SupportCohorts).HasColumnName("Support_Cohorts");
            entity.Property(e => e.TargetMocs).HasColumnName("Target_Mocs");
            entity.Property(e => e.TrainingDuration).HasColumnName("Training_Duration");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
            entity.Property(e => e.Zip).HasMaxLength(5);
        });

        modelBuilder.Entity<PendingOrganizationChange>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.DateCreated).HasColumnName("Date_Created");
            entity.Property(e => e.DateUpdated).HasColumnName("Date_Updated");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.LastAdminActionTime).HasColumnName("Last_Admin_Action_Time");
            entity.Property(e => e.LastAdminActionType)
                .HasMaxLength(10)
                .HasColumnName("Last_Admin_Action_Type");
            entity.Property(e => e.LastAdminActionUser)
                .HasMaxLength(100)
                .HasColumnName("Last_Admin_Action_User");
            entity.Property(e => e.LegacyProviderId).HasColumnName("Legacy_Provider_Id");
            entity.Property(e => e.OrganizationId).HasColumnName("Organization_Id");
            entity.Property(e => e.OrganizationType).HasColumnName("Organization_Type");
            entity.Property(e => e.OrganizationUrl).HasColumnName("Organization_Url");
            entity.Property(e => e.PendingChangeStatus).HasColumnName("Pending_Change_Status");
            entity.Property(e => e.PocEmail).HasColumnName("Poc_Email");
            entity.Property(e => e.PocFirstName).HasColumnName("Poc_First_Name");
            entity.Property(e => e.PocLastName).HasColumnName("Poc_Last_Name");
            entity.Property(e => e.PocPhone).HasColumnName("Poc_Phone");
            entity.Property(e => e.RejectionReason).HasColumnName("Rejection_Reason");
            entity.Property(e => e.RequiresOsdReview).HasColumnName("Requires_OSD_Review");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
        });

        modelBuilder.Entity<PendingProgramAddition>(entity =>
        {
            entity.Property(e => e.AdminPocEmail).HasColumnName("Admin_Poc_Email");
            entity.Property(e => e.AdminPocFirstName).HasColumnName("Admin_Poc_First_Name");
            entity.Property(e => e.AdminPocLastName).HasColumnName("Admin_Poc_Last_Name");
            entity.Property(e => e.AdminPocPhone).HasColumnName("Admin_Poc_Phone");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.DateAuthorized).HasColumnName("Date_Authorized");
            entity.Property(e => e.DateCreated).HasColumnName("Date_Created");
            entity.Property(e => e.DateUpdated).HasColumnName("Date_Updated");
            entity.Property(e => e.DeliveryMethod).HasColumnName("Delivery_Method");
            entity.Property(e => e.EnrollmentDates).HasColumnName("Enrollment_Dates");
            entity.Property(e => e.ForSpouses).HasColumnName("For_Spouses");
            entity.Property(e => e.HasConsent).HasColumnName("Has_Consent");
            entity.Property(e => e.HasIntake).HasColumnName("Has_Intake");
            entity.Property(e => e.HasMultipleLocations).HasColumnName("Has_Multiple_Locations");
            entity.Property(e => e.IntakeFormVersion).HasColumnName("Intake_Form_Version");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.JobFamily).HasColumnName("Job_Family");
            entity.Property(e => e.LastAdminActionTime).HasColumnName("Last_Admin_Action_Time");
            entity.Property(e => e.LastAdminActionType)
                .HasMaxLength(10)
                .HasColumnName("Last_Admin_Action_Type");
            entity.Property(e => e.LastAdminActionUser)
                .HasMaxLength(100)
                .HasColumnName("Last_Admin_Action_User");
            entity.Property(e => e.LegacyProgramId).HasColumnName("Legacy_Program_Id");
            entity.Property(e => e.LegacyProviderId).HasColumnName("Legacy_Provider_Id");
            entity.Property(e => e.LhnIntakeTicketId).HasColumnName("Lhn_Intake_Ticket_Id");
            entity.Property(e => e.LhnLocationTicketId).HasColumnName("Lhn_Location_Ticket_Id");
            entity.Property(e => e.LocationDetailsAvailable).HasColumnName("Location_Details_Available");
            entity.Property(e => e.MouCreationDate).HasColumnName("Mou_Creation_Date");
            entity.Property(e => e.MouExpirationDate).HasColumnName("Mou_Expiration_Date");
            entity.Property(e => e.MouLink).HasColumnName("Mou_Link");
            entity.Property(e => e.OpportunityType).HasColumnName("Opportunity_Type");
            entity.Property(e => e.OrganizationId).HasColumnName("Organization_Id");
            entity.Property(e => e.OrganizationName).HasColumnName("Organization_Name");
            entity.Property(e => e.ParticipationPopulations).HasColumnName("Participation_Populations");
            entity.Property(e => e.PendingChangeStatus).HasColumnName("Pending_Change_Status");
            entity.Property(e => e.ProgramDuration).HasColumnName("Program_Duration");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
            entity.Property(e => e.ProgramName).HasColumnName("Program_Name");
            entity.Property(e => e.ProgramStatus).HasColumnName("Program_Status");
            entity.Property(e => e.ProgramUrl).HasColumnName("Program_Url");
            entity.Property(e => e.PublicPocEmail).HasColumnName("Public_Poc_Email");
            entity.Property(e => e.PublicPocName).HasColumnName("Public_Poc_Name");
            entity.Property(e => e.QpIntakeSubmissionId).HasColumnName("Qp_Intake_Submission_Id");
            entity.Property(e => e.QpLocationSubmissionId).HasColumnName("Qp_Location_Submission_Id");
            entity.Property(e => e.RejectionReason).HasColumnName("Rejection_Reason");
            entity.Property(e => e.ReportingForm2020).HasColumnName("Reporting_Form_2020");
            entity.Property(e => e.RequiresOsdReview).HasColumnName("Requires_OSD_Review");
            entity.Property(e => e.ServicesSupported).HasColumnName("Services_Supported");
            entity.Property(e => e.StatesOfProgramDelivery).HasColumnName("States_Of_Program_Delivery");
            entity.Property(e => e.SupportCohorts).HasColumnName("Support_Cohorts");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
        });

        modelBuilder.Entity<PendingProgramAdditionsDeliveryMethod>(entity =>
        {
            entity.ToTable("PendingProgramAdditionsDeliveryMethod");

            entity.Property(e => e.DeliveryMethodId).HasColumnName("Delivery_Method_Id");
            entity.Property(e => e.PendingProgramId).HasColumnName("Pending_Program_Id");
        });

        modelBuilder.Entity<PendingProgramAdditionsJobFamily>(entity =>
        {
            entity.ToTable("PendingProgramAdditionsJobFamily");

            entity.Property(e => e.JobFamilyId).HasColumnName("Job_Family_Id");
            entity.Property(e => e.PendingProgramId).HasColumnName("Pending_Program_Id");
        });

        modelBuilder.Entity<PendingProgramAdditionsParticipationPopulation>(entity =>
        {
            entity.ToTable("PendingProgramAdditionsParticipationPopulation");

            entity.Property(e => e.ParticipationPopulationId).HasColumnName("Participation_Population_Id");
            entity.Property(e => e.PendingProgramId).HasColumnName("Pending_Program_Id");
        });

        modelBuilder.Entity<PendingProgramAdditionsService>(entity =>
        {
            entity.ToTable("PendingProgramAdditionsService");

            entity.Property(e => e.PendingProgramId).HasColumnName("Pending_Program_Id");
            entity.Property(e => e.ServiceId).HasColumnName("Service_Id");
        });

        modelBuilder.Entity<PendingProgramChange>(entity =>
        {
            entity.Property(e => e.AdminPocEmail).HasColumnName("Admin_Poc_Email");
            entity.Property(e => e.AdminPocFirstName).HasColumnName("Admin_Poc_First_Name");
            entity.Property(e => e.AdminPocLastName).HasColumnName("Admin_Poc_Last_Name");
            entity.Property(e => e.AdminPocPhone).HasColumnName("Admin_Poc_Phone");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.DateAuthorized).HasColumnName("Date_Authorized");
            entity.Property(e => e.DateCreated).HasColumnName("Date_Created");
            entity.Property(e => e.DateUpdated).HasColumnName("Date_Updated");
            entity.Property(e => e.DeliveryMethod).HasColumnName("Delivery_Method");
            entity.Property(e => e.EnrollmentDates).HasColumnName("Enrollment_Dates");
            entity.Property(e => e.ForSpouses).HasColumnName("For_Spouses");
            entity.Property(e => e.HasConsent).HasColumnName("Has_Consent");
            entity.Property(e => e.HasIntake).HasColumnName("Has_Intake");
            entity.Property(e => e.HasMultipleLocations).HasColumnName("Has_Multiple_Locations");
            entity.Property(e => e.IntakeFormVersion).HasColumnName("Intake_Form_Version");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.JobFamily).HasColumnName("Job_Family");
            entity.Property(e => e.LastAdminActionTime).HasColumnName("Last_Admin_Action_Time");
            entity.Property(e => e.LastAdminActionType)
                .HasMaxLength(10)
                .HasColumnName("Last_Admin_Action_Type");
            entity.Property(e => e.LastAdminActionUser)
                .HasMaxLength(100)
                .HasColumnName("Last_Admin_Action_User");
            entity.Property(e => e.LegacyProgramId).HasColumnName("Legacy_Program_Id");
            entity.Property(e => e.LegacyProviderId).HasColumnName("Legacy_Provider_Id");
            entity.Property(e => e.LhnIntakeTicketId).HasColumnName("Lhn_Intake_Ticket_Id");
            entity.Property(e => e.LhnLocationTicketId).HasColumnName("Lhn_Location_Ticket_Id");
            entity.Property(e => e.LocationDetailsAvailable).HasColumnName("Location_Details_Available");
            entity.Property(e => e.MouCreationDate).HasColumnName("Mou_Creation_Date");
            entity.Property(e => e.MouExpirationDate).HasColumnName("Mou_Expiration_Date");
            entity.Property(e => e.MouLink).HasColumnName("Mou_Link");
            entity.Property(e => e.OpportunityType).HasColumnName("Opportunity_Type");
            entity.Property(e => e.OrganizationId).HasColumnName("Organization_Id");
            entity.Property(e => e.OrganizationName).HasColumnName("Organization_Name");
            entity.Property(e => e.OtherDescription)
                .HasColumnType("text")
                .HasColumnName("Other_Description");
            entity.Property(e => e.ParticipationPopulations).HasColumnName("Participation_Populations");
            entity.Property(e => e.PendingChangeStatus).HasColumnName("Pending_Change_Status");
            entity.Property(e => e.ProgramDuration).HasColumnName("Program_Duration");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
            entity.Property(e => e.ProgramName).HasColumnName("Program_Name");
            entity.Property(e => e.ProgramStatus).HasColumnName("Program_Status");
            entity.Property(e => e.ProgramUrl).HasColumnName("Program_Url");
            entity.Property(e => e.PublicPocEmail).HasColumnName("Public_Poc_Email");
            entity.Property(e => e.PublicPocName).HasColumnName("Public_Poc_Name");
            entity.Property(e => e.QpIntakeSubmissionId).HasColumnName("Qp_Intake_Submission_Id");
            entity.Property(e => e.QpLocationSubmissionId).HasColumnName("Qp_Location_Submission_Id");
            entity.Property(e => e.RejectionReason).HasColumnName("Rejection_Reason");
            entity.Property(e => e.ReportingForm2020).HasColumnName("Reporting_Form_2020");
            entity.Property(e => e.RequiresOsdReview).HasColumnName("Requires_OSD_Review");
            entity.Property(e => e.ServicesSupported).HasColumnName("Services_Supported");
            entity.Property(e => e.StatesOfProgramDelivery).HasColumnName("States_Of_Program_Delivery");
            entity.Property(e => e.SupportCohorts).HasColumnName("Support_Cohorts");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");
        });

        modelBuilder.Entity<PendingProgramDeliveryMethod>(entity =>
        {
            entity.ToTable("PendingProgramDeliveryMethod");

            entity.Property(e => e.DeliveryMethodId).HasColumnName("Delivery_Method_Id");
            entity.Property(e => e.PendingProgramId).HasColumnName("Pending_Program_Id");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
        });

        modelBuilder.Entity<PendingProgramJobFamily>(entity =>
        {
            entity.ToTable("PendingProgramJobFamily");

            entity.Property(e => e.JobFamilyId).HasColumnName("Job_Family_Id");
            entity.Property(e => e.PendingProgramId).HasColumnName("Pending_Program_Id");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
        });

        modelBuilder.Entity<PendingProgramParticipationPopulation>(entity =>
        {
            entity.ToTable("PendingProgramParticipationPopulation");

            entity.Property(e => e.ParticipationPopulationId).HasColumnName("Participation_Population_Id");
            entity.Property(e => e.PendingProgramId).HasColumnName("Pending_Program_Id");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
        });

        modelBuilder.Entity<PendingProgramService>(entity =>
        {
            entity.ToTable("PendingProgramService");

            entity.Property(e => e.PendingProgramId).HasColumnName("Pending_Program_Id");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
            entity.Property(e => e.ServiceId).HasColumnName("Service_Id");
        });

        modelBuilder.Entity<PendingProgramServiceOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PendingProgramServiceOLD");

            entity.Property(e => e.PendingProgramId).HasColumnName("Pending_Program_Id");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
            entity.Property(e => e.ServiceId).HasColumnName("Service_Id");
        });

        modelBuilder.Entity<ProgramModel>(entity =>
        {
            entity.Property(e => e.AdminPocEmail).HasColumnName("Admin_Poc_Email");
            entity.Property(e => e.AdminPocFirstName).HasColumnName("Admin_Poc_First_Name");
            entity.Property(e => e.AdminPocLastName).HasColumnName("Admin_Poc_Last_Name");
            entity.Property(e => e.AdminPocPhone).HasColumnName("Admin_Poc_Phone");
            entity.Property(e => e.CreatedBy).HasColumnName("Created_By");
            entity.Property(e => e.DateAuthorized).HasColumnName("Date_Authorized");
            entity.Property(e => e.DateCreated).HasColumnName("Date_Created");
            entity.Property(e => e.DateDeactivated).HasColumnName("Date_Deactivated");
            entity.Property(e => e.DateUpdated).HasColumnName("Date_Updated");
            entity.Property(e => e.DeliveryMethod).HasColumnName("Delivery_Method");
            entity.Property(e => e.EnrollmentDates).HasColumnName("Enrollment_Dates");
            entity.Property(e => e.ForSpouses).HasColumnName("For_Spouses");
            entity.Property(e => e.HasConsent).HasColumnName("Has_Consent");
            entity.Property(e => e.HasIntake).HasColumnName("Has_Intake");
            entity.Property(e => e.HasMultipleLocations).HasColumnName("Has_Multiple_Locations");
            entity.Property(e => e.IntakeFormVersion).HasColumnName("Intake_Form_Version");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.JobFamily).HasColumnName("Job_Family");
            entity.Property(e => e.LegacyProgramId).HasColumnName("Legacy_Program_Id");
            entity.Property(e => e.LegacyProviderId).HasColumnName("Legacy_Provider_Id");
            entity.Property(e => e.LhnIntakeTicketId).HasColumnName("Lhn_Intake_Ticket_Id");
            entity.Property(e => e.LhnLocationTicketId).HasColumnName("Lhn_Location_Ticket_Id");
            entity.Property(e => e.LocationDetailsAvailable).HasColumnName("Location_Details_Available");
            entity.Property(e => e.MouCreationDate).HasColumnName("Mou_Creation_Date");
            entity.Property(e => e.MouExpirationDate).HasColumnName("Mou_Expiration_Date");
            entity.Property(e => e.MouLink).HasColumnName("Mou_Link");
            entity.Property(e => e.OpportunityType).HasColumnName("Opportunity_Type");
            entity.Property(e => e.OrganizationId).HasColumnName("Organization_Id");
            entity.Property(e => e.OrganizationName).HasColumnName("Organization_Name");
            entity.Property(e => e.OtherDescription)
                .HasColumnType("text")
                .HasColumnName("Other_Description");
            entity.Property(e => e.ParticipationPopulations).HasColumnName("Participation_Populations");
            entity.Property(e => e.ProgramDuration).HasColumnName("Program_Duration");
            entity.Property(e => e.ProgramName).HasColumnName("Program_Name");
            entity.Property(e => e.ProgramStatus).HasColumnName("Program_Status");
            entity.Property(e => e.ProgramUrl).HasColumnName("Program_Url");
            entity.Property(e => e.PublicPocEmail).HasColumnName("Public_Poc_Email");
            entity.Property(e => e.PublicPocName).HasColumnName("Public_Poc_Name");
            entity.Property(e => e.QpIntakeSubmissionId).HasColumnName("Qp_Intake_Submission_Id");
            entity.Property(e => e.QpLocationSubmissionId).HasColumnName("Qp_Location_Submission_Id");
            entity.Property(e => e.ReportingForm2020).HasColumnName("Reporting_Form_2020");
            entity.Property(e => e.ServicesSupported).HasColumnName("Services_Supported");
            entity.Property(e => e.StatesOfProgramDelivery).HasColumnName("States_Of_Program_Delivery");
            entity.Property(e => e.SupportCohorts).HasColumnName("Support_Cohorts");
            entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

            entity.HasOne(d => d.OrganizationModel).WithMany(p => p.Programs)
                .HasForeignKey(d => d.OrganizationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programs_Organization_Id");
        });

        modelBuilder.Entity<ProgramDeliveryMethod>(entity =>
        {
            entity.ToTable("ProgramDeliveryMethod");

            entity.Property(e => e.DeliveryMethodId).HasColumnName("Delivery_Method_Id");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
        });

        modelBuilder.Entity<ProgramJobFamily>(entity =>
        {
            entity.ToTable("ProgramJobFamily");

            entity.Property(e => e.JobFamilyId).HasColumnName("Job_Family_Id");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
        });

        modelBuilder.Entity<ProgramParticipationPopulation>(entity =>
        {
            entity.ToTable("ProgramParticipationPopulation");

            entity.Property(e => e.ParticipationPopulationId).HasColumnName("Participation_Population_Id");
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
        });

        modelBuilder.Entity<ProgramService>(entity =>
        {
            entity.ToTable("ProgramService");

            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
            entity.Property(e => e.ServiceId).HasColumnName("Service_Id");
        });

        modelBuilder.Entity<ProgramServiceOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProgramServiceOLD");

            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
            entity.Property(e => e.ServiceId).HasColumnName("Service_Id");
        });

        modelBuilder.Entity<ProgramState>(entity =>
        {
            entity.Property(e => e.ProgramId).HasColumnName("Program_Id");
            entity.Property(e => e.StateId).HasColumnName("State_Id");
        });

        modelBuilder.Entity<ProgramTrainingPlan>(entity =>
        {
            entity.Property(e => e.CreateBy).HasMaxLength(255);

            entity.HasOne(d => d.ProgramModel).WithMany(p => p.ProgramTrainingPlans)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProgramTrainingPlans_ProgramId");

            entity.HasOne(d => d.TrainingPlan).WithMany(p => p.ProgramTrainingPlans)
                .HasForeignKey(d => d.TrainingPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProgramTrainingPlans_TrainingPlanId");
        });

        modelBuilder.Entity<Qppdf>(entity =>
        {
            entity.ToTable("QPPdfs");

            entity.Property(e => e.FileName).HasMaxLength(255);
            entity.Property(e => e.ZohoTicketId).HasMaxLength(255);
        });

        modelBuilder.Entity<Qpresponse>(entity =>
        {
            entity.ToTable("QPResponses");

            entity.Property(e => e.ExternalReference).HasMaxLength(255);
            entity.Property(e => e.IpAddress).HasMaxLength(255);
            entity.Property(e => e.ResponseStatus).HasMaxLength(255);
            entity.Property(e => e.SurveyName).HasMaxLength(255);
            entity.Property(e => e.TimeStamp).HasMaxLength(255);
            entity.Property(e => e.ZohoTicketId).HasMaxLength(255);
        });

        modelBuilder.Entity<QpresponseQuestion>(entity =>
        {
            entity.ToTable("QPResponseQuestions");

            entity.Property(e => e.QuestionCode).HasMaxLength(255);
            entity.Property(e => e.QuestionDescription).HasMaxLength(255);
        });

        modelBuilder.Entity<QpresponseQuestionAnswer>(entity =>
        {
            entity.ToTable("QPResponseQuestionAnswers");

            entity.Property(e => e.ValueScale).HasMaxLength(255);
            entity.Property(e => e.ValueWeight).HasColumnType("decimal(4, 2)");
        });

        modelBuilder.Entity<Scaleunitlimit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__scaleuni__3214EC07BDC381AB");

            entity.ToTable("scaleunitlimits", "dss");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LastModified)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK__Schedule__9C8A5B4966A3BAF5");

            entity.ToTable("Schedule", "TaskHosting");
        });

        modelBuilder.Entity<ScheduleTask>(entity =>
        {
            entity.HasKey(e => e.SyncGroupId);

            entity.ToTable("ScheduleTask", "dss");

            entity.Property(e => e.SyncGroupId).ValueGeneratedNever();
            entity.Property(e => e.ExpirationTime).HasColumnType("datetime");
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");

            entity.HasOne(d => d.SyncGroup).WithOne(p => p.ScheduleTask)
                .HasForeignKey<ScheduleTask>(d => d.SyncGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ScheduleT__SyncG");
        });

        modelBuilder.Entity<ScheduleTask1>(entity =>
        {
            entity.HasKey(e => e.ScheduleTaskId).HasName("PK__Schedule__8DAD173AC8829423");

            entity.ToTable("ScheduleTask", "TaskHosting");

            entity.HasIndex(e => e.MessageId, "ScheduleTask_MessageId_Index");

            entity.Property(e => e.ScheduleTaskId).ValueGeneratedNever();
            entity.Property(e => e.NextRunTime).HasColumnType("datetime");
            entity.Property(e => e.TaskName).HasMaxLength(128);

            entity.HasOne(d => d.ScheduleNavigation).WithMany(p => p.ScheduleTask1s)
                .HasForeignKey(d => d.Schedule)
                .HasConstraintName("FK__ScheduleT__Sched__2B354DF6");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Name).HasMaxLength(20);
        });

        modelBuilder.Entity<SiteConfiguration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SiteConfiguration");

            entity.Property(e => e.NotificationHtml)
                .HasColumnType("text")
                .HasColumnName("NotificationHTML");
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__subscrip__3213E83F5D4D52C4");

            entity.ToTable("subscription", "dss");

            entity.HasIndex(e => e.Syncserveruniquename, "IX_SyncServerUniqueName")
                .IsUnique()
                .HasFilter("([syncserveruniquename] IS NOT NULL)");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Creationtime)
                .HasColumnType("datetime")
                .HasColumnName("creationtime");
            entity.Property(e => e.EnableDetailedProviderTracing).HasDefaultValue(false);
            entity.Property(e => e.Lastlogintime)
                .HasColumnType("datetime")
                .HasColumnName("lastlogintime");
            entity.Property(e => e.Name)
                .HasMaxLength(140)
                .HasColumnName("name");
            entity.Property(e => e.Policyid)
                .HasDefaultValue(0)
                .HasColumnName("policyid");
            entity.Property(e => e.Subscriptionstate).HasColumnName("subscriptionstate");
            entity.Property(e => e.Syncserveruniquename)
                .HasMaxLength(256)
                .HasColumnName("syncserveruniquename");
            entity.Property(e => e.Tombstoneretentionperiodindays).HasColumnName("tombstoneretentionperiodindays");
            entity.Property(e => e.Version)
                .HasMaxLength(40)
                .HasColumnName("version");
        });

        modelBuilder.Entity<SyncObjectDatum>(entity =>
        {
            entity.HasKey(e => new { e.ObjectId, e.DataType }).HasName("PK_SyncObjectExtInfo");

            entity.ToTable("SyncObjectData", "dss");

            entity.Property(e => e.CreatedTime).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.LastModified)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Syncgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__syncgrou__3213E83F458EB0DA");

            entity.ToTable("syncgroup", "dss");

            entity.HasIndex(e => e.HubMemberid, "index_syncgroup_hub_memberid");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.ConflictResolutionPolicy).HasColumnName("conflict_resolution_policy");
            entity.Property(e => e.ConflictTableRetentionInDays).HasDefaultValue(30);
            entity.Property(e => e.HubMemberid).HasColumnName("hub_memberid");
            entity.Property(e => e.Hubhasdata).HasColumnName("hubhasdata");
            entity.Property(e => e.Lastupdatetime)
                .HasColumnType("datetime")
                .HasColumnName("lastupdatetime");
            entity.Property(e => e.Name)
                .HasMaxLength(140)
                .HasColumnName("name");
            entity.Property(e => e.Ocsschemadefinition).HasColumnName("ocsschemadefinition");
            entity.Property(e => e.SchemaDescription)
                .HasColumnType("xml")
                .HasColumnName("schema_description");
            entity.Property(e => e.State)
                .HasDefaultValue(0)
                .HasColumnName("state");
            entity.Property(e => e.Subscriptionid).HasColumnName("subscriptionid");
            entity.Property(e => e.SyncEnabled)
                .HasDefaultValue(true)
                .HasColumnName("sync_enabled");
            entity.Property(e => e.SyncInterval).HasColumnName("sync_interval");

            entity.HasOne(d => d.HubMember).WithMany(p => p.Syncgroups)
                .HasForeignKey(d => d.HubMemberid)
                .HasConstraintName("FK__syncgroup__hub_m");

            entity.HasOne(d => d.Subscription).WithMany(p => p.Syncgroups)
                .HasForeignKey(d => d.Subscriptionid)
                .HasConstraintName("FK__syncgroup__subsc");
        });

        modelBuilder.Entity<Syncgroupmember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__syncgrou__3213E83FEED2D98F");

            entity.ToTable("syncgroupmember", "dss");

            entity.HasIndex(e => new { e.Syncgroupid, e.Databaseid }, "IX_SyncGroupMember_SyncGroupId_DatabaseId").IsUnique();

            entity.HasIndex(e => e.Databaseid, "index_syncgroupmember_databaseid");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Databaseid).HasColumnName("databaseid");
            entity.Property(e => e.HubJobId).HasColumnName("hubJobId");
            entity.Property(e => e.Hubstate).HasColumnName("hubstate");
            entity.Property(e => e.HubstateLastupdated)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("hubstate_lastupdated");
            entity.Property(e => e.JobId).HasColumnName("jobId");
            entity.Property(e => e.Lastsynctime)
                .HasColumnType("datetime")
                .HasColumnName("lastsynctime");
            entity.Property(e => e.LastsynctimeZerofailuresHub)
                .HasColumnType("datetime")
                .HasColumnName("lastsynctime_zerofailures_hub");
            entity.Property(e => e.LastsynctimeZerofailuresMember)
                .HasColumnType("datetime")
                .HasColumnName("lastsynctime_zerofailures_member");
            entity.Property(e => e.Memberhasdata).HasColumnName("memberhasdata");
            entity.Property(e => e.Memberstate).HasColumnName("memberstate");
            entity.Property(e => e.MemberstateLastupdated)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("memberstate_lastupdated");
            entity.Property(e => e.Name)
                .HasMaxLength(140)
                .HasColumnName("name");
            entity.Property(e => e.Noinitsync).HasColumnName("noinitsync");
            entity.Property(e => e.Scopename)
                .HasMaxLength(100)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("scopename");
            entity.Property(e => e.Syncdirection).HasColumnName("syncdirection");
            entity.Property(e => e.Syncgroupid).HasColumnName("syncgroupid");

            entity.HasOne(d => d.Database).WithMany(p => p.Syncgroupmembers)
                .HasForeignKey(d => d.Databaseid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__syncmember__datab");

            entity.HasOne(d => d.Syncgroup).WithMany(p => p.Syncgroupmembers)
                .HasForeignKey(d => d.Syncgroupid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__syncmember__syncg");
        });

        modelBuilder.Entity<TaskModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__task__3213E83FA6F54B62");

            entity.ToTable("task", "dss");

            entity.HasIndex(e => e.Actionid, "index_task_actionid");

            entity.HasIndex(e => new { e.Agentid, e.State }, "index_task_agentid_state").HasFilter("([state]=(0))");

            entity.HasIndex(e => e.CompletedTime, "index_task_completedtime");

            entity.HasIndex(e => new { e.State, e.Agentid, e.DependencyCount, e.Priority,
                Creationtime = e.CreationTime }, "index_task_gettask");

            entity.HasIndex(e => new { e.State, Completedtime = e.CompletedTime }, "index_task_state").HasFilter("([state]=(2))");

            entity.HasIndex(e => new { e.Lastheartbeat, e.State }, "index_task_state_lastheartbeat").HasFilter("([state]<(0))");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Actionid).HasColumnName("actionid");
            entity.Property(e => e.Agentid).HasColumnName("agentid");
            entity.Property(e => e.CompletedTime)
                .HasColumnType("datetime")
                .HasColumnName("completedtime");
            entity.Property(e => e.CreationTime)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("creationtime");
            entity.Property(e => e.DependencyCount).HasColumnName("dependency_count");
            entity.Property(e => e.Lastheartbeat)
                .HasColumnType("datetime")
                .HasColumnName("lastheartbeat");
            entity.Property(e => e.LastResetTime)
                .HasColumnType("datetime")
                .HasColumnName("lastresettime");
            entity.Property(e => e.OwningInstanceId).HasColumnName("owning_instanceid");
            entity.Property(e => e.PickupTime)
                .HasColumnType("datetime")
                .HasColumnName("pickuptime");
            entity.Property(e => e.Priority)
                .HasDefaultValue(100)
                .HasColumnName("priority");
            entity.Property(e => e.Request).HasColumnName("request");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.RetryCount).HasColumnName("retry_count");
            entity.Property(e => e.State)
                .HasDefaultValue(0)
                .HasColumnName("state");
            entity.Property(e => e.TaskNumber)
                .ValueGeneratedOnAdd()
                .HasColumnName("taskNumber");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Version).HasColumnName("version");

            //entity.HasOne(d => d.ActionModel).WithMany(p => p.TaskModels)
            //    .HasForeignKey(d => d.Actionid)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__task__actionid");

            entity.HasMany(d => d.NextTasks).WithMany(p => p.PrevTasks)
                .UsingEntity<Dictionary<string, object>>(
                    "Taskdependency",
                    r => r.HasOne<TaskModel>().WithMany()
                        .HasForeignKey("Nexttaskid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__taskdepen__nextt"),
                    l => l.HasOne<TaskModel>().WithMany()
                        .HasForeignKey("Prevtaskid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__taskdepen__prevt"),
                    j =>
                    {
                        j.HasKey("Nexttaskid", "Prevtaskid").HasName("PK_TaskTask");
                        j.ToTable("taskdependency", "dss");
                        j.IndexerProperty<Guid>("Nexttaskid").HasColumnName("nexttaskid");
                        j.IndexerProperty<Guid>("Prevtaskid").HasColumnName("prevtaskid");
                    });

            entity.HasMany(d => d.PrevTasks).WithMany(p => p.NextTasks)
                .UsingEntity<Dictionary<string, object>>(
                    "Taskdependency",
                    r => r.HasOne<TaskModel>().WithMany()
                        .HasForeignKey("Prevtaskid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__taskdepen__prevt"),
                    l => l.HasOne<TaskModel>().WithMany()
                        .HasForeignKey("Nexttaskid")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__taskdepen__nextt"),
                    j =>
                    {
                        j.HasKey("Nexttaskid", "Prevtaskid").HasName("PK_TaskTask");
                        j.ToTable("taskdependency", "dss");
                        j.IndexerProperty<Guid>("Nexttaskid").HasColumnName("nexttaskid");
                        j.IndexerProperty<Guid>("Prevtaskid").HasColumnName("prevtaskid");
                    });
        });

        modelBuilder.Entity<TrainingPlan>(entity =>
        {
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.JobTitle).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.UpdateBy).HasMaxLength(255);

            entity.HasOne(d => d.TrainingPlanLength).WithMany(p => p.TrainingPlans)
                .HasForeignKey(d => d.TrainingPlanLengthId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainingPlans_TrainingPlanLengthId");
        });

        modelBuilder.Entity<TrainingPlanBreakdown>(entity =>
        {
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.TotalHours).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.UpdateBy).HasMaxLength(255);

            entity.HasOne(d => d.TrainingPlan).WithMany(p => p.TrainingPlanBreakdowns)
                .HasForeignKey(d => d.TrainingPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainingPlanBreakdowns_TrainingPlanId");
        });

        modelBuilder.Entity<TrainingPlanInstructionalMethod>(entity =>
        {
            entity.Property(e => e.CreateBy).HasMaxLength(255);

            entity.HasOne(d => d.InstructionalMethod).WithMany(p => p.TrainingPlanInstructionalMethods)
                .HasForeignKey(d => d.InstructionalMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainingPlanInstructionalMethods_InstructionalMethodId");

            entity.HasOne(d => d.TrainingPlan).WithMany(p => p.TrainingPlanInstructionalMethods)
                .HasForeignKey(d => d.TrainingPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainingPlanInstructionalMethods_TrainingPlanId");
        });

        modelBuilder.Entity<TrainingPlanLength>(entity =>
        {
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.DisplayText).HasMaxLength(255);
            entity.Property(e => e.UpdateBy).HasMaxLength(255);
        });

        modelBuilder.Entity<Uihistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UIHistory", "dss");

            entity.HasIndex(e => e.Agentid, "Idx_UIHistory_AgentId");

            entity.HasIndex(e => e.CompletionTime, "Idx_UIHistory_CompletionTime");

            entity.HasIndex(e => e.Databaseid, "Idx_UIHistory_DatabaseId");

            entity.HasIndex(e => e.Id, "Idx_UIHistory_Id");

            entity.HasIndex(e => e.Serverid, "Idx_UIHistory_ServerId").IsClustered();

            entity.HasIndex(e => e.SyncgroupId, "Idx_UIHistory_SyncgroupId");

            entity.Property(e => e.Agentid).HasColumnName("agentid");
            entity.Property(e => e.CompletionTime).HasColumnName("completionTime");
            entity.Property(e => e.Databaseid).HasColumnName("databaseid");
            entity.Property(e => e.DetailEnumId)
                .HasMaxLength(400)
                .HasColumnName("detailEnumId");
            entity.Property(e => e.DetailStringParameters).HasColumnName("detailStringParameters");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsWritable)
                .HasDefaultValue(true)
                .HasColumnName("isWritable");
            entity.Property(e => e.RecordType).HasColumnName("recordType");
            entity.Property(e => e.Serverid).HasColumnName("serverid");
            entity.Property(e => e.SyncgroupId).HasColumnName("syncgroupId");
            entity.Property(e => e.TaskType).HasColumnName("taskType");
        });

        modelBuilder.Entity<Userdatabase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userdata__3213E83F9AB05994");

            entity.ToTable("userdatabase", "dss");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Agentid).HasColumnName("agentid");
            entity.Property(e => e.ConnectionString).HasColumnName("connection_string");
            entity.Property(e => e.Database)
                .HasMaxLength(256)
                .HasColumnName("database");
            entity.Property(e => e.DbSchema).HasColumnName("db_schema");
            entity.Property(e => e.IsOnPremise).HasColumnName("is_on_premise");
            entity.Property(e => e.JobId).HasColumnName("jobId");
            entity.Property(e => e.LastSchemaUpdated)
                .HasColumnType("datetime")
                .HasColumnName("last_schema_updated");
            entity.Property(e => e.LastTombstonecleanup)
                .HasColumnType("datetime")
                .HasColumnName("last_tombstonecleanup");
            entity.Property(e => e.Region)
                .HasMaxLength(256)
                .HasColumnName("region");
            entity.Property(e => e.Server)
                .HasMaxLength(256)
                .HasColumnName("server");
            entity.Property(e => e.SqlazureInfo)
                .HasColumnType("xml")
                .HasColumnName("sqlazure_info");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Subscriptionid).HasColumnName("subscriptionid");

            entity.HasOne(d => d.Subscription).WithMany(p => p.Userdatabases)
                .HasForeignKey(d => d.Subscriptionid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__userdatab__subsc");
        });

        modelBuilder.Entity<VChangeRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vChangeRequests");

            entity.Property(e => e.Change)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(100);
            entity.Property(e => e.Osd).HasColumnName("OSD");
            entity.Property(e => e.Status)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwQuestionProSummaryDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwQuestionProSummaryData");

            entity.Property(e => e.Pocemail).HasColumnName("POCEmail");
            entity.Property(e => e.Pocfirst).HasColumnName("POCFirst");
            entity.Property(e => e.Poclast).HasColumnName("POCLast");
            entity.Property(e => e.Pocphone).HasColumnName("POCPhone");
            entity.Property(e => e.PublicPocemail).HasColumnName("PublicPOCEmail");
            entity.Property(e => e.PublicPocfirst).HasColumnName("PublicPOCFirst");
            entity.Property(e => e.PublicPoclast).HasColumnName("PublicPOCLast");
            entity.Property(e => e.ResponseStatus).HasMaxLength(255);
            entity.Property(e => e.SpprogName).HasColumnName("SPProgName");
            entity.Property(e => e.TimeStamp).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

