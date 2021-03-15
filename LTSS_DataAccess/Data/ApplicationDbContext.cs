using LTSS_Model.Models;
using LTSS_Model.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LTSS_DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        
        public DbSet<Option> Options { get; set; }

        //Change other name, Name conflict
        //public DbSet<Model> Models { get; set; }

        //public DbSet<F1> F1s { get; set; }
        //public  DbSet<F2> F2s { get; set; }
        //public  DbSet<I1> I1s { get; set; }

        //public  DbSet<ModelGroup> ModelGroups { get; set; }
        //public  DbSet<ModelOption> ModelOptions { get; set; }
        //public  DbSet<ModelTechDatum> ModelTechData { get; set; }
        //public  DbSet<ModelType> ModelTypes { get; set; }
        //public  DbSet<Option> Options { get; set; }
        //public  DbSet<OptionClass> OptionClasses { get; set; }
        //public  DbSet<OptionSelectable> OptionSelectables { get; set; }
        //public  DbSet<OptionTechDatum> OptionTechData { get; set; }
        //public  DbSet<Project> Projects { get; set; }
        //public  DbSet<T1> T1s { get; set; }
        //public  DbSet<T2> T2s { get; set; }
        //public  DbSet<Tag> Tags { get; set; }
        //public DbSet<TagDataType> TagDataTypes { get; set; }
        //public DbSet<TagDatum> TagData { get; set; }
        //public DbSet<TagModel> TagModels { get; set; }
        //public DbSet<TagModelConfig> TagModelConfigs { get; set; }
        //public DbSet<U1> U1s { get; set; }
        //public DbSet<Unit> Units { get; set; }
        //public DbSet<UnitType> UnitTypes { get; set; }
        //public DbSet<UserInfo> UserInfos { get; set; }
        //public DbSet<UserPreference> UserPreferences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Server=DESKTOP-50ER6G6\\SQLEXPRESS;Database=LTSS_dev;Trusted_Connection=True;MultipleActiveResultSets=true;");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            //    modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            //    modelBuilder.Entity<F1>(entity =>
            //    {
            //        entity.HasNoKey();

            //        entity.ToTable("f1");

            //        entity.Property(e => e.F10).HasColumnName("f10");

            //        entity.Property(e => e.F11).HasColumnName("f1");

            //        entity.Property(e => e.F111).HasColumnName("f11");

            //        entity.Property(e => e.F12).HasColumnName("f12");

            //        entity.Property(e => e.F13).HasColumnName("f13");

            //        entity.Property(e => e.F14).HasColumnName("f14");

            //        entity.Property(e => e.F15).HasColumnName("f15");

            //        entity.Property(e => e.F16).HasColumnName("f16");

            //        entity.Property(e => e.F17).HasColumnName("f17");

            //        entity.Property(e => e.F18).HasColumnName("f18");

            //        entity.Property(e => e.F19).HasColumnName("f19");

            //        entity.Property(e => e.F2).HasColumnName("f2");

            //        entity.Property(e => e.F20).HasColumnName("f20");

            //        entity.Property(e => e.F21).HasColumnName("f21");

            //        entity.Property(e => e.F22).HasColumnName("f22");

            //        entity.Property(e => e.F23).HasColumnName("f23");

            //        entity.Property(e => e.F24).HasColumnName("f24");

            //        entity.Property(e => e.F25).HasColumnName("f25");

            //        entity.Property(e => e.F26).HasColumnName("f26");

            //        entity.Property(e => e.F27).HasColumnName("f27");

            //        entity.Property(e => e.F28).HasColumnName("f28");

            //        entity.Property(e => e.F29).HasColumnName("f29");

            //        entity.Property(e => e.F3).HasColumnName("f3");

            //        entity.Property(e => e.F30).HasColumnName("f30");

            //        entity.Property(e => e.F31).HasColumnName("f31");

            //        entity.Property(e => e.F32).HasColumnName("f32");

            //        entity.Property(e => e.F33).HasColumnName("f33");

            //        entity.Property(e => e.F34).HasColumnName("f34");

            //        entity.Property(e => e.F35).HasColumnName("f35");

            //        entity.Property(e => e.F36).HasColumnName("f36");

            //        entity.Property(e => e.F37).HasColumnName("f37");

            //        entity.Property(e => e.F38).HasColumnName("f38");

            //        entity.Property(e => e.F39).HasColumnName("f39");

            //        entity.Property(e => e.F4).HasColumnName("f4");

            //        entity.Property(e => e.F40).HasColumnName("f40");

            //        entity.Property(e => e.F41).HasColumnName("f41");

            //        entity.Property(e => e.F42).HasColumnName("f42");

            //        entity.Property(e => e.F43).HasColumnName("f43");

            //        entity.Property(e => e.F44).HasColumnName("f44");

            //        entity.Property(e => e.F45).HasColumnName("f45");

            //        entity.Property(e => e.F46).HasColumnName("f46");

            //        entity.Property(e => e.F47).HasColumnName("f47");

            //        entity.Property(e => e.F48).HasColumnName("f48");

            //        entity.Property(e => e.F49).HasColumnName("f49");

            //        entity.Property(e => e.F5).HasColumnName("f5");

            //        entity.Property(e => e.F50).HasColumnName("f50");

            //        entity.Property(e => e.F51).HasColumnName("f51");

            //        entity.Property(e => e.F52).HasColumnName("f52");

            //        entity.Property(e => e.F53).HasColumnName("f53");

            //        entity.Property(e => e.F54).HasColumnName("f54");

            //        entity.Property(e => e.F55).HasColumnName("f55");

            //        entity.Property(e => e.F56).HasColumnName("f56");

            //        entity.Property(e => e.F57).HasColumnName("f57");

            //        entity.Property(e => e.F58).HasColumnName("f58");

            //        entity.Property(e => e.F59).HasColumnName("f59");

            //        entity.Property(e => e.F6).HasColumnName("f6");

            //        entity.Property(e => e.F60).HasColumnName("f60");

            //        entity.Property(e => e.F61).HasColumnName("f61");

            //        entity.Property(e => e.F62).HasColumnName("f62");

            //        entity.Property(e => e.F63).HasColumnName("f63");

            //        entity.Property(e => e.F64).HasColumnName("f64");

            //        entity.Property(e => e.F65).HasColumnName("f65");

            //        entity.Property(e => e.F66).HasColumnName("f66");

            //        entity.Property(e => e.F67).HasColumnName("f67");

            //        entity.Property(e => e.F68).HasColumnName("f68");

            //        entity.Property(e => e.F69).HasColumnName("f69");

            //        entity.Property(e => e.F7).HasColumnName("f7");

            //        entity.Property(e => e.F70).HasColumnName("f70");

            //        entity.Property(e => e.F71).HasColumnName("f71");

            //        entity.Property(e => e.F72).HasColumnName("f72");

            //        entity.Property(e => e.F73).HasColumnName("f73");

            //        entity.Property(e => e.F74).HasColumnName("f74");

            //        entity.Property(e => e.F75).HasColumnName("f75");

            //        entity.Property(e => e.F76).HasColumnName("f76");

            //        entity.Property(e => e.F77).HasColumnName("f77");

            //        entity.Property(e => e.F78).HasColumnName("f78");

            //        entity.Property(e => e.F79).HasColumnName("f79");

            //        entity.Property(e => e.F8).HasColumnName("f8");

            //        entity.Property(e => e.F80).HasColumnName("f80");

            //        entity.Property(e => e.F9).HasColumnName("f9");

            //        entity.Property(e => e.TagId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("tag_id");

            //        entity.HasOne(d => d.Tag)
            //            .WithMany()
            //            .HasForeignKey(d => d.TagId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_f1");
            //    });

            //    modelBuilder.Entity<F2>(entity =>
            //    {
            //        entity.HasNoKey();

            //        entity.ToTable("f2");

            //        entity.Property(e => e.F100).HasColumnName("f100");

            //        entity.Property(e => e.F101).HasColumnName("f101");

            //        entity.Property(e => e.F102).HasColumnName("f102");

            //        entity.Property(e => e.F103).HasColumnName("f103");

            //        entity.Property(e => e.F104).HasColumnName("f104");

            //        entity.Property(e => e.F105).HasColumnName("f105");

            //        entity.Property(e => e.F106).HasColumnName("f106");

            //        entity.Property(e => e.F107).HasColumnName("f107");

            //        entity.Property(e => e.F108).HasColumnName("f108");

            //        entity.Property(e => e.F109).HasColumnName("f109");

            //        entity.Property(e => e.F110).HasColumnName("f110");

            //        entity.Property(e => e.F111).HasColumnName("f111");

            //        entity.Property(e => e.F112).HasColumnName("f112");

            //        entity.Property(e => e.F113).HasColumnName("f113");

            //        entity.Property(e => e.F114).HasColumnName("f114");

            //        entity.Property(e => e.F115).HasColumnName("f115");

            //        entity.Property(e => e.F116).HasColumnName("f116");

            //        entity.Property(e => e.F117).HasColumnName("f117");

            //        entity.Property(e => e.F118).HasColumnName("f118");

            //        entity.Property(e => e.F119).HasColumnName("f119");

            //        entity.Property(e => e.F120).HasColumnName("f120");

            //        entity.Property(e => e.F121).HasColumnName("f121");

            //        entity.Property(e => e.F122).HasColumnName("f122");

            //        entity.Property(e => e.F123).HasColumnName("f123");

            //        entity.Property(e => e.F124).HasColumnName("f124");

            //        entity.Property(e => e.F125).HasColumnName("f125");

            //        entity.Property(e => e.F126).HasColumnName("f126");

            //        entity.Property(e => e.F127).HasColumnName("f127");

            //        entity.Property(e => e.F128).HasColumnName("f128");

            //        entity.Property(e => e.F129).HasColumnName("f129");

            //        entity.Property(e => e.F130).HasColumnName("f130");

            //        entity.Property(e => e.F131).HasColumnName("f131");

            //        entity.Property(e => e.F132).HasColumnName("f132");

            //        entity.Property(e => e.F133).HasColumnName("f133");

            //        entity.Property(e => e.F134).HasColumnName("f134");

            //        entity.Property(e => e.F135).HasColumnName("f135");

            //        entity.Property(e => e.F136).HasColumnName("f136");

            //        entity.Property(e => e.F137).HasColumnName("f137");

            //        entity.Property(e => e.F138).HasColumnName("f138");

            //        entity.Property(e => e.F139).HasColumnName("f139");

            //        entity.Property(e => e.F140).HasColumnName("f140");

            //        entity.Property(e => e.F141).HasColumnName("f141");

            //        entity.Property(e => e.F142).HasColumnName("f142");

            //        entity.Property(e => e.F143).HasColumnName("f143");

            //        entity.Property(e => e.F144).HasColumnName("f144");

            //        entity.Property(e => e.F145).HasColumnName("f145");

            //        entity.Property(e => e.F146).HasColumnName("f146");

            //        entity.Property(e => e.F147).HasColumnName("f147");

            //        entity.Property(e => e.F148).HasColumnName("f148");

            //        entity.Property(e => e.F149).HasColumnName("f149");

            //        entity.Property(e => e.F150).HasColumnName("f150");

            //        entity.Property(e => e.F151).HasColumnName("f151");

            //        entity.Property(e => e.F152).HasColumnName("f152");

            //        entity.Property(e => e.F153).HasColumnName("f153");

            //        entity.Property(e => e.F154).HasColumnName("f154");

            //        entity.Property(e => e.F155).HasColumnName("f155");

            //        entity.Property(e => e.F156).HasColumnName("f156");

            //        entity.Property(e => e.F157).HasColumnName("f157");

            //        entity.Property(e => e.F158).HasColumnName("f158");

            //        entity.Property(e => e.F159).HasColumnName("f159");

            //        entity.Property(e => e.F160).HasColumnName("f160");

            //        entity.Property(e => e.F81).HasColumnName("f81");

            //        entity.Property(e => e.F82).HasColumnName("f82");

            //        entity.Property(e => e.F83).HasColumnName("f83");

            //        entity.Property(e => e.F84).HasColumnName("f84");

            //        entity.Property(e => e.F85).HasColumnName("f85");

            //        entity.Property(e => e.F86).HasColumnName("f86");

            //        entity.Property(e => e.F87).HasColumnName("f87");

            //        entity.Property(e => e.F88).HasColumnName("f88");

            //        entity.Property(e => e.F89).HasColumnName("f89");

            //        entity.Property(e => e.F90).HasColumnName("f90");

            //        entity.Property(e => e.F91).HasColumnName("f91");

            //        entity.Property(e => e.F92).HasColumnName("f92");

            //        entity.Property(e => e.F93).HasColumnName("f93");

            //        entity.Property(e => e.F94).HasColumnName("f94");

            //        entity.Property(e => e.F95).HasColumnName("f95");

            //        entity.Property(e => e.F96).HasColumnName("f96");

            //        entity.Property(e => e.F97).HasColumnName("f97");

            //        entity.Property(e => e.F98).HasColumnName("f98");

            //        entity.Property(e => e.F99).HasColumnName("f99");

            //        entity.Property(e => e.TagId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("tag_id");

            //        entity.HasOne(d => d.Tag)
            //            .WithMany()
            //            .HasForeignKey(d => d.TagId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_f2");
            //    });

            //    modelBuilder.Entity<I1>(entity =>
            //    {
            //        entity.HasNoKey();

            //        entity.ToTable("i1");

            //        entity.Property(e => e.I10).HasColumnName("i10");

            //        entity.Property(e => e.I11).HasColumnName("i1");

            //        entity.Property(e => e.I111).HasColumnName("i11");

            //        entity.Property(e => e.I12).HasColumnName("i12");

            //        entity.Property(e => e.I13).HasColumnName("i13");

            //        entity.Property(e => e.I14).HasColumnName("i14");

            //        entity.Property(e => e.I15).HasColumnName("i15");

            //        entity.Property(e => e.I16).HasColumnName("i16");

            //        entity.Property(e => e.I17).HasColumnName("i17");

            //        entity.Property(e => e.I18).HasColumnName("i18");

            //        entity.Property(e => e.I19).HasColumnName("i19");

            //        entity.Property(e => e.I2).HasColumnName("i2");

            //        entity.Property(e => e.I20).HasColumnName("i20");

            //        entity.Property(e => e.I21).HasColumnName("i21");

            //        entity.Property(e => e.I22).HasColumnName("i22");

            //        entity.Property(e => e.I23).HasColumnName("i23");

            //        entity.Property(e => e.I24).HasColumnName("i24");

            //        entity.Property(e => e.I25).HasColumnName("i25");

            //        entity.Property(e => e.I26).HasColumnName("i26");

            //        entity.Property(e => e.I27).HasColumnName("i27");

            //        entity.Property(e => e.I28).HasColumnName("i28");

            //        entity.Property(e => e.I29).HasColumnName("i29");

            //        entity.Property(e => e.I3).HasColumnName("i3");

            //        entity.Property(e => e.I30).HasColumnName("i30");

            //        entity.Property(e => e.I31).HasColumnName("i31");

            //        entity.Property(e => e.I32).HasColumnName("i32");

            //        entity.Property(e => e.I33).HasColumnName("i33");

            //        entity.Property(e => e.I34).HasColumnName("i34");

            //        entity.Property(e => e.I35).HasColumnName("i35");

            //        entity.Property(e => e.I36).HasColumnName("i36");

            //        entity.Property(e => e.I37).HasColumnName("i37");

            //        entity.Property(e => e.I38).HasColumnName("i38");

            //        entity.Property(e => e.I39).HasColumnName("i39");

            //        entity.Property(e => e.I4).HasColumnName("i4");

            //        entity.Property(e => e.I40).HasColumnName("i40");

            //        entity.Property(e => e.I41).HasColumnName("i41");

            //        entity.Property(e => e.I42).HasColumnName("i42");

            //        entity.Property(e => e.I43).HasColumnName("i43");

            //        entity.Property(e => e.I44).HasColumnName("i44");

            //        entity.Property(e => e.I45).HasColumnName("i45");

            //        entity.Property(e => e.I46).HasColumnName("i46");

            //        entity.Property(e => e.I47).HasColumnName("i47");

            //        entity.Property(e => e.I48).HasColumnName("i48");

            //        entity.Property(e => e.I49).HasColumnName("i49");

            //        entity.Property(e => e.I5).HasColumnName("i5");

            //        entity.Property(e => e.I50).HasColumnName("i50");

            //        entity.Property(e => e.I51).HasColumnName("i51");

            //        entity.Property(e => e.I52).HasColumnName("i52");

            //        entity.Property(e => e.I53).HasColumnName("i53");

            //        entity.Property(e => e.I54).HasColumnName("i54");

            //        entity.Property(e => e.I55).HasColumnName("i55");

            //        entity.Property(e => e.I56).HasColumnName("i56");

            //        entity.Property(e => e.I57).HasColumnName("i57");

            //        entity.Property(e => e.I58).HasColumnName("i58");

            //        entity.Property(e => e.I59).HasColumnName("i59");

            //        entity.Property(e => e.I6).HasColumnName("i6");

            //        entity.Property(e => e.I60).HasColumnName("i60");

            //        entity.Property(e => e.I61).HasColumnName("i61");

            //        entity.Property(e => e.I62).HasColumnName("i62");

            //        entity.Property(e => e.I63).HasColumnName("i63");

            //        entity.Property(e => e.I64).HasColumnName("i64");

            //        entity.Property(e => e.I65).HasColumnName("i65");

            //        entity.Property(e => e.I66).HasColumnName("i66");

            //        entity.Property(e => e.I67).HasColumnName("i67");

            //        entity.Property(e => e.I68).HasColumnName("i68");

            //        entity.Property(e => e.I69).HasColumnName("i69");

            //        entity.Property(e => e.I7).HasColumnName("i7");

            //        entity.Property(e => e.I70).HasColumnName("i70");

            //        entity.Property(e => e.I71).HasColumnName("i71");

            //        entity.Property(e => e.I72).HasColumnName("i72");

            //        entity.Property(e => e.I73).HasColumnName("i73");

            //        entity.Property(e => e.I74).HasColumnName("i74");

            //        entity.Property(e => e.I75).HasColumnName("i75");

            //        entity.Property(e => e.I76).HasColumnName("i76");

            //        entity.Property(e => e.I77).HasColumnName("i77");

            //        entity.Property(e => e.I78).HasColumnName("i78");

            //        entity.Property(e => e.I79).HasColumnName("i79");

            //        entity.Property(e => e.I8).HasColumnName("i8");

            //        entity.Property(e => e.I80).HasColumnName("i80");

            //        entity.Property(e => e.I9).HasColumnName("i9");

            //        entity.Property(e => e.TagId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("tag_id");

            //        entity.HasOne(d => d.Tag)
            //            .WithMany()
            //            .HasForeignKey(d => d.TagId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_i1");
            //    });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.HasKey(e => e.ModelId);
                entity.ToTable("model");

                entity.HasIndex(e => new { e.ModelGroupId, e.ModelTypeId }, "ndx_model");

                entity.Property(e => e.ModelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("model_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.HasOptionFlag).HasColumnName("has_option_flag");

                entity.Property(e => e.ModelDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("model_desc");

                entity.Property(e => e.ModelGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("model_group_id");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("model_name")
                    .IsFixedLength(true);

                entity.Property(e => e.ModelTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("model_type_id");

                entity.Property(e => e.ObsoleteFlag).HasColumnName("obsolete_flag");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                //entity.HasOne(d => d.ModelGroup)
                //    .WithMany(p => p.Models)
                //    .HasForeignKey(d => d.ModelGroupId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("fk_model_2");

                //entity.HasOne(d => d.ModelType)
                //    .WithMany(p => p.Models)
                //    .HasForeignKey(d => d.ModelTypeId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("fk_model_1");
            });

            //    modelBuilder.Entity<ModelGroup>(entity =>
            //    {
            //        entity.ToTable("model_group");

            //        entity.Property(e => e.ModelGroupId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("model_group_id");

            //        entity.Property(e => e.ModelGroupDesc)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("model_group_desc");

            //        entity.Property(e => e.ModelGroupName)
            //            .IsRequired()
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("model_group_name")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.ModelTypeId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("model_type_id");

            //        entity.Property(e => e.SortOrder).HasColumnName("sort_order");

            //        entity.HasOne(d => d.ModelType)
            //            .WithMany(p => p.ModelGroups)
            //            .HasForeignKey(d => d.ModelTypeId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_model_group");
            //    });

            //    modelBuilder.Entity<ModelOption>(entity =>
            //    {
            //        entity.HasKey(e => new { e.ModelId, e.OptionId })
            //            .HasName("pk_model_option");

            //        entity.ToTable("model_option");

            //        entity.HasIndex(e => e.ModelId, "ndx_model_option");

            //        entity.Property(e => e.ModelId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("model_id");

            //        entity.Property(e => e.OptionId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("option_id");

            //        entity.HasOne(d => d.Model)
            //            .WithMany(p => p.ModelOptions)
            //            .HasForeignKey(d => d.ModelId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_model_option_1");

            //        entity.HasOne(d => d.Option)
            //            .WithMany(p => p.ModelOptions)
            //            .HasForeignKey(d => d.OptionId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_model_option_2");
            //    });

            //    modelBuilder.Entity<ModelTechDatum>(entity =>
            //    {
            //        entity.HasKey(e => new { e.ModelId, e.TechDataType })
            //            .HasName("pk_model_tech_data");

            //        entity.ToTable("model_tech_data");

            //        entity.Property(e => e.ModelId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("model_id");

            //        entity.Property(e => e.TechDataType).HasColumnName("tech_data_type");

            //        entity.Property(e => e.MaxValue).HasColumnName("max_value");

            //        entity.Property(e => e.MinValue).HasColumnName("min_value");

            //        entity.Property(e => e.Unit)
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("unit")
            //            .IsFixedLength(true);

            //        entity.HasOne(d => d.Model)
            //            .WithMany(p => p.ModelTechData)
            //            .HasForeignKey(d => d.ModelId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_model_tech_data");
            //    });

            //    modelBuilder.Entity<ModelType>(entity =>
            //    {
            //        entity.ToTable("model_type");

            //        entity.Property(e => e.ModelTypeId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("model_type_id");

            //        entity.Property(e => e.ModelTypeDesc)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("model_type_desc");

            //        entity.Property(e => e.ModelTypeName)
            //            .IsRequired()
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("model_type_name")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            //    });

            modelBuilder.Entity<Option>(entity =>
            {
                entity.ToTable("options");

                entity.HasIndex(e => e.OptionClassId, "ndx_options");

                entity.Property(e => e.OptionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("option_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.MsgEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("msg_end_date");

                entity.Property(e => e.MsgStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("msg_start_date");

                entity.Property(e => e.ObsoleteFlag).HasColumnName("obsolete_flag");

                entity.Property(e => e.OptionClassId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("option_class_id");

                entity.Property(e => e.OptionCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("option_code")
                    .IsFixedLength(true);

                entity.Property(e => e.OptionDesc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("option_desc")
                    .IsFixedLength(true);

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.SuggestionMsg)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("suggestion_msg");

                //entity.HasOne(d => d.OptionClass)
                //    .WithMany(p => p.Options)
                //    .HasForeignKey(d => d.OptionClassId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("fk_options");
            });

            //    modelBuilder.Entity<OptionClass>(entity =>
            //    {
            //        entity.ToTable("option_class");

            //        entity.HasIndex(e => e.ModelGroupId, "ndx_option_class");

            //        entity.Property(e => e.OptionClassId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("option_class_id");

            //        entity.Property(e => e.ModelGroupId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("model_group_id");

            //        entity.Property(e => e.OptionClassDesc)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("option_class_desc");

            //        entity.Property(e => e.OptionClassName)
            //            .IsRequired()
            //            .HasMaxLength(100)
            //            .IsUnicode(false)
            //            .HasColumnName("option_class_name")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.RequiredFlag).HasColumnName("required_flag");

            //        entity.Property(e => e.ShortName)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("short_name")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.SortOrder).HasColumnName("sort_order");

            //        entity.HasOne(d => d.ModelGroup)
            //            .WithMany(p => p.OptionClasses)
            //            .HasForeignKey(d => d.ModelGroupId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_option_class");
            //    });

            //    modelBuilder.Entity<OptionSelectable>(entity =>
            //    {
            //        entity.HasNoKey();

            //        entity.ToTable("option_selectable");

            //        entity.HasIndex(e => e.SelectableOptionId, "ndx_option_selectable");

            //        entity.Property(e => e.EndDate)
            //            .HasColumnType("datetime")
            //            .HasColumnName("end_date");

            //        entity.Property(e => e.OptionId1)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("option_id1");

            //        entity.Property(e => e.OptionId2)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("option_id2");

            //        entity.Property(e => e.OptionId3)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("option_id3");

            //        entity.Property(e => e.OptionId4)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("option_id4");

            //        entity.Property(e => e.SelectableFlag).HasColumnName("selectable_flag");

            //        entity.Property(e => e.SelectableOptionId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("selectable_option_id");

            //        entity.Property(e => e.StartDate)
            //            .HasColumnType("datetime")
            //            .HasColumnName("start_date");

            //        entity.HasOne(d => d.SelectableOption)
            //            .WithMany()
            //            .HasForeignKey(d => d.SelectableOptionId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_option_selectable");
            //    });

            //    modelBuilder.Entity<OptionTechDatum>(entity =>
            //    {
            //        entity.HasKey(e => new { e.OptionId1, e.OptionId2, e.OptionId3, e.TechDataType })
            //            .HasName("pk_option_tech_data");

            //        entity.ToTable("option_tech_data");

            //        entity.Property(e => e.OptionId1)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("option_id1");

            //        entity.Property(e => e.OptionId2)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("option_id2");

            //        entity.Property(e => e.OptionId3)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("option_id3");

            //        entity.Property(e => e.TechDataType).HasColumnName("tech_data_type");

            //        entity.Property(e => e.MaxValue).HasColumnName("max_value");

            //        entity.Property(e => e.MinValue).HasColumnName("min_value");

            //        entity.Property(e => e.Unit)
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("unit")
            //            .IsFixedLength(true);

            //        entity.HasOne(d => d.OptionId1Navigation)
            //            .WithMany(p => p.OptionTechData)
            //            .HasForeignKey(d => d.OptionId1)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_option_tech_data");
            //    });

            //    modelBuilder.Entity<Project>(entity =>
            //    {
            //        entity.ToTable("project");

            //        entity.HasIndex(e => e.UserId, "ndx_project");

            //        entity.Property(e => e.ProjectId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("project_id");

            //        entity.Property(e => e.ProjectDesc)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("project_desc");

            //        entity.Property(e => e.ProjectName)
            //            .IsRequired()
            //            .HasMaxLength(100)
            //            .IsUnicode(false)
            //            .HasColumnName("project_name")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.UserId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("user_id");

            //        entity.HasOne(d => d.User)
            //            .WithMany(p => p.Projects)
            //            .HasForeignKey(d => d.UserId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_project");
            //    });

            //    modelBuilder.Entity<T1>(entity =>
            //    {
            //        entity.HasNoKey();

            //        entity.ToTable("t1");

            //        entity.Property(e => e.T10)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t10");

            //        entity.Property(e => e.T11)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t1");

            //        entity.Property(e => e.T111)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t11");

            //        entity.Property(e => e.T12)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t12");

            //        entity.Property(e => e.T13)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t13");

            //        entity.Property(e => e.T14)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t14");

            //        entity.Property(e => e.T15)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t15");

            //        entity.Property(e => e.T16)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t16");

            //        entity.Property(e => e.T17)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t17");

            //        entity.Property(e => e.T18)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t18");

            //        entity.Property(e => e.T19)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t19");

            //        entity.Property(e => e.T2)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t2");

            //        entity.Property(e => e.T20)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t20");

            //        entity.Property(e => e.T21)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t21");

            //        entity.Property(e => e.T22)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t22");

            //        entity.Property(e => e.T23)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t23");

            //        entity.Property(e => e.T24)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t24");

            //        entity.Property(e => e.T25)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t25");

            //        entity.Property(e => e.T26)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t26");

            //        entity.Property(e => e.T27)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t27");

            //        entity.Property(e => e.T28)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t28");

            //        entity.Property(e => e.T29)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t29");

            //        entity.Property(e => e.T3)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t3");

            //        entity.Property(e => e.T30)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t30");

            //        entity.Property(e => e.T31)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t31");

            //        entity.Property(e => e.T32)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t32");

            //        entity.Property(e => e.T33)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t33");

            //        entity.Property(e => e.T34)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t34");

            //        entity.Property(e => e.T35)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t35");

            //        entity.Property(e => e.T36)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t36");

            //        entity.Property(e => e.T37)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t37");

            //        entity.Property(e => e.T38)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t38");

            //        entity.Property(e => e.T39)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t39");

            //        entity.Property(e => e.T4)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t4");

            //        entity.Property(e => e.T40)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t40");

            //        entity.Property(e => e.T41)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t41");

            //        entity.Property(e => e.T42)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t42");

            //        entity.Property(e => e.T43)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t43");

            //        entity.Property(e => e.T44)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t44");

            //        entity.Property(e => e.T45)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t45");

            //        entity.Property(e => e.T46)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t46");

            //        entity.Property(e => e.T47)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t47");

            //        entity.Property(e => e.T48)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t48");

            //        entity.Property(e => e.T49)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t49");

            //        entity.Property(e => e.T5)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t5");

            //        entity.Property(e => e.T50)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t50");

            //        entity.Property(e => e.T51)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t51");

            //        entity.Property(e => e.T52)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t52");

            //        entity.Property(e => e.T53)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t53");

            //        entity.Property(e => e.T54)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t54");

            //        entity.Property(e => e.T55)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t55");

            //        entity.Property(e => e.T56)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t56");

            //        entity.Property(e => e.T57)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t57");

            //        entity.Property(e => e.T58)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t58");

            //        entity.Property(e => e.T59)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t59");

            //        entity.Property(e => e.T6)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t6");

            //        entity.Property(e => e.T60)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t60");

            //        entity.Property(e => e.T61)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t61");

            //        entity.Property(e => e.T62)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t62");

            //        entity.Property(e => e.T63)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t63");

            //        entity.Property(e => e.T64)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t64");

            //        entity.Property(e => e.T65)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t65");

            //        entity.Property(e => e.T66)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t66");

            //        entity.Property(e => e.T67)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t67");

            //        entity.Property(e => e.T68)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t68");

            //        entity.Property(e => e.T69)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t69");

            //        entity.Property(e => e.T7)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t7");

            //        entity.Property(e => e.T70)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t70");

            //        entity.Property(e => e.T71)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t71");

            //        entity.Property(e => e.T72)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t72");

            //        entity.Property(e => e.T73)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t73");

            //        entity.Property(e => e.T74)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t74");

            //        entity.Property(e => e.T75)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t75");

            //        entity.Property(e => e.T76)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t76");

            //        entity.Property(e => e.T77)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t77");

            //        entity.Property(e => e.T78)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t78");

            //        entity.Property(e => e.T79)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t79");

            //        entity.Property(e => e.T8)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t8");

            //        entity.Property(e => e.T80)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t80");

            //        entity.Property(e => e.T9)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t9");

            //        entity.Property(e => e.TagId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("tag_id");

            //        entity.HasOne(d => d.Tag)
            //            .WithMany()
            //            .HasForeignKey(d => d.TagId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_t1");
            //    });

            //    modelBuilder.Entity<T2>(entity =>
            //    {
            //        entity.HasNoKey();

            //        entity.ToTable("t2");

            //        entity.Property(e => e.T100)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t100");

            //        entity.Property(e => e.T101)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t101");

            //        entity.Property(e => e.T102)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t102");

            //        entity.Property(e => e.T103)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t103");

            //        entity.Property(e => e.T104)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t104");

            //        entity.Property(e => e.T105)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t105");

            //        entity.Property(e => e.T106)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t106");

            //        entity.Property(e => e.T107)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t107");

            //        entity.Property(e => e.T108)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t108");

            //        entity.Property(e => e.T109)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t109");

            //        entity.Property(e => e.T110)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t110");

            //        entity.Property(e => e.T111)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t111");

            //        entity.Property(e => e.T112)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t112");

            //        entity.Property(e => e.T113)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t113");

            //        entity.Property(e => e.T114)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t114");

            //        entity.Property(e => e.T115)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t115");

            //        entity.Property(e => e.T116)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t116");

            //        entity.Property(e => e.T117)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t117");

            //        entity.Property(e => e.T118)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t118");

            //        entity.Property(e => e.T119)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t119");

            //        entity.Property(e => e.T120)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t120");

            //        entity.Property(e => e.T121)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t121");

            //        entity.Property(e => e.T122)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t122");

            //        entity.Property(e => e.T123)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t123");

            //        entity.Property(e => e.T124)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t124");

            //        entity.Property(e => e.T125)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t125");

            //        entity.Property(e => e.T126)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t126");

            //        entity.Property(e => e.T127)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t127");

            //        entity.Property(e => e.T128)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t128");

            //        entity.Property(e => e.T129)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t129");

            //        entity.Property(e => e.T130)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t130");

            //        entity.Property(e => e.T131)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t131");

            //        entity.Property(e => e.T132)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t132");

            //        entity.Property(e => e.T133)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t133");

            //        entity.Property(e => e.T134)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t134");

            //        entity.Property(e => e.T135)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t135");

            //        entity.Property(e => e.T136)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t136");

            //        entity.Property(e => e.T137)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t137");

            //        entity.Property(e => e.T138)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t138");

            //        entity.Property(e => e.T139)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t139");

            //        entity.Property(e => e.T140)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t140");

            //        entity.Property(e => e.T141)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t141");

            //        entity.Property(e => e.T142)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t142");

            //        entity.Property(e => e.T143)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t143");

            //        entity.Property(e => e.T144)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t144");

            //        entity.Property(e => e.T145)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t145");

            //        entity.Property(e => e.T146)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t146");

            //        entity.Property(e => e.T147)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t147");

            //        entity.Property(e => e.T148)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t148");

            //        entity.Property(e => e.T149)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t149");

            //        entity.Property(e => e.T150)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t150");

            //        entity.Property(e => e.T151)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t151");

            //        entity.Property(e => e.T152)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t152");

            //        entity.Property(e => e.T153)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t153");

            //        entity.Property(e => e.T154)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t154");

            //        entity.Property(e => e.T155)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t155");

            //        entity.Property(e => e.T156)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t156");

            //        entity.Property(e => e.T157)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t157");

            //        entity.Property(e => e.T158)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t158");

            //        entity.Property(e => e.T159)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t159");

            //        entity.Property(e => e.T160)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t160");

            //        entity.Property(e => e.T81)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t81");

            //        entity.Property(e => e.T82)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t82");

            //        entity.Property(e => e.T83)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t83");

            //        entity.Property(e => e.T84)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t84");

            //        entity.Property(e => e.T85)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t85");

            //        entity.Property(e => e.T86)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t86");

            //        entity.Property(e => e.T87)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t87");

            //        entity.Property(e => e.T88)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t88");

            //        entity.Property(e => e.T89)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t89");

            //        entity.Property(e => e.T90)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t90");

            //        entity.Property(e => e.T91)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t91");

            //        entity.Property(e => e.T92)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t92");

            //        entity.Property(e => e.T93)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t93");

            //        entity.Property(e => e.T94)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t94");

            //        entity.Property(e => e.T95)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t95");

            //        entity.Property(e => e.T96)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t96");

            //        entity.Property(e => e.T97)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t97");

            //        entity.Property(e => e.T98)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t98");

            //        entity.Property(e => e.T99)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("t99");

            //        entity.Property(e => e.TagId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("tag_id");

            //        entity.HasOne(d => d.Tag)
            //            .WithMany()
            //            .HasForeignKey(d => d.TagId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_t2");
            //    });

            //    modelBuilder.Entity<Tag>(entity =>
            //    {
            //        entity.ToTable("tag");

            //        entity.HasIndex(e => new { e.UserId, e.ProjectId }, "ndx_tag");

            //        entity.HasIndex(e => new { e.TagName, e.ProjectId }, "uk_tag")
            //            .IsUnique();

            //        entity.Property(e => e.TagId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("tag_id");

            //        entity.Property(e => e.ProjectId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("project_id");

            //        entity.Property(e => e.TagDesc)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("tag_desc");

            //        entity.Property(e => e.TagName)
            //            .IsRequired()
            //            .HasMaxLength(100)
            //            .IsUnicode(false)
            //            .HasColumnName("tag_name")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.TagNote)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("tag_note");

            //        entity.Property(e => e.UserId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("user_id");

            //        entity.HasOne(d => d.Project)
            //            .WithMany(p => p.Tags)
            //            .HasForeignKey(d => d.ProjectId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_tag_2");

            //        entity.HasOne(d => d.User)
            //            .WithMany(p => p.Tags)
            //            .HasForeignKey(d => d.UserId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_tag_1");
            //    });

            //    modelBuilder.Entity<TagDataType>(entity =>
            //    {
            //        entity.HasKey(e => e.DataTypeId)
            //            .HasName("pk_tag_data_type");

            //        entity.ToTable("tag_data_type");

            //        entity.Property(e => e.DataTypeId)
            //            .ValueGeneratedNever()
            //            .HasColumnName("data_type_id");

            //        entity.Property(e => e.DataTypeDesc)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("data_type_desc");

            //        entity.Property(e => e.DataTypeName)
            //            .IsRequired()
            //            .HasMaxLength(100)
            //            .IsUnicode(false)
            //            .HasColumnName("data_type_name")
            //            .IsFixedLength(true);
            //    });

            //    modelBuilder.Entity<TagDatum>(entity =>
            //    {
            //        entity.HasKey(e => new { e.TagId, e.DataTypeId })
            //            .HasName("pk_tag_data");

            //        entity.ToTable("tag_data");

            //        entity.Property(e => e.TagId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("tag_id");

            //        entity.Property(e => e.DataTypeId).HasColumnName("data_type_id");

            //        entity.Property(e => e.DesignValue).HasColumnName("design_value");

            //        entity.Property(e => e.MaxValue).HasColumnName("max_value");

            //        entity.Property(e => e.MinValue).HasColumnName("min_value");

            //        entity.Property(e => e.NormalValue).HasColumnName("normal_value");

            //        entity.Property(e => e.Unit)
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("unit");

            //        entity.HasOne(d => d.DataType)
            //            .WithMany(p => p.TagData)
            //            .HasForeignKey(d => d.DataTypeId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_tag_data_2");

            //        entity.HasOne(d => d.Tag)
            //            .WithMany(p => p.TagData)
            //            .HasForeignKey(d => d.TagId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_tag_data_1");
            //    });

            //    modelBuilder.Entity<TagModel>(entity =>
            //    {
            //        entity.HasKey(e => new { e.TagId, e.ModelId })
            //            .HasName("pk_tag_model");

            //        entity.ToTable("tag_model");

            //        entity.Property(e => e.TagId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("tag_id");

            //        entity.Property(e => e.ModelId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("model_id");

            //        entity.Property(e => e.HasOptionFlag).HasColumnName("has_option_flag");

            //        entity.Property(e => e.ModelString)
            //            .HasMaxLength(127)
            //            .IsUnicode(false)
            //            .HasColumnName("model_string")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.SortOrder).HasColumnName("sort_order");

            //        entity.HasOne(d => d.Model)
            //            .WithMany(p => p.TagModels)
            //            .HasForeignKey(d => d.ModelId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_tag_model_2");

            //        entity.HasOne(d => d.Tag)
            //            .WithMany(p => p.TagModels)
            //            .HasForeignKey(d => d.TagId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_tag_model_1");
            //    });

            //    modelBuilder.Entity<TagModelConfig>(entity =>
            //    {
            //        entity.HasKey(e => new { e.TagId, e.ModelId, e.OptionClassId })
            //            .HasName("pk_tag_model_config");

            //        entity.ToTable("tag_model_config");

            //        entity.HasIndex(e => new { e.TagId, e.ModelId, e.OptionId }, "uk_tag_model_config")
            //            .IsUnique();

            //        entity.Property(e => e.TagId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("tag_id");

            //        entity.Property(e => e.ModelId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("model_id");

            //        entity.Property(e => e.OptionClassId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("option_class_id");

            //        entity.Property(e => e.OptionCode)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("option_code")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.OptionId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("option_id");

            //        entity.Property(e => e.SortOrder).HasColumnName("sort_order");

            //        entity.HasOne(d => d.Model)
            //            .WithMany(p => p.TagModelConfigs)
            //            .HasForeignKey(d => d.ModelId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_tag_model_config_2");

            //        entity.HasOne(d => d.OptionClass)
            //            .WithMany(p => p.TagModelConfigs)
            //            .HasForeignKey(d => d.OptionClassId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_tag_model_config_3");

            //        entity.HasOne(d => d.Option)
            //            .WithMany(p => p.TagModelConfigs)
            //            .HasForeignKey(d => d.OptionId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_tag_model_config_4");

            //        entity.HasOne(d => d.Tag)
            //            .WithMany(p => p.TagModelConfigs)
            //            .HasForeignKey(d => d.TagId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_tag_model_config_1");
            //    });

            //    modelBuilder.Entity<U1>(entity =>
            //    {
            //        entity.HasNoKey();

            //        entity.ToTable("u1");

            //        entity.Property(e => e.TagId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("tag_id");

            //        entity.Property(e => e.U10)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u10");

            //        entity.Property(e => e.U11)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u1");

            //        entity.Property(e => e.U111)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u11");

            //        entity.Property(e => e.U12)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u12");

            //        entity.Property(e => e.U13)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u13");

            //        entity.Property(e => e.U14)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u14");

            //        entity.Property(e => e.U15)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u15");

            //        entity.Property(e => e.U16)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u16");

            //        entity.Property(e => e.U17)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u17");

            //        entity.Property(e => e.U18)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u18");

            //        entity.Property(e => e.U19)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u19");

            //        entity.Property(e => e.U2)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u2");

            //        entity.Property(e => e.U20)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u20");

            //        entity.Property(e => e.U21)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u21");

            //        entity.Property(e => e.U22)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u22");

            //        entity.Property(e => e.U23)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u23");

            //        entity.Property(e => e.U24)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u24");

            //        entity.Property(e => e.U25)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u25");

            //        entity.Property(e => e.U26)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u26");

            //        entity.Property(e => e.U27)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u27");

            //        entity.Property(e => e.U28)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u28");

            //        entity.Property(e => e.U29)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u29");

            //        entity.Property(e => e.U3)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u3");

            //        entity.Property(e => e.U30)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u30");

            //        entity.Property(e => e.U31)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u31");

            //        entity.Property(e => e.U32)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u32");

            //        entity.Property(e => e.U33)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u33");

            //        entity.Property(e => e.U34)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u34");

            //        entity.Property(e => e.U35)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u35");

            //        entity.Property(e => e.U36)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u36");

            //        entity.Property(e => e.U37)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u37");

            //        entity.Property(e => e.U38)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u38");

            //        entity.Property(e => e.U39)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u39");

            //        entity.Property(e => e.U4)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u4");

            //        entity.Property(e => e.U40)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u40");

            //        entity.Property(e => e.U41)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u41");

            //        entity.Property(e => e.U42)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u42");

            //        entity.Property(e => e.U43)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u43");

            //        entity.Property(e => e.U44)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u44");

            //        entity.Property(e => e.U45)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u45");

            //        entity.Property(e => e.U46)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u46");

            //        entity.Property(e => e.U47)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u47");

            //        entity.Property(e => e.U48)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u48");

            //        entity.Property(e => e.U49)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u49");

            //        entity.Property(e => e.U5)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u5");

            //        entity.Property(e => e.U50)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u50");

            //        entity.Property(e => e.U51)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u51");

            //        entity.Property(e => e.U52)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u52");

            //        entity.Property(e => e.U53)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u53");

            //        entity.Property(e => e.U54)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u54");

            //        entity.Property(e => e.U55)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u55");

            //        entity.Property(e => e.U56)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u56");

            //        entity.Property(e => e.U57)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u57");

            //        entity.Property(e => e.U58)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u58");

            //        entity.Property(e => e.U59)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u59");

            //        entity.Property(e => e.U6)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u6");

            //        entity.Property(e => e.U60)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u60");

            //        entity.Property(e => e.U61)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u61");

            //        entity.Property(e => e.U62)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u62");

            //        entity.Property(e => e.U63)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u63");

            //        entity.Property(e => e.U64)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u64");

            //        entity.Property(e => e.U65)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u65");

            //        entity.Property(e => e.U66)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u66");

            //        entity.Property(e => e.U67)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u67");

            //        entity.Property(e => e.U68)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u68");

            //        entity.Property(e => e.U69)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u69");

            //        entity.Property(e => e.U7)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u7");

            //        entity.Property(e => e.U70)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u70");

            //        entity.Property(e => e.U71)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u71");

            //        entity.Property(e => e.U72)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u72");

            //        entity.Property(e => e.U73)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u73");

            //        entity.Property(e => e.U74)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u74");

            //        entity.Property(e => e.U75)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u75");

            //        entity.Property(e => e.U76)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u76");

            //        entity.Property(e => e.U77)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u77");

            //        entity.Property(e => e.U78)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u78");

            //        entity.Property(e => e.U79)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u79");

            //        entity.Property(e => e.U8)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u8");

            //        entity.Property(e => e.U80)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u80");

            //        entity.Property(e => e.U9)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("u9");

            //        entity.HasOne(d => d.Tag)
            //            .WithMany()
            //            .HasForeignKey(d => d.TagId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_u1");
            //    });

            //    modelBuilder.Entity<Unit>(entity =>
            //    {
            //        entity.ToTable("units");

            //        entity.Property(e => e.UnitId)
            //            .ValueGeneratedNever()
            //            .HasColumnName("unit_id");

            //        entity.Property(e => e.ConvFormula)
            //            .HasMaxLength(100)
            //            .IsUnicode(false)
            //            .HasColumnName("conv_formula")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.UnitFlag).HasColumnName("unit_flag");

            //        entity.Property(e => e.UnitName)
            //            .IsRequired()
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("unit_name")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.UnitTypeId).HasColumnName("unit_type_id");

            //        entity.HasOne(d => d.UnitType)
            //            .WithMany(p => p.Units)
            //            .HasForeignKey(d => d.UnitTypeId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_units");
            //    });

            //    modelBuilder.Entity<UnitType>(entity =>
            //    {
            //        entity.ToTable("unit_type");

            //        entity.Property(e => e.UnitTypeId)
            //            .ValueGeneratedNever()
            //            .HasColumnName("unit_type_id");

            //        entity.Property(e => e.UnitTypeDesc)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("unit_type_desc");

            //        entity.Property(e => e.UnitTypeName)
            //            .IsRequired()
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("unit_type_name")
            //            .IsFixedLength(true);
            //    });

            //    modelBuilder.Entity<UserInfo>(entity =>
            //    {
            //        entity.HasKey(e => e.UserId)
            //            .HasName("pk_user_info");

            //        entity.ToTable("user_info");

            //        entity.HasIndex(e => e.UserName, "uk_option_tech_data")
            //            .IsUnique();

            //        entity.Property(e => e.UserId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("user_id");

            //        entity.Property(e => e.City)
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("city");

            //        entity.Property(e => e.CompanyName)
            //            .HasMaxLength(100)
            //            .IsUnicode(false)
            //            .HasColumnName("company_name");

            //        entity.Property(e => e.Country)
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("[country");

            //        entity.Property(e => e.Email)
            //            .HasMaxLength(100)
            //            .IsUnicode(false)
            //            .HasColumnName("email");

            //        entity.Property(e => e.FirstName)
            //            .HasMaxLength(100)
            //            .IsUnicode(false)
            //            .HasColumnName("first_name");

            //        entity.Property(e => e.Industry)
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("industry");

            //        entity.Property(e => e.JobTitle)
            //            .HasMaxLength(100)
            //            .IsUnicode(false)
            //            .HasColumnName("job_title");

            //        entity.Property(e => e.LastLogonDate)
            //            .HasColumnType("datetime")
            //            .HasColumnName("last_logon_date");

            //        entity.Property(e => e.LastName)
            //            .HasMaxLength(100)
            //            .IsUnicode(false)
            //            .HasColumnName("last_name");

            //        entity.Property(e => e.PhoneNumber)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("phone_number")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.State)
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("state");

            //        entity.Property(e => e.StreetAddress)
            //            .HasMaxLength(100)
            //            .IsUnicode(false)
            //            .HasColumnName("street_address");

            //        entity.Property(e => e.UserName)
            //            .IsRequired()
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("user_name")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.UserPwd)
            //            .IsRequired()
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("user_pwd")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.ZipCode)
            //            .HasMaxLength(20)
            //            .IsUnicode(false)
            //            .HasColumnName("zip_code")
            //            .IsFixedLength(true);
            //    });

            //    modelBuilder.Entity<UserPreference>(entity =>
            //    {
            //        entity.HasKey(e => new { e.PreferenceName, e.UserId })
            //            .HasName("pk_user_preference");

            //        entity.ToTable("user_preference");

            //        entity.Property(e => e.PreferenceName)
            //            .HasMaxLength(50)
            //            .IsUnicode(false)
            //            .HasColumnName("preference_name")
            //            .IsFixedLength(true);

            //        entity.Property(e => e.UserId)
            //            .HasColumnType("numeric(18, 0)")
            //            .HasColumnName("user_id");

            //        entity.Property(e => e.ValueF).HasColumnName("value_f");

            //        entity.Property(e => e.ValueT)
            //            .HasMaxLength(255)
            //            .IsUnicode(false)
            //            .HasColumnName("value_t");

            //        entity.HasOne(d => d.User)
            //            .WithMany(p => p.UserPreferences)
            //            .HasForeignKey(d => d.UserId)
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_user_preference");
            //    });

        }


    }

}

