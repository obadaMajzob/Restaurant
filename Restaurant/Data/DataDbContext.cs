//using System;
//using System.Collections.Generic;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using Restaurant.Models;

//namespace Restaurant.Data;

//public partial class DataDbContext : IdentityDbContext
//{


//    public DataDbContext(DbContextOptions<DataDbContext> options)
//        : base(options)
//    {
//    }

//    //public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

//    //public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

//    //public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

//    //public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

//    //public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

//    //public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

//    public virtual DbSet<MasterCategoryMenu> MasterCategoryMenus { get; set; }

//    public virtual DbSet<MasterContactUsInformation> MasterContactUsInformations { get; set; }

//    public virtual DbSet<MasterItemMenu> MasterItemMenus { get; set; }

//    public virtual DbSet<MasterMenu> MasterMenus { get; set; }

//    public virtual DbSet<MasterOffer> MasterOffers { get; set; }

//    public virtual DbSet<MasterPartner> MasterPartners { get; set; }

//    public virtual DbSet<MasterService> MasterServices { get; set; }

//    public virtual DbSet<MasterSlider> MasterSliders { get; set; }

//    public virtual DbSet<MasterSocialMedium> MasterSocialMedia { get; set; }

//    public virtual DbSet<MasterWorkingHour> MasterWorkingHours { get; set; }

//    public virtual DbSet<SystemSetting> SystemSettings { get; set; }

//    public virtual DbSet<TransactionBookTable> TransactionBookTables { get; set; }

//    public virtual DbSet<TransactionContactU> TransactionContactUs { get; set; }

//    public virtual DbSet<TransactionNewsletter> TransactionNewsletters { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-PTNSJIL\\SQL2022;Initial Catalog=Restaurant_System;User ID=sa;Password=123;Trust Server Certificate=True;Trusted_Connection=True");
//    //scaffold-dbcontext -provider Microsoft.EntityFrameworkCore.SqlServer -connection "Data Source=DESKTOP-PTNSJIL\\SQL2022;Initial Catalog=Restaurant_System;User ID=sa;Password=123;Trust Server Certificate=True;Trusted_Connection=True"  -OutputDir Models

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.UseCollation("Arabic_CI_AS");

//        //modelBuilder.Entity<AspNetRole>(entity =>
//        //{
//        //    entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
//        //        .IsUnique()
//        //        .HasFilter("([NormalizedName] IS NOT NULL)");

//        //    entity.Property(e => e.Name).HasMaxLength(256);
//        //    entity.Property(e => e.NormalizedName).HasMaxLength(256);
//        //});

//        //modelBuilder.Entity<AspNetRoleClaim>(entity =>
//        //{
//        //    entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

//        //    entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
//        //});

//        //modelBuilder.Entity<AspNetUser>(entity =>
//        //{
//        //    entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

//        //    entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
//        //        .IsUnique()
//        //        .HasFilter("([NormalizedUserName] IS NOT NULL)");

//        //    entity.Property(e => e.Email).HasMaxLength(256);
//        //    entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
//        //    entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
//        //    entity.Property(e => e.UserName).HasMaxLength(256);

//        //    entity.HasMany(d => d.Roles).WithMany(p => p.Users)
//        //        .UsingEntity<Dictionary<string, object>>(
//        //            "AspNetUserRole",
//        //            r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
//        //            l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
//        //            j =>
//        //            {
//        //                j.HasKey("UserId", "RoleId");
//        //                j.ToTable("AspNetUserRoles");
//        //                j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
//        //            });
//        //});

//        //modelBuilder.Entity<AspNetUserClaim>(entity =>
//        //{
//        //    entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

//        //    entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
//        //});

//        //modelBuilder.Entity<AspNetUserLogin>(entity =>
//        //{
//        //    entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

//        //    entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

//        //    entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
//        //});

//        //modelBuilder.Entity<AspNetUserToken>(entity =>
//        //{
//        //    entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

//        //    entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
//        //});

//        modelBuilder.Entity<MasterCategoryMenu>(entity =>
//        {
//            entity.ToTable("MasterCategoryMenu");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.MasterCategoryMenuName).HasMaxLength(3000);
//        });

//        modelBuilder.Entity<MasterContactUsInformation>(entity =>
//        {
//            entity.ToTable("MasterContactUsInformation");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.MasterContactUsInformationIdesc).HasColumnName("MasterContactUsInformationIDesc");
//        });

//        modelBuilder.Entity<MasterItemMenu>(entity =>
//        {
//            entity.ToTable("MasterItemMenu");

//            entity.HasIndex(e => e.MasterCategoryMenuId, "IX_MasterItemMenu_MasterCategoryMenuId");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.MasterItemMenuDate).HasColumnType("datetime");
//            entity.Property(e => e.MasterItemMenuPrice).HasColumnType("money");
//            entity.Property(e => e.MasterItemMenuTitle).HasMaxLength(3000);

//            entity.HasOne(d => d.MasterCategoryMenu).WithMany(p => p.MasterItemMenus)
//                .HasForeignKey(d => d.MasterCategoryMenuId)
//                .HasConstraintName("FK_MasterItemMenu_MasterCategoryMenu");
//        });

//        modelBuilder.Entity<MasterMenu>(entity =>
//        {
//            entity.ToTable("MasterMenu");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.MasterMenuName)
//                .HasMaxLength(1000)
//                .HasDefaultValue("");
//            entity.Property(e => e.MasterMenuUrl)
//                .HasMaxLength(1000)
//                .HasDefaultValue("");
//        });

//        modelBuilder.Entity<MasterOffer>(entity =>
//        {
//            entity.ToTable("MasterOffer");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//        });

//        modelBuilder.Entity<MasterPartner>(entity =>
//        {
//            entity.ToTable("MasterPartner");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.MasterPartnerName).HasMaxLength(1000);
//        });

//        modelBuilder.Entity<MasterService>(entity =>
//        {
//            entity.HasKey(e => e.Id);

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.MasterServicesTitle).HasMaxLength(3000);
//        });

//        modelBuilder.Entity<MasterSlider>(entity =>
//        {
//            entity.ToTable("MasterSlider");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.MasterSliderBreef).HasMaxLength(1000);
//            entity.Property(e => e.MasterSliderDesc).HasMaxLength(1000);
//            entity.Property(e => e.MasterSliderTitle).HasMaxLength(1000);
//        });

//        modelBuilder.Entity<MasterSocialMedium>(entity =>
//        {
//            entity.HasKey(e => e.Id);

//            entity.Property(e => e.Id).ValueGeneratedNever();
//        });

//        modelBuilder.Entity<MasterWorkingHour>(entity =>
//        {
//            entity.HasKey(e => e.Id);

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.MasterWorkingHoursIdName).HasMaxLength(1000);
//            entity.Property(e => e.MasterWorkingHoursIdTimeFormTo).HasMaxLength(3000);
//        });

//        modelBuilder.Entity<SystemSetting>(entity =>
//        {
//            entity.ToTable("SystemSetting");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//        });

//        modelBuilder.Entity<TransactionBookTable>(entity =>
//        {
//            entity.ToTable("TransactionBookTable");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.TransactionBookTableDate).HasColumnType("datetime");
//            entity.Property(e => e.TransactionBookTableEmail).HasMaxLength(1000);
//            entity.Property(e => e.TransactionBookTableFullName).HasMaxLength(1000);
//            entity.Property(e => e.TransactionBookTableMobileNumber).HasMaxLength(1000);
//        });

//        modelBuilder.Entity<TransactionContactU>(entity =>
//        {
//            entity.HasKey(e => e.Id);

//            entity.Property(e => e.Id)
//                .ValueGeneratedNever()
//                .HasColumnName("TransactionContactUsID");
//            entity.Property(e => e.TransactionContactUsEmail).HasMaxLength(1000);
//            entity.Property(e => e.TransactionContactUsFullName).HasMaxLength(1000);
//            entity.Property(e => e.TransactionContactUsSubject).HasMaxLength(1000);
//        });

//        modelBuilder.Entity<TransactionNewsletter>(entity =>
//        {
//            entity.ToTable("TransactionNewsletter");

//            entity.Property(e => e.Id).ValueGeneratedNever();
//            entity.Property(e => e.TransactionNewsletterEmail).HasMaxLength(1000);
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;

namespace Restaurant.Data;

public  class DataDbContext : IdentityDbContext
{
    public DataDbContext(DbContextOptions<DataDbContext> options)
        : base(options)
    {
    }

    public   DbSet<MasterCategoryMenu> MasterCategoryMenus { get; set; }
            
    public   DbSet<MasterContactUsInformation> MasterContactUsInformations { get; set; }
            
    public   DbSet<MasterItemMenu> MasterItemMenus { get; set; }
            
    public   DbSet<MasterMenu> MasterMenus { get; set; }
            
    public   DbSet<MasterOffer> MasterOffers { get; set; }
            
    public   DbSet<MasterPartner> MasterPartners { get; set; }
            
    public   DbSet<MasterService> MasterServices { get; set; }
            
    public   DbSet<MasterSlider> MasterSliders { get; set; }
            
    public   DbSet<MasterSocialMedium> MasterSocialMedia { get; set; }
            
    public   DbSet<MasterWorkingHour> MasterWorkingHours { get; set; }
            
    public   DbSet<SystemSetting> SystemSettings { get; set; }
            
    public   DbSet<TransactionBookTable> TransactionBookTables { get; set; }
            
    public   DbSet<TransactionContactU> TransactionContactUs { get; set; }
            
    public   DbSet<TransactionNewsletter> TransactionNewsletters { get; set; }


    public   DbSet<MasterClientsFeedback> MasterClientsFeedbacks { get; set; }
    public   DbSet<MasterAbout> MasterAbouts { get; set; }
  
}
