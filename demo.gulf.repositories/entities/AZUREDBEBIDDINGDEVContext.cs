using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace demo.gulf.repositories.entities
{
    public partial class AZUREDBEBIDDINGDEVContext : DbContext
    {
        public AZUREDBEBIDDINGDEVContext()
        {
        }

        public AZUREDBEBIDDINGDEVContext(DbContextOptions<AZUREDBEBIDDINGDEVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }
        public virtual DbSet<Counter> Counters { get; set; }
        public virtual DbSet<Hash> Hashes { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobParameter> JobParameters { get; set; }
        public virtual DbSet<JobQueue> JobQueues { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<MstAttachmentType> MstAttachmentTypes { get; set; }
        public virtual DbSet<MstCategory> MstCategories { get; set; }
        public virtual DbSet<MstCommercialPrefix> MstCommercialPrefixes { get; set; }
        public virtual DbSet<MstCommercialType> MstCommercialTypes { get; set; }
        public virtual DbSet<MstCompany> MstCompanies { get; set; }
        public virtual DbSet<MstConfiguration> MstConfigurations { get; set; }
        public virtual DbSet<MstCountry> MstCountries { get; set; }
        public virtual DbSet<MstDepartment> MstDepartments { get; set; }
        public virtual DbSet<MstExchangRate> MstExchangRates { get; set; }
        public virtual DbSet<MstIncoTerm> MstIncoTerms { get; set; }
        public virtual DbSet<MstProcurementDepartment> MstProcurementDepartments { get; set; }
        public virtual DbSet<MstProjectWeight> MstProjectWeights { get; set; }
        public virtual DbSet<MstProvince> MstProvinces { get; set; }
        public virtual DbSet<MstPurchasingGroup> MstPurchasingGroups { get; set; }
        public virtual DbSet<MstRouteApproval> MstRouteApprovals { get; set; }
        public virtual DbSet<MstRouteProjectApproval> MstRouteProjectApprovals { get; set; }
        public virtual DbSet<MstSerwayForm> MstSerwayForms { get; set; }
        public virtual DbSet<MstSerwayList> MstSerwayLists { get; set; }
        public virtual DbSet<MstSubCategory> MstSubCategories { get; set; }
        public virtual DbSet<MstUnitOfMeasure> MstUnitOfMeasures { get; set; }
        public virtual DbSet<MstUser> MstUsers { get; set; }
        public virtual DbSet<MstUserCommittee> MstUserCommittees { get; set; }
        public virtual DbSet<MstVendorCriterion> MstVendorCriteria { get; set; }
        public virtual DbSet<Schema> Schemas { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<Set> Sets { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<TrnActionHistory> TrnActionHistories { get; set; }
        public virtual DbSet<TrnAttachment> TrnAttachments { get; set; }
        public virtual DbSet<TrnAuditLog> TrnAuditLogs { get; set; }
        public virtual DbSet<TrnProject> TrnProjects { get; set; }
        public virtual DbSet<TrnProjectApprover> TrnProjectApprovers { get; set; }
        public virtual DbSet<TrnProjectAttachment> TrnProjectAttachments { get; set; }
        public virtual DbSet<TrnProjectAttachmentOther> TrnProjectAttachmentOthers { get; set; }
        public virtual DbSet<TrnProjectAttachmentPreQualification> TrnProjectAttachmentPreQualifications { get; set; }
        public virtual DbSet<TrnProjectCommittee> TrnProjectCommittees { get; set; }
        public virtual DbSet<TrnProjectItemTemplate> TrnProjectItemTemplates { get; set; }
        public virtual DbSet<TrnProjectQa> TrnProjectQas { get; set; }
        public virtual DbSet<TrnProjectSelectVendor> TrnProjectSelectVendors { get; set; }
        public virtual DbSet<TrnProjectSelectVendorAttachment> TrnProjectSelectVendorAttachments { get; set; }
        public virtual DbSet<TrnProjectVendorCriterion> TrnProjectVendorCriteria { get; set; }
        public virtual DbSet<TrnProjectVendorSubmitAttachment> TrnProjectVendorSubmitAttachments { get; set; }
        public virtual DbSet<TrnProjectVendorSubmitItem> TrnProjectVendorSubmitItems { get; set; }
        public virtual DbSet<TrnProjectWeight> TrnProjectWeights { get; set; }
        public virtual DbSet<TrnSerwayD> TrnSerwayDs { get; set; }
        public virtual DbSet<TrnSerwayH> TrnSerwayHs { get; set; }
        public virtual DbSet<TrnSuportToken> TrnSuportTokens { get; set; }
        public virtual DbSet<TrnTmpVendorAccount> TrnTmpVendorAccounts { get; set; }
        public virtual DbSet<TrnTmpVendorAttachment> TrnTmpVendorAttachments { get; set; }
        public virtual DbSet<TrnTmpVendorCategory> TrnTmpVendorCategories { get; set; }
        public virtual DbSet<TrnTmpVendorInfo> TrnTmpVendorInfos { get; set; }
        public virtual DbSet<TrnTmpVendorLocation> TrnTmpVendorLocations { get; set; }
        public virtual DbSet<TrnVendorAccount> TrnVendorAccounts { get; set; }
        public virtual DbSet<TrnVendorAttachment> TrnVendorAttachments { get; set; }
        public virtual DbSet<TrnVendorCategory> TrnVendorCategories { get; set; }
        public virtual DbSet<TrnVendorInfo> TrnVendorInfos { get; set; }
        public virtual DbSet<TrnVendorLocation> TrnVendorLocations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:gulfazuredbserver.public.2b353710e0cd.database.windows.net,3342;Persist Security Info=False;User ID=ebiddingusrdev;Password=ebiddingusrdev@gu1f! ; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; Database=AZUREDB-EBIDDING-DEV; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key, "CX_HangFire_Counter")
                    .IsClustered();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameters)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstAttachmentType>(entity =>
            {
                entity.HasKey(e => e.AttachmentTypeId);

                entity.ToTable("MST_AttachmentType");

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstCategory>(entity =>
            {
                entity.ToTable("MST_Category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstCommercialPrefix>(entity =>
            {
                entity.ToTable("MST_CommercialPrefix");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommercialPrefixName).HasMaxLength(500);

                entity.Property(e => e.CommercialTypeId).HasColumnName("CommercialTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstCommercialType>(entity =>
            {
                entity.ToTable("MST_CommercialType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommercialTypeName).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK__MST_Comp__2D971C4CE60E054C");

                entity.ToTable("MST_Company");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyFullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstConfiguration>(entity =>
            {
                entity.HasKey(e => e.ConId);

                entity.ToTable("MST_Configuration");

                entity.Property(e => e.ConId).HasColumnName("ConID");

                entity.Property(e => e.ConKey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConValue)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstCountry>(entity =>
            {
                entity.ToTable("MST_Country");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstDepartment>(entity =>
            {
                entity.HasKey(e => e.DeaprtmentId)
                    .HasName("PK__MST_Depa__51A0769511276EF4");

                entity.ToTable("MST_Department");

                entity.Property(e => e.DeaprtmentId).HasColumnName("DeaprtmentID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstExchangRate>(entity =>
            {
                entity.HasKey(e => e.ExchId);

                entity.ToTable("MST_ExchangRate");

                entity.Property(e => e.ExchDate).HasColumnType("date");

                entity.Property(e => e.ExchOrderBy).HasDefaultValueSql("((9999))");

                entity.Property(e => e.Exchange)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<MstIncoTerm>(entity =>
            {
                entity.HasKey(e => e.IncoTermId);

                entity.ToTable("MST_IncoTerm");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstProcurementDepartment>(entity =>
            {
                entity.ToTable("MST_ProcurementDepartment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PrefixProjcetCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstProjectWeight>(entity =>
            {
                entity.HasKey(e => e.WeightId);

                entity.ToTable("MST_ProjectWeight");

                entity.Property(e => e.WeightId).HasColumnName("WeightID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstProvince>(entity =>
            {
                entity.ToTable("MST_Province");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<MstPurchasingGroup>(entity =>
            {
                entity.ToTable("MST_PurchasingGroup");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstRouteApproval>(entity =>
            {
                entity.ToTable("MST_RouteApproval");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Level1).HasMaxLength(50);

                entity.Property(e => e.Level2).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<MstRouteProjectApproval>(entity =>
            {
                entity.HasKey(e => new { e.RouteProjectApprovalId, e.ProcurementDeptId })
                    .HasName("PK_MST_ApprovalConfig");

                entity.ToTable("MST_RouteProjectApproval");

                entity.Property(e => e.RouteProjectApprovalId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RouteProjectApprovalID");

                entity.Property(e => e.ProcurementDeptId).HasColumnName("ProcurementDeptID");

                entity.Property(e => e.BudgetMax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BudgetMin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstSerwayForm>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("MST_SerwayForm");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SerwayFormName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstSerwayList>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("MST_SerwayList");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.ListDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ListRole)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListSubject)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ListTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstSubCategory>(entity =>
            {
                entity.ToTable("MST_SubCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MstUnitOfMeasure>(entity =>
            {
                entity.HasKey(e => e.UnitOfMeasureId);

                entity.ToTable("MST_UnitOfMeasure");

                entity.Property(e => e.UnitOfMeasureId).HasColumnName("UnitOfMeasureID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstUser>(entity =>
            {
                entity.ToTable("MST_User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcurementDeptId).HasColumnName("ProcurementDeptID");

                entity.Property(e => e.Role).HasMaxLength(5);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<MstUserCommittee>(entity =>
            {
                entity.ToTable("MST_UserCommittee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcurementDeptId).HasColumnName("ProcurementDeptID");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<MstVendorCriterion>(entity =>
            {
                entity.HasKey(e => e.VendorCriterialId);

                entity.ToTable("MST_VendorCriteria");

                entity.Property(e => e.VendorCriterialId).HasColumnName("VendorCriterialID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RefColum)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RefTable)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat, "IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => new { e.Key, e.Score }, "IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<TrnActionHistory>(entity =>
            {
                entity.ToTable("TRN_ActionHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionBy).HasMaxLength(50);

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Message).HasColumnType("ntext");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            });

            modelBuilder.Entity<TrnAttachment>(entity =>
            {
                entity.ToTable("TRN_Attachment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TrnAuditLog>(entity =>
            {
                entity.ToTable("TRN_AuditLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionBy).HasMaxLength(100);

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.EventName).HasMaxLength(500);

                entity.Property(e => e.Message).HasColumnType("ntext");

                entity.Property(e => e.ModuleName).HasMaxLength(500);
            });

            modelBuilder.Entity<TrnProject>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK_TRN_Project_1");

                entity.ToTable("TRN_Project");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ApprovalEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.Budget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ccmail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CCMail");

                entity.Property(e => e.Committee)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactAddressEmployer)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPointId).HasColumnName("ContactPointID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentRequest)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GeneralComment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsPocrequire).HasColumnName("IsPOCRequire");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NegotiationEnddate1).HasColumnType("datetime");

                entity.Property(e => e.NegotiationEnddate2).HasColumnType("datetime");

                entity.Property(e => e.NegotiationEnddate3).HasColumnType("datetime");

                entity.Property(e => e.NegotiationEnddate4).HasColumnType("datetime");

                entity.Property(e => e.NegotiationEnddate5).HasColumnType("datetime");

                entity.Property(e => e.NegotiationEnddate6).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcuementRemark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcurementTeam)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectDescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectOwnerId).HasColumnName("ProjectOwnerID");

                entity.Property(e => e.ProjectStatus)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Prpo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PRPO");

                entity.Property(e => e.PurchasingGroupId).HasColumnName("PurchasingGroupID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequesterEmail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrnProjectApprover>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.ApproverId });

                entity.ToTable("TRN_ProjectApprover");

                entity.Property(e => e.ApproverEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApproverName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrnProjectAttachment>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.Seq, e.AttachmentTypeId })
                    .HasName("PK_TRN_ProjectAttachment_1");

                entity.ToTable("TRN_ProjectAttachment");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.AttachmentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AttachmentID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.FileFullName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TrnProjectAttachmentOther>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.AttachmentTypeId, e.Seq });

                entity.ToTable("TRN_ProjectAttachmentOther");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.AttachmentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AttachmentID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.FileFullName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrnProjectAttachmentPreQualification>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.Seq, e.AttachmentTypeId })
                    .HasName("PK_TRN_ProjectAttachmentPreQualification_1");

                entity.ToTable("TRN_ProjectAttachmentPreQualification");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.AttachmentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AttachmentID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.FileFullName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TrnProjectCommittee>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.CommitteeId });

                entity.ToTable("TRN_ProjectCommittee");

                entity.Property(e => e.CommitteeEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CommitteeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsAttend).HasColumnName("IsAttend ");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrnProjectItemTemplate>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.CompanyId, e.Seq })
                    .HasName("PK_TRN_ProjectItemTemplate_1");

                entity.ToTable("TRN_ProjectItemTemplate");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectItemTemplateId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProjectItemTemplateID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitOfMeasureId).HasColumnName("UnitOfMeasureID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TrnProjectQa>(entity =>
            {
                entity.HasKey(e => new { e.ProjectQaid, e.ProjectId });

                entity.ToTable("TRN_ProjectQA");

                entity.Property(e => e.ProjectQaid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProjectQAID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TrnProjectSelectVendor>(entity =>
            {
                entity.HasKey(e => e.ProjectSelectVendorId);

                entity.ToTable("TRN_ProjectSelectVendor");

                entity.Property(e => e.ProjectSelectVendorId).HasColumnName("ProjectSelectVendorID");

                entity.Property(e => e.AdditionalInformation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AttachmentFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachmentPassword)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BiddingStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CalculatedScore).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Deviation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ExperiencyWtgulfWhileBid)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("ExperiencyWTGulfWhileBid");

                entity.Property(e => e.FirstOpenBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstOpenDate).HasColumnType("datetime");

                entity.Property(e => e.IsProcurementSubmitPo).HasColumnName("IsProcurementSubmitPO");

                entity.Property(e => e.IsVendorSubmitPo).HasColumnName("IsVendorSubmitPO");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OfferGrandTotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OtherFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherFilePassword)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PONumber");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProposalFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProposalPassword)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QuotationFilePassword)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TechnicalReviewRemark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TotalScore).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TrnProjectSelectVendorAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachId);

                entity.ToTable("TRN_ProjectSelectVendorAttachment");

                entity.HasIndex(e => new { e.ProjectId, e.VendorId }, "IX_TRN_ProjectSelectVendorAttachment")
                    .IsUnique();

                entity.Property(e => e.AttachId).HasColumnName("AttachID");

                entity.Property(e => e.AttachFilePo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFilePO");

                entity.Property(e => e.AttachFilePoname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFilePOName");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TrnProjectVendorCriterion>(entity =>
            {
                entity.HasKey(e => new { e.ProjectVendorCriteriaId, e.ProjectId, e.VendorCriteriaId });

                entity.ToTable("TRN_ProjectVendorCriteria");

                entity.Property(e => e.ProjectVendorCriteriaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProjectVendorCriteriaID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.VendorCriteriaId).HasColumnName("VendorCriteriaID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CriteriaRequired)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CriteriaValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            });

            modelBuilder.Entity<TrnProjectVendorSubmitAttachment>(entity =>
            {
                entity.HasKey(e => new { e.ProjectVendorSubmitAttachId, e.ProjectId, e.VendorId, e.Round });

                entity.ToTable("TRN_ProjectVendorSubmitAttachment");

                entity.Property(e => e.ProjectVendorSubmitAttachId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProjectVendorSubmitAttachID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.AttachFileBoq)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileBOQ");

                entity.Property(e => e.AttachFileBoqname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileBOQName");

                entity.Property(e => e.AttachFileBoqprice)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileBOQPrice");

                entity.Property(e => e.AttachFileBoqpriceName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileBOQPriceName");

                entity.Property(e => e.AttachFilePersonal)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachFilePersonalName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachFilePo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFilePO");

                entity.Property(e => e.AttachFilePoname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFilePOName");

                entity.Property(e => e.AttachFilePriceOfferConfirmation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachFilePriceOfferConfirmationName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachFileQuotation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachFileQuotationName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachFileSpec)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileSPEC");

                entity.Property(e => e.AttachFileSpecname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileSPECName");

                entity.Property(e => e.AttachFileTechnicalProposal)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachFileTechnicalProposalName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachFileTor)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileTOR");

                entity.Property(e => e.AttachFileTorname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileTORName");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrnProjectVendorSubmitItem>(entity =>
            {
                entity.HasKey(e => e.ProjectVendorSubmiItemId);

                entity.ToTable("TRN_ProjectVendorSubmitItem");

                entity.HasIndex(e => new { e.ProjectId, e.VendorId, e.ProjectItemTemplateId, e.Seq }, "IX_TRN_ProjectVendorSubmitItem")
                    .IsUnique();

                entity.Property(e => e.ProjectVendorSubmiItemId).HasColumnName("ProjectVendorSubmiItemID");

                entity.Property(e => e.AttachFileBoq)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileBOQ");

                entity.Property(e => e.AttachFileBoqname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileBOQName");

                entity.Property(e => e.AttachFileBoqprice)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileBOQPrice");

                entity.Property(e => e.AttachFileBoqpriceName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileBOQPriceName");

                entity.Property(e => e.AttachFilePersonal)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachFilePersonalName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachFileSpec)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileSPEC");

                entity.Property(e => e.AttachFileSpecname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileSPECName");

                entity.Property(e => e.AttachFileTor)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileTOR");

                entity.Property(e => e.AttachFileTorname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("AttachFileTORName");

                entity.Property(e => e.AttachFileqQuotation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachFileqQuotationName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AwardSuggestRemark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OfferUnitPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OfferUnitPriceRound2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OfferUnitPriceRound3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OfferUnitPriceRound4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OfferUnitPriceRound5).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OfferUnitPriceRound6).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectItemTemplateId).HasColumnName("ProjectItemTemplateID");

                entity.Property(e => e.RemarkNoOffer)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkNoOfferRound2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkNoOfferRound3)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkNoOfferRound4)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkNoOfferRound5)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkNoOfferRound6)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TrnProjectWeight>(entity =>
            {
                entity.HasKey(e => new { e.ProjectId, e.WeightId, e.Seq })
                    .HasName("PK_TRN_ProjectWeight_1");

                entity.ToTable("TRN_ProjectWeight");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.WeightId).HasColumnName("WeightID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProjectWeightId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProjectWeightID");
            });

            modelBuilder.Entity<TrnSerwayD>(entity =>
            {
                entity.HasKey(e => e.SerwayDid);

                entity.ToTable("TRN_SerwayD");

                entity.HasIndex(e => new { e.SerwayHid, e.ListId }, "IX_TRN_SerwayD")
                    .IsUnique();

                entity.Property(e => e.SerwayDid).HasColumnName("SerwayDID");

                entity.Property(e => e.Answers)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.ListRole)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SerwayBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SerwayDate).HasColumnType("datetime");

                entity.Property(e => e.SerwayHid).HasColumnName("SerwayHID");
            });

            modelBuilder.Entity<TrnSerwayH>(entity =>
            {
                entity.HasKey(e => e.SerwayHid);

                entity.ToTable("TRN_SerwayH");

                entity.HasIndex(e => new { e.ProjectId, e.VendorId }, "IX_TRN_SerwayH")
                    .IsUnique();

                entity.Property(e => e.SerwayHid).HasColumnName("SerwayHID");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductType).HasMaxLength(50);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.SerwayComment).HasMaxLength(500);

                entity.Property(e => e.SerweyCode).HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TrnSuportToken>(entity =>
            {
                entity.ToTable("TRN_SuportToken");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tokenstring)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrnTmpVendorAccount>(entity =>
            {
                entity.HasKey(e => e.TmpHistoryId)
                    .HasName("PK__TRN_TmpV__494C842F281FB972");

                entity.ToTable("TRN_TmpVendorAccount");

                entity.Property(e => e.ApprovalStatus).HasMaxLength(20);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastestLogin).HasColumnType("datetime");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsFixedLength();

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TrnTmpVendorAttachment>(entity =>
            {
                entity.HasKey(e => e.Idtmp)
                    .HasName("PK__TRN_TmpV__A70151C9D330BB20");

                entity.ToTable("TRN_TmpVendorAttachment");

                entity.Property(e => e.Idtmp).HasColumnName("IDTmp");

                entity.Property(e => e.AttachmentType).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TrnTmpVendorCategory>(entity =>
            {
                entity.HasKey(e => e.Idtmp)
                    .HasName("PK__TRN_TmpV__A70151C9896ACABB");

                entity.ToTable("TRN_TmpVendorCategory");

                entity.Property(e => e.Idtmp).HasColumnName("IDTmp");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TrnTmpVendorInfo>(entity =>
            {
                entity.HasKey(e => e.Idtmp)
                    .HasName("PK__TRN_TmpV__A70151C9DC4E8C18");

                entity.ToTable("TRN_TmpVendorInfo");

                entity.Property(e => e.Idtmp).HasColumnName("IDTmp");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(10)
                    .HasColumnName("BranchID");

                entity.Property(e => e.CertExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.CommercialPrefixId).HasColumnName("CommercialPrefixID");

                entity.Property(e => e.CommercialType).HasMaxLength(100);

                entity.Property(e => e.CommercialTypeId).HasColumnName("CommercialTypeID");

                entity.Property(e => e.CompanyCcEmail).HasMaxLength(100);

                entity.Property(e => e.CompanyContactPoint).HasMaxLength(500);

                entity.Property(e => e.CompanyContactPointTel).HasMaxLength(50);

                entity.Property(e => e.CompanyEstablishDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyNameEn).HasColumnName("CompanyNameEN");

                entity.Property(e => e.CompanyNameTh).HasColumnName("CompanyNameTH");

                entity.Property(e => e.CompanyTelephone).HasMaxLength(50);

                entity.Property(e => e.CompanyToEmail).HasMaxLength(100);

                entity.Property(e => e.CompanyTurnOver).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExperienceIn).HasMaxLength(100);

                entity.Property(e => e.ExperienceYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GulfContactPointId).HasColumnName("GulfContactPointID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isoname)
                    .HasMaxLength(500)
                    .HasColumnName("ISOName");

                entity.Property(e => e.LicenseName).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.RegisteredCapital).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SapAdr6SmtpAddr)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_ADR6_SMTP_ADDR");

                entity.Property(e => e.SapCity2)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_CITY2");

                entity.Property(e => e.SapCountry)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_COUNTRY");

                entity.Property(e => e.SapFaxNumber)
                    .HasMaxLength(200)
                    .HasColumnName("SAP_FAX_NUMBER");

                entity.Property(e => e.SapHouseNum1)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_HOUSE_NUM1");

                entity.Property(e => e.SapHouseNum2)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_HOUSE_NUM2");

                entity.Property(e => e.SapLangu)
                    .HasMaxLength(5)
                    .HasColumnName("SAP_LANGU");

                entity.Property(e => e.SapLocation)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_LOCATION");

                entity.Property(e => e.SapMobNumber)
                    .HasMaxLength(200)
                    .HasColumnName("SAP_MOB_NUMBER");

                entity.Property(e => e.SapPostCity1)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_POST_CITY1");

                entity.Property(e => e.SapPostCode1)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_POST_CODE1");

                entity.Property(e => e.SapStrSuppl1)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_STR_SUPPL1");

                entity.Property(e => e.SapStrSuppl2)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_STR_SUPPL2");

                entity.Property(e => e.SapStrSuppl3)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_STR_SUPPL3");

                entity.Property(e => e.SapStreet)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_STREET");

                entity.Property(e => e.SapTelNumber)
                    .HasMaxLength(200)
                    .HasColumnName("SAP_TEL_NUMBER");

                entity.Property(e => e.TaxId)
                    .HasMaxLength(50)
                    .HasColumnName("TaxID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TrnTmpVendorLocation>(entity =>
            {
                entity.HasKey(e => e.Idtmp)
                    .HasName("PK__TRN_TmpV__A70151C9DAF5031C");

                entity.ToTable("TRN_TmpVendorLocation");

                entity.Property(e => e.Idtmp).HasColumnName("IDTmp");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TrnVendorAccount>(entity =>
            {
                entity.ToTable("TRN_VendorAccount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovalStatus).HasMaxLength(20);

                entity.Property(e => e.LastestLogin).HasColumnType("datetime");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsFixedLength();

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TrnVendorAttachment>(entity =>
            {
                entity.ToTable("TRN_VendorAttachment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttachmentType).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TrnVendorCategory>(entity =>
            {
                entity.ToTable("TRN_VendorCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<TrnVendorInfo>(entity =>
            {
                entity.ToTable("TRN_VendorInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(10)
                    .HasColumnName("BranchID");

                entity.Property(e => e.CertExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.CommercialPrefixId).HasColumnName("CommercialPrefixID");

                entity.Property(e => e.CommercialType).HasMaxLength(100);

                entity.Property(e => e.CommercialTypeId).HasColumnName("CommercialTypeID");

                entity.Property(e => e.CompanyCcEmail).HasMaxLength(100);

                entity.Property(e => e.CompanyContactPoint).HasMaxLength(500);

                entity.Property(e => e.CompanyContactPointTel).HasMaxLength(50);

                entity.Property(e => e.CompanyEstablishDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyNameEn).HasColumnName("CompanyNameEN");

                entity.Property(e => e.CompanyNameTh).HasColumnName("CompanyNameTH");

                entity.Property(e => e.CompanyTelephone).HasMaxLength(50);

                entity.Property(e => e.CompanyToEmail).HasMaxLength(100);

                entity.Property(e => e.CompanyTurnOver).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExperienceIn).HasColumnType("ntext");

                entity.Property(e => e.ExperienceYear).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GulfContactPointId).HasColumnName("GulfContactPointID");

                entity.Property(e => e.Isoname)
                    .HasColumnType("ntext")
                    .HasColumnName("ISOName");

                entity.Property(e => e.LicenseName).HasColumnType("ntext");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Others).HasColumnType("ntext");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.RegisteredCapital).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SapAdr6SmtpAddr)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_ADR6_SMTP_ADDR");

                entity.Property(e => e.SapCity2)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_CITY2");

                entity.Property(e => e.SapCountry)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_COUNTRY");

                entity.Property(e => e.SapFaxNumber)
                    .HasMaxLength(200)
                    .HasColumnName("SAP_FAX_NUMBER");

                entity.Property(e => e.SapHouseNum1)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_HOUSE_NUM1");

                entity.Property(e => e.SapHouseNum2)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_HOUSE_NUM2");

                entity.Property(e => e.SapLangu)
                    .HasMaxLength(5)
                    .HasColumnName("SAP_LANGU");

                entity.Property(e => e.SapLocation)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_LOCATION");

                entity.Property(e => e.SapMobNumber)
                    .HasMaxLength(200)
                    .HasColumnName("SAP_MOB_NUMBER");

                entity.Property(e => e.SapPostCity1)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_POST_CITY1");

                entity.Property(e => e.SapPostCode1)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_POST_CODE1");

                entity.Property(e => e.SapStrSuppl1)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_STR_SUPPL1");

                entity.Property(e => e.SapStrSuppl2)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_STR_SUPPL2");

                entity.Property(e => e.SapStrSuppl3)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_STR_SUPPL3");

                entity.Property(e => e.SapStreet)
                    .HasMaxLength(500)
                    .HasColumnName("SAP_STREET");

                entity.Property(e => e.SapTelNumber)
                    .HasMaxLength(200)
                    .HasColumnName("SAP_TEL_NUMBER");

                entity.Property(e => e.TaxId)
                    .HasMaxLength(50)
                    .HasColumnName("TaxID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.VendorType).HasMaxLength(10);
            });

            modelBuilder.Entity<TrnVendorLocation>(entity =>
            {
                entity.ToTable("TRN_VendorLocation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
