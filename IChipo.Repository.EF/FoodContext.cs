using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IChipo.Repository.EF.Models
{
    public partial class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options): base(options)
        {

        }
        public virtual DbSet<AbpAuditLogs> AbpAuditLogs { get; set; }
        public virtual DbSet<AbpBackgroundJobs> AbpBackgroundJobs { get; set; }
        public virtual DbSet<AbpEditions> AbpEditions { get; set; }
        public virtual DbSet<AbpFeatures> AbpFeatures { get; set; }
        public virtual DbSet<AbpLanguages> AbpLanguages { get; set; }
        public virtual DbSet<AbpLanguageTexts> AbpLanguageTexts { get; set; }
        public virtual DbSet<AbpNotifications> AbpNotifications { get; set; }
        public virtual DbSet<AbpNotificationSubscriptions> AbpNotificationSubscriptions { get; set; }
        public virtual DbSet<AbpOrganizationUnits> AbpOrganizationUnits { get; set; }
        public virtual DbSet<AbpPermissions> AbpPermissions { get; set; }
        public virtual DbSet<AbpRoles> AbpRoles { get; set; }
        public virtual DbSet<AbpSettings> AbpSettings { get; set; }
        public virtual DbSet<AbpTenantInfo> AbpTenantInfo { get; set; }
        public virtual DbSet<AbpTenantNotifications> AbpTenantNotifications { get; set; }
        public virtual DbSet<AbpTenants> AbpTenants { get; set; }
        public virtual DbSet<AbpUserAccounts> AbpUserAccounts { get; set; }
        public virtual DbSet<AbpUserClaims> AbpUserClaims { get; set; }
        public virtual DbSet<AbpUserLoginAttempts> AbpUserLoginAttempts { get; set; }
        public virtual DbSet<AbpUserLogins> AbpUserLogins { get; set; }
        public virtual DbSet<AbpUserNotifications> AbpUserNotifications { get; set; }
        public virtual DbSet<AbpUserOrganizationUnits> AbpUserOrganizationUnits { get; set; }
        public virtual DbSet<AbpUserRoles> AbpUserRoles { get; set; }
        public virtual DbSet<AbpUsers> AbpUsers { get; set; }
        public virtual DbSet<ActivistOrderForm> ActivistOrderForm { get; set; }
        public virtual DbSet<Ad> Ad { get; set; }
        public virtual DbSet<AdBrowseLog> AdBrowseLog { get; set; }
        public virtual DbSet<AdFeeLog> AdFeeLog { get; set; }
        public virtual DbSet<AdOntoList> AdOntoList { get; set; }
        public virtual DbSet<AdType> AdType { get; set; }
        public virtual DbSet<AdvertisersInfo> AdvertisersInfo { get; set; }
        public virtual DbSet<AgencieBaseInfo> AgencieBaseInfo { get; set; }
        public virtual DbSet<AgencieCommissionSettle> AgencieCommissionSettle { get; set; }
        public virtual DbSet<AgencieCommissionWater> AgencieCommissionWater { get; set; }
        public virtual DbSet<AgencieFundsFlow> AgencieFundsFlow { get; set; }
        public virtual DbSet<AgencieLevel> AgencieLevel { get; set; }
        public virtual DbSet<AgencieOrder> AgencieOrder { get; set; }
        public virtual DbSet<AgenciePromotion> AgenciePromotion { get; set; }
        public virtual DbSet<AgenciePromotionRule> AgenciePromotionRule { get; set; }
        public virtual DbSet<AgencieRewardSettle> AgencieRewardSettle { get; set; }
        public virtual DbSet<AgencieRewardWaterStatistics> AgencieRewardWaterStatistics { get; set; }
        public virtual DbSet<AgencieSalesmanConfig> AgencieSalesmanConfig { get; set; }
        public virtual DbSet<AgencieScoreFlow> AgencieScoreFlow { get; set; }
        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<AgSerialNo> AgSerialNo { get; set; }
        public virtual DbSet<AppBinaryObjects> AppBinaryObjects { get; set; }
        public virtual DbSet<ApplyShopQuanlification> ApplyShopQuanlification { get; set; }
        public virtual DbSet<ApplyShopVerify> ApplyShopVerify { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleSection> ArticleSection { get; set; }
        public virtual DbSet<AutoSettleApply> AutoSettleApply { get; set; }
        public virtual DbSet<AutoSettleApplyMerchant> AutoSettleApplyMerchant { get; set; }
        public virtual DbSet<AutoSettleApplyMerchantRelation> AutoSettleApplyMerchantRelation { get; set; }
        public virtual DbSet<BankCardBinInfo> BankCardBinInfo { get; set; }
        public virtual DbSet<BankCardCheckInfo> BankCardCheckInfo { get; set; }
        public virtual DbSet<BankCardIdInfo> BankCardIdInfo { get; set; }
        public virtual DbSet<BankNoInfo> BankNoInfo { get; set; }
        public virtual DbSet<Bargain> Bargain { get; set; }
        public virtual DbSet<BargainPrice> BargainPrice { get; set; }
        public virtual DbSet<BargainRelationGod> BargainRelationGod { get; set; }
        public virtual DbSet<BonusFundsFlow> BonusFundsFlow { get; set; }
        public virtual DbSet<BonusPoolsLog> BonusPoolsLog { get; set; }
        public virtual DbSet<BonusWithdrawal> BonusWithdrawal { get; set; }
        public virtual DbSet<BranchShop> BranchShop { get; set; }
        public virtual DbSet<BusinessApplication> BusinessApplication { get; set; }
        public virtual DbSet<BusinessApply> BusinessApply { get; set; }
        public virtual DbSet<CapitalAccount> CapitalAccount { get; set; }
        public virtual DbSet<CmsArticleCategories> CmsArticleCategories { get; set; }
        public virtual DbSet<CmsArticles> CmsArticles { get; set; }
        public virtual DbSet<CollectProduct> CollectProduct { get; set; }
        public virtual DbSet<CollectShop> CollectShop { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<CommentImage> CommentImage { get; set; }
        public virtual DbSet<CommentTag> CommentTag { get; set; }
        public virtual DbSet<Community> Community { get; set; }
        public virtual DbSet<Competence> Competence { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<ExternalPayChannel> ExternalPayChannel { get; set; }
        public virtual DbSet<ExternalPayMchShopRecord> ExternalPayMchShopRecord { get; set; }
        public virtual DbSet<ExternalPayMchShopRelation> ExternalPayMchShopRelation { get; set; }
        public virtual DbSet<ExternalPayMerchant> ExternalPayMerchant { get; set; }
        public virtual DbSet<ExternalPayMerchantErrorLog> ExternalPayMerchantErrorLog { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<FundsFlow> FundsFlow { get; set; }
        public virtual DbSet<God> God { get; set; }
        public virtual DbSet<GodAddress> GodAddress { get; set; }
        public virtual DbSet<GodDistributionShop> GodDistributionShop { get; set; }
        public virtual DbSet<GodGroup> GodGroup { get; set; }
        public virtual DbSet<GodGroupRelationShop> GodGroupRelationShop { get; set; }
        public virtual DbSet<GodRelationCommunity> GodRelationCommunity { get; set; }
        public virtual DbSet<GroupBuy> GroupBuy { get; set; }
        public virtual DbSet<GroupBuyRelationGod> GroupBuyRelationGod { get; set; }
        public virtual DbSet<Groupon> Groupon { get; set; }
        public virtual DbSet<GrouponCategory> GrouponCategory { get; set; }
        public virtual DbSet<GrouponCategoryRelation> GrouponCategoryRelation { get; set; }
        public virtual DbSet<GrouponDetail> GrouponDetail { get; set; }
        public virtual DbSet<GrouponUserDetail> GrouponUserDetail { get; set; }
        public virtual DbSet<GuestCoupon> GuestCoupon { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<IndustriesCommentConfig> IndustriesCommentConfig { get; set; }
        public virtual DbSet<IndustriesCommentTag> IndustriesCommentTag { get; set; }
        public virtual DbSet<IndustriesScoreConfig> IndustriesScoreConfig { get; set; }
        public virtual DbSet<IndustriesTag> IndustriesTag { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<Judge> Judge { get; set; }
        public virtual DbSet<JudgeOperationLog> JudgeOperationLog { get; set; }
        public virtual DbSet<JudgeRelationPost> JudgeRelationPost { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<MemberCoupon> MemberCoupon { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<MyBankCard> MyBankCard { get; set; }
        public virtual DbSet<OperationLog> OperationLog { get; set; }
        public virtual DbSet<OrderForJycInfo> OrderForJycInfo { get; set; }
        public virtual DbSet<OrderForm> OrderForm { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<OrderPayWaterLog> OrderPayWaterLog { get; set; }
        public virtual DbSet<OrderProcessLog> OrderProcessLog { get; set; }
        public virtual DbSet<OrderRefund> OrderRefund { get; set; }
        public virtual DbSet<OrderRefundWaterLog> OrderRefundWaterLog { get; set; }
        public virtual DbSet<OrderStatisticsForJyc> OrderStatisticsForJyc { get; set; }
        public virtual DbSet<Pages> Pages { get; set; }
        public virtual DbSet<PagesSection> PagesSection { get; set; }
        public virtual DbSet<PlatformBankCard> PlatformBankCard { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<PostRelationCompetence> PostRelationCompetence { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductDistribution> ProductDistribution { get; set; }
        public virtual DbSet<ProductEvaluation> ProductEvaluation { get; set; }
        public virtual DbSet<ProductPicture> ProductPicture { get; set; }
        public virtual DbSet<ProductProperty> ProductProperty { get; set; }
        public virtual DbSet<ProductRelationShopProductType> ProductRelationShopProductType { get; set; }
        public virtual DbSet<ProductRelationSpecification> ProductRelationSpecification { get; set; }
        public virtual DbSet<ProductSku> ProductSku { get; set; }
        public virtual DbSet<ProductSkupriceLog> ProductSkupriceLog { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Promotions> Promotions { get; set; }
        public virtual DbSet<PromotionsRelationProduct> PromotionsRelationProduct { get; set; }
        public virtual DbSet<QrcodePayApply> QrcodePayApply { get; set; }
        public virtual DbSet<QrcodePayOrder> QrcodePayOrder { get; set; }
        public virtual DbSet<QrCodePayOrderStatistics> QrCodePayOrderStatistics { get; set; }
        public virtual DbSet<Recharge> Recharge { get; set; }
        public virtual DbSet<ReferrerAccount> ReferrerAccount { get; set; }
        public virtual DbSet<ReferrerBankCard> ReferrerBankCard { get; set; }
        public virtual DbSet<ReferrerBankCardCheckFailLog> ReferrerBankCardCheckFailLog { get; set; }
        public virtual DbSet<ReferrerCodBinding> ReferrerCodBinding { get; set; }
        public virtual DbSet<ReferrerCommission> ReferrerCommission { get; set; }
        public virtual DbSet<ReferrerCommissionReport> ReferrerCommissionReport { get; set; }
        public virtual DbSet<ReferrerConventionalRateSet> ReferrerConventionalRateSet { get; set; }
        public virtual DbSet<ReferrerFundsFlow> ReferrerFundsFlow { get; set; }
        public virtual DbSet<ReferrerQrCodeTicket> ReferrerQrCodeTicket { get; set; }
        public virtual DbSet<ReferrerUser> ReferrerUser { get; set; }
        public virtual DbSet<ReferrerWithdrawal> ReferrerWithdrawal { get; set; }
        public virtual DbSet<RegisterApply> RegisterApply { get; set; }
        public virtual DbSet<ReportForm> ReportForm { get; set; }
        public virtual DbSet<ReportFormParameter> ReportFormParameter { get; set; }
        public virtual DbSet<RuiFuAreaInfo> RuiFuAreaInfo { get; set; }
        public virtual DbSet<SalesLoginLog> SalesLoginLog { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<ScoreGoods> ScoreGoods { get; set; }
        public virtual DbSet<ScoreGoodsOrderLog> ScoreGoodsOrderLog { get; set; }
        public virtual DbSet<SendSmsLog> SendSmsLog { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<ShopActivityCoupon> ShopActivityCoupon { get; set; }
        public virtual DbSet<ShopAuthorizeSales> ShopAuthorizeSales { get; set; }
        public virtual DbSet<ShopBaseInfo> ShopBaseInfo { get; set; }
        public virtual DbSet<ShopCollectRecord> ShopCollectRecord { get; set; }
        public virtual DbSet<ShopFullDiscount> ShopFullDiscount { get; set; }
        public virtual DbSet<ShopkeeperInfo> ShopkeeperInfo { get; set; }
        public virtual DbSet<ShopMember> ShopMember { get; set; }
        public virtual DbSet<ShopOrderScoreLog> ShopOrderScoreLog { get; set; }
        public virtual DbSet<ShopProductType> ShopProductType { get; set; }
        public virtual DbSet<ShopReply> ShopReply { get; set; }
        public virtual DbSet<ShopRiskManagement> ShopRiskManagement { get; set; }
        public virtual DbSet<ShopScoreWaterLog> ShopScoreWaterLog { get; set; }
        public virtual DbSet<ShopStatistics> ShopStatistics { get; set; }
        public virtual DbSet<ShopTemplateGroup> ShopTemplateGroup { get; set; }
        public virtual DbSet<ShopTemplates> ShopTemplates { get; set; }
        public virtual DbSet<ShopVip> ShopVip { get; set; }
        public virtual DbSet<ShopVoucher> ShopVoucher { get; set; }
        public virtual DbSet<SizeGroup> SizeGroup { get; set; }
        public virtual DbSet<SmsTemplate> SmsTemplate { get; set; }
        public virtual DbSet<SpecialInvitationCode> SpecialInvitationCode { get; set; }
        public virtual DbSet<Specification> Specification { get; set; }
        public virtual DbSet<SpecificationGroup> SpecificationGroup { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<SysArea> SysArea { get; set; }
        public virtual DbSet<SysSms> SysSms { get; set; }
        public virtual DbSet<SystemWarnLog> SystemWarnLog { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<TaskCommissionRecord> TaskCommissionRecord { get; set; }
        public virtual DbSet<TaskReceive> TaskReceive { get; set; }
        public virtual DbSet<TaskSpread> TaskSpread { get; set; }
        public virtual DbSet<TerminalManage> TerminalManage { get; set; }
        public virtual DbSet<TerminalOrderOperationLog> TerminalOrderOperationLog { get; set; }
        public virtual DbSet<TerminalStartupPage> TerminalStartupPage { get; set; }
        public virtual DbSet<TerminalStartupPageItems> TerminalStartupPageItems { get; set; }
        public virtual DbSet<TtAgencieCommissionSettle> TtAgencieCommissionSettle { get; set; }
        public virtual DbSet<TtAgencieCommissionWater> TtAgencieCommissionWater { get; set; }
        public virtual DbSet<TtAgencieRewardSettle> TtAgencieRewardSettle { get; set; }
        public virtual DbSet<TtAgencieRewardWaterStatistics> TtAgencieRewardWaterStatistics { get; set; }
        public virtual DbSet<TtFundsFlow> TtFundsFlow { get; set; }
        public virtual DbSet<TtGod> TtGod { get; set; }
        public virtual DbSet<TtMerchantInfo> TtMerchantInfo { get; set; }
        public virtual DbSet<TtMerchantSettlementInfo> TtMerchantSettlementInfo { get; set; }
        public virtual DbSet<TtMyBankCard> TtMyBankCard { get; set; }
        public virtual DbSet<TtOrderPayWaterLog> TtOrderPayWaterLog { get; set; }
        public virtual DbSet<TtPayMchShopRelation> TtPayMchShopRelation { get; set; }
        public virtual DbSet<TtQrcodePayApply> TtQrcodePayApply { get; set; }
        public virtual DbSet<TtQrcodePayOrder> TtQrcodePayOrder { get; set; }
        public virtual DbSet<TtQrCodePayOrderStatistics> TtQrCodePayOrderStatistics { get; set; }
        public virtual DbSet<TtShop> TtShop { get; set; }
        public virtual DbSet<TtShopRiskManagement> TtShopRiskManagement { get; set; }
        public virtual DbSet<TtWithdrawal> TtWithdrawal { get; set; }
        public virtual DbSet<UreferrerBindApply> UreferrerBindApply { get; set; }
        public virtual DbSet<UreferrerOrder> UreferrerOrder { get; set; }
        public virtual DbSet<UserOrderScoreLog> UserOrderScoreLog { get; set; }
        public virtual DbSet<UserScore> UserScore { get; set; }
        public virtual DbSet<UserScoreLog> UserScoreLog { get; set; }
        public virtual DbSet<UserScoreWaterLog> UserScoreWaterLog { get; set; }
        public virtual DbSet<WeiXinMchSetting> WeiXinMchSetting { get; set; }
        public virtual DbSet<WeiXinMsgTemplates> WeiXinMsgTemplates { get; set; }
        public virtual DbSet<WeiXinMsgTemplateSetting> WeiXinMsgTemplateSetting { get; set; }
        public virtual DbSet<WeiXinRedLog> WeiXinRedLog { get; set; }
        public virtual DbSet<WeiXinSetting> WeiXinSetting { get; set; }
        public virtual DbSet<Withdrawal> Withdrawal { get; set; }
        public virtual DbSet<WithdrawalRecord> WithdrawalRecord { get; set; }

        // Unable to generate entity type for table 'dbo.TtWithdrawalAutoSettle'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SalesmanCheckShopLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GodRelationPropertyCosts'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PropertyCosts'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Salesman'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WithdrawalAutoSettle'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TaskCommissionAutoSettle'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Setting'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Agencies'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TtQRCodePay'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SysPageData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QRCodePay'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Industries'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SalesmanRelationAgencies'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=.;Database=Food;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbpAuditLogs>(entity =>
            {
                entity.Property(e => e.BrowserInfo).HasMaxLength(256);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.CustomData).HasMaxLength(2000);

                entity.Property(e => e.Exception).HasMaxLength(2000);

                entity.Property(e => e.ExecutionTime).HasColumnType("datetime");

                entity.Property(e => e.MethodName).HasMaxLength(256);

                entity.Property(e => e.Parameters).HasMaxLength(1024);

                entity.Property(e => e.ServiceName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpBackgroundJobs>(entity =>
            {
                entity.HasIndex(e => new { e.IsAbandoned, e.NextTryTime })
                    .HasName("IX_IsAbandoned_NextTryTime");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.JobArgs).IsRequired();

                entity.Property(e => e.JobType)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.LastTryTime).HasColumnType("datetime");

                entity.Property(e => e.NextTryTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AbpEditions>(entity =>
            {
                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<AbpFeatures>(entity =>
            {
                entity.HasIndex(e => e.EditionId)
                    .HasName("IX_EditionId");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpFeatures)
                    .HasForeignKey(d => d.EditionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.AbpFeatures_dbo.AbpEditions_EditionId");
            });

            modelBuilder.Entity<AbpLanguages>(entity =>
            {
                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Icon).HasMaxLength(128);

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<AbpLanguageTexts>(entity =>
            {
                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<AbpNotifications>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<AbpNotificationSubscriptions>(entity =>
            {
                entity.HasIndex(e => new { e.NotificationName, e.EntityTypeName, e.EntityId, e.UserId })
                    .HasName("IX_NotificationName_EntityTypeName_EntityId_UserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName).HasMaxLength(96);
            });

            modelBuilder.Entity<AbpOrganizationUnits>(entity =>
            {
                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_ParentId");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_dbo.AbpOrganizationUnits_dbo.AbpOrganizationUnits_ParentId");
            });

            modelBuilder.Entity<AbpPermissions>(entity =>
            {
                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.AbpPermissions_dbo.AbpRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.AbpPermissions_dbo.AbpUsers_UserId");
            });

            modelBuilder.Entity<AbpRoles>(entity =>
            {
                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("IX_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId)
                    .HasName("IX_DeleterUserId");

                entity.HasIndex(e => e.LastModifierUserId)
                    .HasName("IX_LastModifierUserId");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpRolesCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId)
                    .HasConstraintName("FK_dbo.AbpRoles_dbo.AbpUsers_CreatorUserId");

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpRolesDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId)
                    .HasConstraintName("FK_dbo.AbpRoles_dbo.AbpUsers_DeleterUserId");

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpRolesLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId)
                    .HasConstraintName("FK_dbo.AbpRoles_dbo.AbpUsers_LastModifierUserId");
            });

            modelBuilder.Entity<AbpSettings>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpSettings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AbpSettings_dbo.AbpUsers_UserId");
            });

            modelBuilder.Entity<AbpTenantInfo>(entity =>
            {
                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AbpTenantNotifications>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<AbpTenants>(entity =>
            {
                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("IX_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId)
                    .HasName("IX_DeleterUserId");

                entity.HasIndex(e => e.EditionId)
                    .HasName("IX_EditionId");

                entity.HasIndex(e => e.LastModifierUserId)
                    .HasName("IX_LastModifierUserId");

                entity.Property(e => e.ConnectionString).HasMaxLength(1024);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TenancyName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpTenantsCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId)
                    .HasConstraintName("FK_dbo.AbpTenants_dbo.AbpUsers_CreatorUserId");

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpTenantsDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId)
                    .HasConstraintName("FK_dbo.AbpTenants_dbo.AbpUsers_DeleterUserId");

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpTenants)
                    .HasForeignKey(d => d.EditionId)
                    .HasConstraintName("FK_dbo.AbpTenants_dbo.AbpEditions_EditionId");

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpTenantsLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId)
                    .HasConstraintName("FK_dbo.AbpTenants_dbo.AbpUsers_LastModifierUserId");
            });

            modelBuilder.Entity<AbpUserAccounts>(entity =>
            {
                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.LastLoginTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AbpUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AbpUserClaims_dbo.AbpUsers_UserId");
            });

            modelBuilder.Entity<AbpUserLoginAttempts>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.TenantId })
                    .HasName("IX_UserId_TenantId");

                entity.HasIndex(e => new { e.TenancyName, e.UserNameOrEmailAddress, e.Result })
                    .HasName("IX_TenancyName_UserNameOrEmailAddress_Result");

                entity.Property(e => e.BrowserInfo).HasMaxLength(256);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.TenancyName).HasMaxLength(64);

                entity.Property(e => e.UserNameOrEmailAddress).HasMaxLength(255);
            });

            modelBuilder.Entity<AbpUserLogins>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProviderKey)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AbpUserLogins_dbo.AbpUsers_UserId");
            });

            modelBuilder.Entity<AbpUserNotifications>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.State, e.CreationTime })
                    .HasName("IX_UserId_State_CreationTime");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AbpUserOrganizationUnits>(entity =>
            {
                entity.Property(e => e.CreationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AbpUserRoles>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AbpUserRoles_dbo.AbpUsers_UserId");
            });

            modelBuilder.Entity<AbpUsers>(entity =>
            {
                entity.HasIndex(e => e.CreatorUserId)
                    .HasName("IX_CreatorUserId");

                entity.HasIndex(e => e.DeleterUserId)
                    .HasName("IX_DeleterUserId");

                entity.HasIndex(e => e.LastModifierUserId)
                    .HasName("IX_LastModifierUserId");

                entity.Property(e => e.AuthenticationSource).HasMaxLength(64);

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.DeletionTime).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.EmailConfirmationCode).HasMaxLength(128);

                entity.Property(e => e.LastLoginTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordResetCode).HasMaxLength(328);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.InverseCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId)
                    .HasConstraintName("FK_dbo.AbpUsers_dbo.AbpUsers_CreatorUserId");

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.InverseDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId)
                    .HasConstraintName("FK_dbo.AbpUsers_dbo.AbpUsers_DeleterUserId");

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.InverseLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId)
                    .HasConstraintName("FK_dbo.AbpUsers_dbo.AbpUsers_LastModifierUserId");
            });

            modelBuilder.Entity<ActivistOrderForm>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.ReturnAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ad>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Ext1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ext2).HasMaxLength(200);

                entity.Property(e => e.Ext3).HasMaxLength(500);

                entity.Property(e => e.Ext4).HasMaxLength(1000);

                entity.Property(e => e.Picture).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(300);
            });

            modelBuilder.Entity<AdBrowseLog>(entity =>
            {
                entity.Property(e => e.AdCode).HasMaxLength(200);

                entity.Property(e => e.Adress).HasMaxLength(3000);

                entity.Property(e => e.City).HasMaxLength(300);

                entity.Property(e => e.Country).HasMaxLength(300);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FeeAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FlowSize).HasDefaultValueSql("((0))");

                entity.Property(e => e.HeadImg).HasMaxLength(200);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(300);

                entity.Property(e => e.NickName).HasMaxLength(300);

                entity.Property(e => e.OpenId).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Province).HasMaxLength(300);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdFeeLog>(entity =>
            {
                entity.Property(e => e.AdvertisersName).HasMaxLength(200);

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountFlow).HasDefaultValueSql("((0))");

                entity.Property(e => e.Flow).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalFlow).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdOntoList>(entity =>
            {
                entity.Property(e => e.AdSources).HasMaxLength(1000);

                entity.Property(e => e.AuditRemark).HasMaxLength(500);

                entity.Property(e => e.AuditUser).HasMaxLength(100);

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.BrowseTotalCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.BusinessName).HasMaxLength(200);

                entity.Property(e => e.Cnzzcode)
                    .HasColumnName("CNZZCode")
                    .HasMaxLength(2000);

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.Cover).HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FeeRule).HasDefaultValueSql("((0))");

                entity.Property(e => e.Link).HasMaxLength(300);

                entity.Property(e => e.MaxFeeCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxFlowCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxFlowRule).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinFlowRule).HasDefaultValueSql("((0))");

                entity.Property(e => e.OntoAreaCode).HasMaxLength(50);

                entity.Property(e => e.OntoAreaName).HasMaxLength(100);

                entity.Property(e => e.OntoOnLevel).HasMaxLength(50);

                entity.Property(e => e.Profiles).HasMaxLength(300);

                entity.Property(e => e.Sort).HasDefaultValueSql("((999))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdType>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdvertisersInfo>(entity =>
            {
                entity.Property(e => e.AdvertisersName).HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencieBaseInfo>(entity =>
            {
                entity.Property(e => e.AgencieLevel).HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyAddress)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ContactPhone)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CreditSellerSettlementRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.CreditSellerSettlementRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.CreditSellerSettlementRateT0).HasDefaultValueSql("((6))");

                entity.Property(e => e.CreditSellerSettlementRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.CreditSettlementRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.CreditSettlementRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.CreditSettlementRateT0).HasDefaultValueSql("((6))");

                entity.Property(e => e.CreditSettlementRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.InviterCode)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.RatePercent).HasDefaultValueSql("((100))");

                entity.Property(e => e.ReferrerCreditRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerCreditRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerCreditRateT0).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerCreditRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferrerRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerRateT0).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerRateType).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReferrerSavingCapAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((9999))");

                entity.Property(e => e.ReferrerSavingRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerSavingRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerSavingRateT0).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerSavingRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SavingSellerSettlementCapAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((9999))");

                entity.Property(e => e.SavingSellerSettlementRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.SavingSellerSettlementRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.SavingSellerSettlementRateT0).HasDefaultValueSql("((6))");

                entity.Property(e => e.SavingSellerSettlementRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.SavingSettlementCapAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((9999))");

                entity.Property(e => e.SavingSettlementRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.SavingSettlementRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.SavingSettlementRateT0).HasDefaultValueSql("((6))");

                entity.Property(e => e.SavingSettlementRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.SettlementRateT00).HasDefaultValueSql("((6))");

                entity.Property(e => e.SettlementRateT11).HasDefaultValueSql("((6))");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.T00ellerSettlementRate).HasDefaultValueSql("((6))");

                entity.Property(e => e.T00sellerTtSettlementRate)
                    .HasColumnName("T00SellerTtSettlementRate")
                    .HasDefaultValueSql("((6))");

                entity.Property(e => e.T0sellerSettlementRate).HasColumnName("T0SellerSettlementRate");

                entity.Property(e => e.T0sellerTtSettlementRate).HasColumnName("T0SellerTtSettlementRate");

                entity.Property(e => e.T11sellerSettlementRate)
                    .HasColumnName("T11SellerSettlementRate")
                    .HasDefaultValueSql("((6))");

                entity.Property(e => e.T11sellerTtSettlementRate)
                    .HasColumnName("T11SellerTtSettlementRate")
                    .HasDefaultValueSql("((6))");

                entity.Property(e => e.T1sellerSettlementRate).HasColumnName("T1SellerSettlementRate");

                entity.Property(e => e.T1sellerTtSettlementRate).HasColumnName("T1SellerTtSettlementRate");

                entity.Property(e => e.TtCapSellerSettlementCapAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((9999))");

                entity.Property(e => e.TtCapSellerSettlementRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.TtCapSellerSettlementRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.TtCapSellerSettlementRateT0).HasDefaultValueSql("((6))");

                entity.Property(e => e.TtCapSellerSettlementRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.TtCapSettlementCapAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((9999))");

                entity.Property(e => e.TtCapSettlementRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.TtCapSettlementRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.TtCapSettlementRateT0).HasDefaultValueSql("((6))");

                entity.Property(e => e.TtCapSettlementRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.TtSettlementRateT00).HasDefaultValueSql("((6))");

                entity.Property(e => e.TtSettlementRateT11).HasDefaultValueSql("((6))");
            });

            modelBuilder.Entity<AgencieCommissionSettle>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Info).HasMaxLength(500);

                entity.Property(e => e.OutTradeNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SettleDateRange).HasMaxLength(100);

                entity.Property(e => e.SettleStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.StatisticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencieCommissionWater>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SettleComissionType).HasDefaultValueSql("((1))");

                entity.Property(e => e.StatisticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencieFundsFlow>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencieLevel>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.LevelName).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencieOrder>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTradeNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgenciePromotion>(entity =>
            {
                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgenciePromotionRule>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencieRewardSettle>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Info).HasMaxLength(500);

                entity.Property(e => e.OutTradeNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SettleCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.SettleDateRange).HasMaxLength(100);

                entity.Property(e => e.SettleStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.StatisticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencieRewardWaterStatistics>(entity =>
            {
                entity.Property(e => e.ActiveDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.StatisticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgencieSalesmanConfig>(entity =>
            {
                entity.Property(e => e.AgencieCode).HasColumnType("char(2)");

                entity.Property(e => e.FactorLength).HasDefaultValueSql("((3))");
            });

            modelBuilder.Entity<AgencieScoreFlow>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => new { e.Value, e.Key })
                    .HasName("UX_HangFire_CounterAggregated_Key")
                    .IsUnique();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AgSerialNo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppBinaryObjects>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Bytes).IsRequired();
            });

            modelBuilder.Entity<ApplyShopQuanlification>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.BusinessCertificate).HasMaxLength(256);

                entity.Property(e => e.BusinessLicense).HasMaxLength(150);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Doorway).HasMaxLength(256);

                entity.Property(e => e.IdcardNegative)
                    .HasColumnName("IDCardNegative")
                    .HasMaxLength(150);

                entity.Property(e => e.IdcardPositive)
                    .HasColumnName("IDCardPositive")
                    .HasMaxLength(150);

                entity.Property(e => e.TaxRegistration).HasMaxLength(150);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApplyShopVerify>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Logo).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ShopNotece).HasMaxLength(500);

                entity.Property(e => e.Subname).HasMaxLength(256);

                entity.Property(e => e.TelePhone).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ShowDateTime).HasColumnType("date");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ArticleSection>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AutoSettleApply>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.AddressDeatil).HasMaxLength(150);

                entity.Property(e => e.AuditDateTime).HasColumnType("datetime");

                entity.Property(e => e.AuditStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.BankAreaCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BankCardNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BankCardPhoneNumber).HasMaxLength(50);

                entity.Property(e => e.BankCardSerialNumber).HasMaxLength(50);

                entity.Property(e => e.BankCity)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BankCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BankProvincial)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BranchBankName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BusinessLicense).HasMaxLength(256);

                entity.Property(e => e.CardholderName)
                    .IsRequired()
                    .HasMaxLength(125);

                entity.Property(e => e.CashInRateT0).HasDefaultValueSql("((0))");

                entity.Property(e => e.CashInRateT1).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Doorway).HasMaxLength(256);

                entity.Property(e => e.IdNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdcardNegative)
                    .IsRequired()
                    .HasColumnName("IDCardNegative")
                    .HasMaxLength(150);

                entity.Property(e => e.IdcardPositive)
                    .IsRequired()
                    .HasColumnName("IDCardPositive")
                    .HasMaxLength(150);

                entity.Property(e => e.Indoor).HasMaxLength(256);

                entity.Property(e => e.IsCheckLegalPerson).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCheckPic).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCheckSettleInfo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Latitude).HasDefaultValueSql("((0))");

                entity.Property(e => e.LegalPersonReason).HasMaxLength(300);

                entity.Property(e => e.MchSettingStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.PicReason).HasMaxLength(300);

                entity.Property(e => e.PointLongitude).HasDefaultValueSql("((0))");

                entity.Property(e => e.PosAgreement).HasMaxLength(256);

                entity.Property(e => e.PosLicence).HasMaxLength(256);

                entity.Property(e => e.Remark).HasMaxLength(2048);

                entity.Property(e => e.SettleInfoReason).HasMaxLength(300);

                entity.Property(e => e.SettlementMode).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShopkeeperName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.SupplyMsg).HasMaxLength(150);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AutoSettleApplyMerchant>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MchId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MchKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AutoSettleApplyMerchantRelation>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BankCardBinInfo>(entity =>
            {
                entity.Property(e => e.BankName)
                    .HasColumnName("BANK_NAME")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.BankNo)
                    .HasColumnName("BANK_NO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.BankTitle)
                    .HasColumnName("BANK_TITLE")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CardBin)
                    .HasColumnName("CARD_BIN")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CardLength).HasColumnName("CARD_LENGTH");

                entity.Property(e => e.CardName)
                    .HasColumnName("CARD_NAME")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasColumnName("CARD_TYPE")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FiltMode)
                    .HasColumnName("FILT_MODE")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BankCardCheckInfo>(entity =>
            {
                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IdcardNumber)
                    .IsRequired()
                    .HasColumnName("IDCardNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BankCardIdInfo>(entity =>
            {
                entity.Property(e => e.BankCardId)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BankNoInfo>(entity =>
            {
                entity.Property(e => e.BankId)
                    .HasColumnName("Bank_Id")
                    .HasMaxLength(100);

                entity.Property(e => e.BankName)
                    .HasColumnName("Bank_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.BankNo)
                    .HasColumnName("Bank_No")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Bargain>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CurrentPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BargainPrice>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MaxPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MinPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MoreThanPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BargainRelationGod>(entity =>
            {
                entity.HasKey(e => e.CreateTime);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.BargainPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NewPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BonusFundsFlow>(entity =>
            {
                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BonusFundsBalance)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FeeStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.GodHeadUrl).HasMaxLength(300);

                entity.Property(e => e.GodNickName).HasMaxLength(200);

                entity.Property(e => e.IsValid).HasDefaultValueSql("((1))");

                entity.Property(e => e.RelationAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BonusPoolsLog>(entity =>
            {
                entity.Property(e => e.BonusPoolsBalance)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InPoolsAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LogType).HasDefaultValueSql("((0))");

                entity.Property(e => e.RelationAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<BonusWithdrawal>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BankCardInfo).HasMaxLength(128);

                entity.Property(e => e.BankCardName).HasMaxLength(128);

                entity.Property(e => e.BankCardNo).HasMaxLength(128);

                entity.Property(e => e.BankType).HasDefaultValueSql("((1))");

                entity.Property(e => e.BankUnionNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Fee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FullName).HasMaxLength(128);

                entity.Property(e => e.GodPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasMaxLength(128);

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.ShopAuthorizeSalesId).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNo).HasMaxLength(128);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WithdrawalAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<BranchShop>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.AddressDeatil).HasMaxLength(150);

                entity.Property(e => e.AreaId).HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchShopName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.BusinessLicense).HasMaxLength(256);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Doorway).HasMaxLength(256);

                entity.Property(e => e.EndWorkTime).HasColumnType("datetime");

                entity.Property(e => e.IsShow).HasDefaultValueSql("((1))");

                entity.Property(e => e.Logo).HasMaxLength(150);

                entity.Property(e => e.MchId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ServicePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartWorkTime).HasColumnType("datetime");

                entity.Property(e => e.TelePhone).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BusinessApplication>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.ContactPhone).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InviteCode).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BusinessApply>(entity =>
            {
                entity.Property(e => e.ApplyTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OperateTime).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.TerminalNo).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CapitalAccount>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.SecurityPwd).HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CmsArticles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.Introduction).HasMaxLength(1000);

                entity.Property(e => e.LineUrl).HasMaxLength(512);

                entity.Property(e => e.OriginalUrl).HasMaxLength(512);

                entity.Property(e => e.PicUrl).HasMaxLength(512);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CmsArticles)
                    .HasForeignKey<CmsArticles>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CmsArticles_dbo.CmsArticleCategories_Id");
            });

            modelBuilder.Entity<CollectProduct>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CollectShop>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.BranchShopId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Content).HasMaxLength(2048);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GodOpenId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommentImage>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl).HasMaxLength(512);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommentTag>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CommentTagName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Community>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsValid).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Competence>(entity =>
            {
                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.Controllers).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => new { e.Value, e.Key })
                    .HasName("IX_HangFire_Counter_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExternalPayChannel>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExternalPayMchShopRecord>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExternalPayMchShopRelation>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExternalPayMerchant>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MchId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MchKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExternalPayMerchantErrorLog>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Level).HasDefaultValueSql("((1))");

                entity.Property(e => e.MchId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Files>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(200);
            });

            modelBuilder.Entity<FundsFlow>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FeeOutInStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.IncomeRemark).HasMaxLength(500);

                entity.Property(e => e.PayRemark).HasMaxLength(500);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<God>(entity =>
            {
                entity.Property(e => e.Appid)
                    .HasColumnName("APPId")
                    .HasMaxLength(100);

                entity.Property(e => e.BankCardNumber).HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BankType).HasDefaultValueSql("((1))");

                entity.Property(e => e.BankUnionNo).HasMaxLength(100);

                entity.Property(e => e.BindUreferrer)
                    .HasColumnName("BindUReferrer")
                    .HasMaxLength(50);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CardImg)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CommentTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.HeadUrl).HasMaxLength(300);

                entity.Property(e => e.IdNumber).HasMaxLength(50);

                entity.Property(e => e.IsValidIdnumber).HasColumnName("IsValidIDNumber");

                entity.Property(e => e.JgpushId)
                    .HasColumnName("JGPushId")
                    .HasMaxLength(200);

                entity.Property(e => e.Md5Secret).HasMaxLength(50);

                entity.Property(e => e.NickName).HasMaxLength(200);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.RecommendCode).HasMaxLength(50);

                entity.Property(e => e.RecommendDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecommendQrUrl).HasMaxLength(200);

                entity.Property(e => e.RegistSource).HasDefaultValueSql("((1))");

                entity.Property(e => e.Salt).HasMaxLength(50);

                entity.Property(e => e.SetWithdrawalMode).HasDefaultValueSql("((1))");

                entity.Property(e => e.SetWithdrawalType).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalScore).HasDefaultValueSql("((0))");

                entity.Property(e => e.UnionId).HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WeiXinOpenId).HasMaxLength(100);

                entity.Property(e => e.WithdrawalFee).HasDefaultValueSql("((3.8))");
            });

            modelBuilder.Entity<GodAddress>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LocateAddress).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Receiver).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GodDistributionShop>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ShopLogo).HasMaxLength(50);

                entity.Property(e => e.ShopName).HasMaxLength(50);

                entity.Property(e => e.ShopNotece).HasMaxLength(500);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GodGroup>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GodGroupRelationShop>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GodRelationCommunity>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GroupBuy>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GroupBuyRelationGod>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PayTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Groupon>(entity =>
            {
                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.Category).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrouponPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsShow).HasColumnName("isShow");

                entity.Property(e => e.NeedTime).HasDefaultValueSql("((24))");

                entity.Property(e => e.SalesCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sku).HasColumnName("SKU");

                entity.Property(e => e.Sort).HasDefaultValueSql("((999))");

                entity.Property(e => e.Tip).HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GrouponCategory>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GrouponCategoryRelation>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GrouponDetail>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SuccessTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GrouponUserDetail>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HeadImgUrl).HasMaxLength(200);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WeiXinOpenId).HasMaxLength(100);
            });

            modelBuilder.Entity<GuestCoupon>(entity =>
            {
                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.IsValid).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsView).HasDefaultValueSql("((0))");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UseTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => new { e.ExpireAt, e.Key })
                    .HasName("IX_HangFire_Hash_Key");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_Hash_ExpireAt");

                entity.HasIndex(e => new { e.Key, e.Field })
                    .HasName("UX_HangFire_Hash_Key_Field")
                    .IsUnique();

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<IndustriesCommentConfig>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FifthComment).HasDefaultValueSql("((-1))");

                entity.Property(e => e.FirstComment).HasDefaultValueSql("((-1))");

                entity.Property(e => e.FourthComment).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SecondComment).HasDefaultValueSql("((-1))");

                entity.Property(e => e.ThirdComment).HasDefaultValueSql("((-1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<IndustriesCommentTag>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<IndustriesScoreConfig>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MaxScoreDay).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioForCommentByShop).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioForCommentByUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioForOtherByUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioForPayByShop).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioForPayByUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioForRewardByShop).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioForShareByUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalRatioByShop).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalRatioByUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<IndustriesTag>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.ToTable("JobParameter", "HangFire");

                entity.HasIndex(e => new { e.JobId, e.Name })
                    .HasName("IX_HangFire_JobParameter_JobIdAndName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.ToTable("JobQueue", "HangFire");

                entity.HasIndex(e => new { e.Queue, e.FetchedAt })
                    .HasName("IX_HangFire_JobQueue_QueueAndFetchedAt");

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Judge>(entity =>
            {
                entity.Property(e => e.Aliases).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.LoginKey).HasMaxLength(50);

                entity.Property(e => e.Salt).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<JudgeOperationLog>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<JudgeRelationPost>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_List_ExpireAt");

                entity.HasIndex(e => new { e.ExpireAt, e.Value, e.Key })
                    .HasName("IX_HangFire_List_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value).HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<MemberCoupon>(entity =>
            {
                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FaceValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SourceId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SourceType).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UseMinValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MyBankCard>(entity =>
            {
                entity.Property(e => e.AreaCode).HasMaxLength(100);

                entity.Property(e => e.BankCardName).HasMaxLength(200);

                entity.Property(e => e.BankCardNo).HasMaxLength(100);

                entity.Property(e => e.BankCode).HasMaxLength(50);

                entity.Property(e => e.BankNo).HasMaxLength(100);

                entity.Property(e => e.BranchBankName).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(125);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Provincial).HasMaxLength(100);

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OperationLog>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderForJycInfo>(entity =>
            {
                entity.Property(e => e.CheckedTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.OrderNo).HasMaxLength(128);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.RoomNum).HasMaxLength(128);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderForm>(entity =>
            {
                entity.Property(e => e.ActualPayAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ApplyPlatformArbitrationDateTime).HasColumnType("datetime");

                entity.Property(e => e.ApplyReturnDateTime).HasColumnType("datetime");

                entity.Property(e => e.CashOnDeliveryAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerServiceRemark).HasMaxLength(500);

                entity.Property(e => e.DeliveryCompany).HasMaxLength(50);

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DeliveryNumber).HasMaxLength(50);

                entity.Property(e => e.DiscountedAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ForecastPostTime).HasColumnType("datetime");

                entity.Property(e => e.GodComment).HasMaxLength(500);

                entity.Property(e => e.GodCommentDateTime).HasColumnType("datetime");

                entity.Property(e => e.GodRemark).HasMaxLength(500);

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OnlinePaymentAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderFormNumber).HasMaxLength(50);

                entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PayBalanceAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PayEndDateTime).HasColumnType("datetime");

                entity.Property(e => e.PayTime).HasColumnType("datetime");

                entity.Property(e => e.ProductTotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReceiptDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverName).HasMaxLength(50);

                entity.Property(e => e.ReceiverPhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Shipment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ShippedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ShopName).HasMaxLength(50);

                entity.Property(e => e.ShopReplyComment).HasMaxLength(500);

                entity.Property(e => e.ShopReplyCommentDateTime).HasColumnType("datetime");

                entity.Property(e => e.SubmitDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DistributorReward).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FatherDistributorReward).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrandfatherDistributorReward).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.OriginalPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProductListPicture).HasMaxLength(250);

                entity.Property(e => e.ProductSkuid).HasColumnName("ProductSKUId");

                entity.Property(e => e.PromotionRemark).HasMaxLength(500);

                entity.Property(e => e.SpecificationName).HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderPayWaterLog>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Appid)
                    .HasColumnName("APPId")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderNo).HasMaxLength(300);

                entity.Property(e => e.PayUser).HasMaxLength(100);

                entity.Property(e => e.PlatformNo).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.ShopId).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNo).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderProcessLog>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(1024);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderRefund>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefundChannel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefundNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefundTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.TransactionNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionRefundNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderRefundWaterLog>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderNo).HasMaxLength(100);

                entity.Property(e => e.PlatformNo).HasMaxLength(100);

                entity.Property(e => e.RefundNo).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.SourceNo).HasMaxLength(100);

                entity.Property(e => e.TradingStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNo).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderStatisticsForJyc>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PropertyAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PropertyCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PropertyFee).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark).HasMaxLength(1024);

                entity.Property(e => e.RentalAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.RentalCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.RentalFee).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatisticsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalFee).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Pages>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<PagesSection>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlatformBankCard>(entity =>
            {
                entity.Property(e => e.BankCardNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LimitAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Picture)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RealName).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PostRelationCompetence>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DistributionRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsShow).HasColumnName("isShow");

                entity.Property(e => e.Lable).HasMaxLength(500);

                entity.Property(e => e.ListPicture).HasMaxLength(250);

                entity.Property(e => e.ListPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.Shipment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductDistribution>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductEvaluation>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductPicture>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Picture).HasMaxLength(150);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductProperty>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductRelationShopProductType>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductRelationSpecification>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductSku>(entity =>
            {
                entity.ToTable("ProductSKU");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SpecificationCode).HasMaxLength(50);

                entity.Property(e => e.SpecificationName).HasMaxLength(150);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductSkupriceLog>(entity =>
            {
                entity.ToTable("ProductSKUPriceLog");

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DistributionRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProductSkuid).HasColumnName("ProductSKUId");

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Promotions>(entity =>
            {
                entity.Property(e => e.BargainMinPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DiscountsRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.GroupBuyPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GroupBuyTeamLeaderDiscountsRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsGroupon).HasColumnName("isGroupon");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ReduceAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.ThresholdAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PromotionsRelationProduct>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<QrcodePayApply>(entity =>
            {
                entity.ToTable("QRCodePayApply");

                entity.Property(e => e.BranchShopId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QrcodeId).HasColumnName("QRCodeId");

                entity.Property(e => e.QrcodeNo)
                    .HasColumnName("QRCodeNo")
                    .HasMaxLength(200);

                entity.Property(e => e.ShopName).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.WeiXinOpenId).HasMaxLength(100);

                entity.Property(e => e.WxpayAppId)
                    .HasColumnName("WXPayAppId")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<QrcodePayOrder>(entity =>
            {
                entity.ToTable("QRCodePayOrder");

                entity.HasIndex(e => new { e.ShopId, e.BranchShopId })
                    .HasName("_dta_index_QRCodePayOrder_9_482100758__K2_K26_K4_K9_K10");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Appid)
                    .HasColumnName("APPId")
                    .HasMaxLength(100);

                entity.Property(e => e.BranchShopId).HasDefaultValueSql("((0))");

                entity.Property(e => e.BusinessWeiXinOpenId).HasMaxLength(50);

                entity.Property(e => e.CouponId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CouponValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeductionAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeductionReferrerId).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeductionReferrerScore).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeductionType).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeviceSn)
                    .HasColumnName("DeviceSN")
                    .HasMaxLength(100);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FeeRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.FeeType).HasDefaultValueSql("((1))");

                entity.Property(e => e.FullDiscountUseValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.FullDiscountValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.GodId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ip).HasMaxLength(100);

                entity.Property(e => e.MchId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderNo).HasMaxLength(300);

                entity.Property(e => e.OrderSource).HasDefaultValueSql("((1))");

                entity.Property(e => e.OtherTransactionNo).HasMaxLength(300);

                entity.Property(e => e.PayBankType).HasMaxLength(100);

                entity.Property(e => e.PayDateTime).HasColumnType("datetime");

                entity.Property(e => e.PayUser).HasMaxLength(100);

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.QrcodeId).HasColumnName("QRCodeId");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.ShopName).HasMaxLength(200);

                entity.Property(e => e.TaskId).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaskReceiveId).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TransactionNo).HasMaxLength(300);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WeiXinOpenId).HasMaxLength(50);

                entity.Property(e => e.ZoneNo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('SZ')");
            });

            modelBuilder.Entity<QrCodePayOrderStatistics>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastDayTradeAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastMonthTradeAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.StatisticsDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Recharge>(entity =>
            {
                entity.Property(e => e.ActualRechargeFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.RechargeFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RechargeNumber).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(150);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReferrerAccount>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReferrerBankCard>(entity =>
            {
                entity.ToTable("ReferrerBankCard ");

                entity.Property(e => e.AreaId).HasMaxLength(50);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.CardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardSerialNumber).HasMaxLength(127);

                entity.Property(e => e.CardholderName).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IdcardNumber)
                    .HasColumnName("IDCardNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReferrerBankCardCheckFailLog>(entity =>
            {
                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IdcardNumber)
                    .IsRequired()
                    .HasColumnName("IDCardNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.RealName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReferrerCodBinding>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ReferrerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WeiXinOpenId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReferrerCommission>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReferrerCommissionReport>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReferrerConventionalRateSet>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReferrerFundsFlow>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReferrerQrCodeTicket>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InviteCode).HasMaxLength(50);

                entity.Property(e => e.Ticket)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReferrerUser>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HeadPortrait).HasMaxLength(255);

                entity.Property(e => e.IdcardNegative)
                    .HasColumnName("IDCardNegative")
                    .HasMaxLength(511);

                entity.Property(e => e.IdcardNumber)
                    .HasColumnName("IDCardNumber")
                    .HasMaxLength(31);

                entity.Property(e => e.IdcardPositive)
                    .HasColumnName("IDCardPositive")
                    .HasMaxLength(511);

                entity.Property(e => e.InvitationCode).HasMaxLength(15);

                entity.Property(e => e.NickName).HasMaxLength(63);

                entity.Property(e => e.OpenId)
                    .IsRequired()
                    .HasMaxLength(127);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(63);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(31);

                entity.Property(e => e.RealName).HasMaxLength(63);

                entity.Property(e => e.SafePassword).HasMaxLength(63);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReferrerWithdrawal>(entity =>
            {
                entity.Property(e => e.ArrivalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BankCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.CardholderName).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Fee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WithdrawalAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<RegisterApply>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ReferrerGodId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferrerPhoneNumber).HasMaxLength(256);

                entity.Property(e => e.ReferrerShopId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReportForm>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReportFormParameter>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultValue).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ParameterRegex).HasMaxLength(50);

                entity.Property(e => e.Tip).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<RuiFuAreaInfo>(entity =>
            {
                entity.Property(e => e.AreaCode).HasMaxLength(100);

                entity.Property(e => e.AreaName).HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ParentCode).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesLoginLog>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WeiXinNo).HasMaxLength(50);

                entity.Property(e => e.WeiXinOpenId).HasMaxLength(50);
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version);

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScoreGoods>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GoodsBody).HasMaxLength(2048);

                entity.Property(e => e.GoodsName).HasMaxLength(256);

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VoucherValue).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ScoreGoodsOrderLog>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GoodsBody).HasMaxLength(2048);

                entity.Property(e => e.GoodsName).HasMaxLength(256);

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VoucherValue).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SendSmsLog>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiredTime).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_Set_ExpireAt");

                entity.HasIndex(e => new { e.Key, e.Value })
                    .HasName("UX_HangFire_Set_KeyAndValue")
                    .IsUnique();

                entity.HasIndex(e => new { e.ExpireAt, e.Value, e.Key })
                    .HasName("IX_HangFire_Set_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.AddressDeatil).HasMaxLength(150);

                entity.Property(e => e.Appid)
                    .HasColumnName("APPId")
                    .HasMaxLength(100);

                entity.Property(e => e.BindMchLevel).HasDefaultValueSql("((1))");

                entity.Property(e => e.BindMchRelationId).HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.BusinessCertificate).HasMaxLength(256);

                entity.Property(e => e.BusinessLicense).HasMaxLength(150);

                entity.Property(e => e.CashInCreditRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.CashInCreditRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.CashInCreditRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.CashInRateT11).HasDefaultValueSql("((6))");

                entity.Property(e => e.CashInSavingCapAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((9999))");

                entity.Property(e => e.CashInSavingRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.CashInSavingRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.CashInSavingRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.CommentLevel).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Doorway).HasMaxLength(256);

                entity.Property(e => e.EndWorkTime).HasColumnType("datetime");

                entity.Property(e => e.FeeType).HasDefaultValueSql("((1))");

                entity.Property(e => e.FluctuantScale).HasDefaultValueSql("((0))");

                entity.Property(e => e.HasPayMsg).HasDefaultValueSql("((1))");

                entity.Property(e => e.IdCardInHand).HasMaxLength(150);

                entity.Property(e => e.IdNumber).HasMaxLength(50);

                entity.Property(e => e.IdcardNegative)
                    .HasColumnName("IDCardNegative")
                    .HasMaxLength(150);

                entity.Property(e => e.IdcardPositive)
                    .HasColumnName("IDCardPositive")
                    .HasMaxLength(150);

                entity.Property(e => e.Indoor).HasMaxLength(256);

                entity.Property(e => e.IndustriesId).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShow).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVoicePush).HasDefaultValueSql("((2))");

                entity.Property(e => e.Logo).HasMaxLength(300);

                entity.Property(e => e.MaxDailySales).HasDefaultValueSql("((10000))");

                entity.Property(e => e.MaxScoreDay).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.PosAgreement).HasMaxLength(256);

                entity.Property(e => e.PosLicence).HasMaxLength(256);

                entity.Property(e => e.QrcodeId).HasColumnName("QRCodeId");

                entity.Property(e => e.RatioForCommentByShop).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioForCommentByUser).HasDefaultValueSql("((-1))");

                entity.Property(e => e.RatioForOtherByUser).HasDefaultValueSql("((-1))");

                entity.Property(e => e.RatioForPayByShop).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioForPayByUser).HasDefaultValueSql("((-1))");

                entity.Property(e => e.RatioForRewardByShop).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioForShareByUser).HasDefaultValueSql("((-1))");

                entity.Property(e => e.RecommendCode).HasMaxLength(50);

                entity.Property(e => e.ReferrerCreditRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerCreditRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerCreditRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferrerRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerRateType).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReferrerSavingCapAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((9999))");

                entity.Property(e => e.ReferrerSavingRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerSavingRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerSavingRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerType).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReferrerUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesmanId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScoreConfigIsDefault).HasDefaultValueSql("((1))");

                entity.Property(e => e.ServicePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementMode).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShopNotece).HasMaxLength(500);

                entity.Property(e => e.ShopkeeperName).HasMaxLength(64);

                entity.Property(e => e.StartWorkTime).HasColumnType("datetime");

                entity.Property(e => e.Subname).HasMaxLength(256);

                entity.Property(e => e.SupplyMsg).HasMaxLength(150);

                entity.Property(e => e.Tag).HasMaxLength(150);

                entity.Property(e => e.TaxRegistration).HasMaxLength(150);

                entity.Property(e => e.TelePhone).HasMaxLength(50);

                entity.Property(e => e.TotalRatioByShop).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalRatioByUser).HasDefaultValueSql("((-1))");

                entity.Property(e => e.TotalScore).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VipSign).HasMaxLength(50);

                entity.Property(e => e.WorkDateTime).HasMaxLength(150);
            });

            modelBuilder.Entity<ShopActivityCoupon>(entity =>
            {
                entity.Property(e => e.CozyCue).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InitCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.SendBeginTime).HasColumnType("datetime");

                entity.Property(e => e.SendEndTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UseBeginTime).HasColumnType("datetime");

                entity.Property(e => e.UseEndTime).HasColumnType("datetime");

                entity.Property(e => e.ValidDay).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ShopAuthorizeSales>(entity =>
            {
                entity.Property(e => e.ActivateTime).HasColumnType("datetime");

                entity.Property(e => e.Appid)
                    .HasColumnName("APPId")
                    .HasMaxLength(100);

                entity.Property(e => e.BranchShopId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50);

                entity.Property(e => e.IsVoicePush).HasDefaultValueSql("((2))");

                entity.Property(e => e.IsWorkingTime).HasDefaultValueSql("((1))");

                entity.Property(e => e.JgpushId)
                    .HasColumnName("JGPushId")
                    .HasMaxLength(200);

                entity.Property(e => e.NickName).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.SecurityCode).HasMaxLength(128);

                entity.Property(e => e.ShopName).HasMaxLength(100);

                entity.Property(e => e.UnionId).HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserHeardImg).HasMaxLength(200);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.WeiXinOpenId).HasMaxLength(100);
            });

            modelBuilder.Entity<ShopBaseInfo>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.BusinessCertificate).HasMaxLength(256);

                entity.Property(e => e.BusinessLicense).HasMaxLength(150);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Doorway).HasMaxLength(256);

                entity.Property(e => e.Logo).HasMaxLength(150);

                entity.Property(e => e.ShopName).HasMaxLength(128);

                entity.Property(e => e.SubName).HasMaxLength(128);

                entity.Property(e => e.TelePhone).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopCollectRecord>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopFullDiscount>(entity =>
            {
                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Stauts).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopkeeperInfo>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IdCardInHand).HasMaxLength(150);

                entity.Property(e => e.IdNumber).HasMaxLength(50);

                entity.Property(e => e.IdcardNegative)
                    .HasColumnName("IDCardNegative")
                    .HasMaxLength(150);

                entity.Property(e => e.IdcardPositive)
                    .HasColumnName("IDCardPositive")
                    .HasMaxLength(150);

                entity.Property(e => e.ShopkeeperName).HasMaxLength(64);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopMember>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastDealTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopOrderScoreLog>(entity =>
            {
                entity.Property(e => e.BranchShopId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GodOpenId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopProductType>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopReply>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopRiskManagement>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DayTradeAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.DayWithdrawalAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsValid).HasDefaultValueSql("((1))");

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.RiskType).HasDefaultValueSql("((1))");

                entity.Property(e => e.SinglePayAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.SingleWithdrawalAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopScoreWaterLog>(entity =>
            {
                entity.Property(e => e.BranchShopId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsIn).HasDefaultValueSql("((1))");

                entity.Property(e => e.Remark).HasMaxLength(512);

                entity.Property(e => e.SourceNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TotalScore).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopStatistics>(entity =>
            {
                entity.Property(e => e.BranchShopId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ShopId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShopName).HasMaxLength(100);

                entity.Property(e => e.StatisticsDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopTemplateGroup>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopTemplates>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Path).HasMaxLength(150);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopVip>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ShopLogo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShopVoucher>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.GoodsId).HasDefaultValueSql("((0))");

                entity.Property(e => e.GoodsName).HasMaxLength(256);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UseTime).HasColumnType("datetime");

                entity.Property(e => e.VoucherValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.WithdrawId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SizeGroup>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Specification).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SmsTemplate>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.TemplateContent).HasMaxLength(500);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SpecialInvitationCode>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InvitationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferrerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferrerName).HasMaxLength(50);

                entity.Property(e => e.ReferrerPhone)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SalesmanCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesmanName).HasMaxLength(50);

                entity.Property(e => e.SalesmanPhone)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Specification>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ImgUrl).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SpecificationGroup>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State", "HangFire");

                entity.HasIndex(e => e.JobId)
                    .HasName("IX_HangFire_State_JobId");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<SysArea>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCode")
                    .HasMaxLength(128);

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SysSms>(entity =>
            {
                entity.Property(e => e.CreationTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SystemWarnLog>(entity =>
            {
                entity.Property(e => e.Content).HasMaxLength(3000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Level).HasDefaultValueSql("((1))");

                entity.Property(e => e.LevelB).HasDefaultValueSql("((1))");

                entity.Property(e => e.Module).HasMaxLength(50);

                entity.Property(e => e.NextExcuteTime).HasColumnType("datetime");

                entity.Property(e => e.NextRelationValue).HasMaxLength(200);

                entity.Property(e => e.RelationValue).HasMaxLength(200);

                entity.Property(e => e.Solution).HasMaxLength(3000);

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.TriggerValue).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TaskCommissionRecord>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.RecordNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TaskReceive>(entity =>
            {
                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.QrshareTaskCoupons)
                    .HasColumnName("QRShareTaskCoupons")
                    .HasMaxLength(256);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TaskSpread>(entity =>
            {
                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.CommisionValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TerminalManage>(entity =>
            {
                entity.Property(e => e.ChannelNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MerchantNo).HasMaxLength(50);

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sdppuk)
                    .HasColumnName("SDPPUK")
                    .HasMaxLength(255);

                entity.Property(e => e.SettlementMode).HasDefaultValueSql("((12))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TerminalOrderOperationLog>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeviceSn)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperationUserOpenId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperationUserPhoneNumber)
                    .IsRequired()
                    .HasColumnType("char(11)");

                entity.Property(e => e.OpreationUserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TerminalStartupPage>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsValid).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasColumnType("nchar(10)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TerminalStartupPageItems>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsValid).HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.Sort).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtAgencieCommissionSettle>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Info).HasMaxLength(500);

                entity.Property(e => e.OutTradeNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SettleDateRange).HasMaxLength(100);

                entity.Property(e => e.SettleStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.StatisticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtAgencieCommissionWater>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.StatisticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtAgencieRewardSettle>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Info).HasMaxLength(500);

                entity.Property(e => e.OutTradeNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SettleCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.SettleDateRange).HasMaxLength(100);

                entity.Property(e => e.SettleStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.StatisticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtAgencieRewardWaterStatistics>(entity =>
            {
                entity.Property(e => e.ActiveDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.StatisticDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtFundsFlow>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FeeOutInStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.IncomeRemark).HasMaxLength(500);

                entity.Property(e => e.PayRemark).HasMaxLength(500);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtGod>(entity =>
            {
                entity.Property(e => e.Appid)
                    .HasColumnName("APPId")
                    .HasMaxLength(100);

                entity.Property(e => e.BankCardNumber).HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BankType).HasDefaultValueSql("((1))");

                entity.Property(e => e.BankUnionNo).HasMaxLength(100);

                entity.Property(e => e.CardImg)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CommentTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.HeadUrl).HasMaxLength(300);

                entity.Property(e => e.IdNumber).HasMaxLength(50);

                entity.Property(e => e.IsValidIdnumber).HasColumnName("IsValidIDNumber");

                entity.Property(e => e.Md5Secret).HasMaxLength(50);

                entity.Property(e => e.NickName).HasMaxLength(200);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.RecommendCode).HasMaxLength(50);

                entity.Property(e => e.RecommendDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecommendQrUrl).HasMaxLength(200);

                entity.Property(e => e.ReferrerPhone).HasMaxLength(100);

                entity.Property(e => e.RegistSource).HasDefaultValueSql("((1))");

                entity.Property(e => e.Salt).HasMaxLength(50);

                entity.Property(e => e.SetWithdrawalMode).HasDefaultValueSql("((1))");

                entity.Property(e => e.SetWithdrawalType).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalScore).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WeiXinOpenId).HasMaxLength(100);

                entity.Property(e => e.WithdrawalFee).HasDefaultValueSql("((3.8))");
            });

            modelBuilder.Entity<TtMerchantInfo>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.D0rate)
                    .HasColumnName("D0Rate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.T1rate)
                    .HasColumnName("T1Rate")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtMerchantSettlementInfo>(entity =>
            {
                entity.Property(e => e.BankCardNo).HasColumnType("nchar(100)");

                entity.Property(e => e.BankId)
                    .HasColumnName("BankID")
                    .HasMaxLength(100);

                entity.Property(e => e.BankName).HasColumnType("nchar(10)");

                entity.Property(e => e.BranchBankId).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CityName).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.IdcardNo)
                    .HasColumnName("IDCardNo")
                    .HasMaxLength(50);

                entity.Property(e => e.Province).HasMaxLength(100);

                entity.Property(e => e.ProvinceName).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtMyBankCard>(entity =>
            {
                entity.Property(e => e.AreaCode).HasMaxLength(100);

                entity.Property(e => e.BankCardName).HasMaxLength(200);

                entity.Property(e => e.BankCardNo).HasMaxLength(100);

                entity.Property(e => e.BankCardType).HasDefaultValueSql("((1))");

                entity.Property(e => e.BankCode).HasMaxLength(50);

                entity.Property(e => e.BankNo).HasMaxLength(100);

                entity.Property(e => e.BranchBankName).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(125);

                entity.Property(e => e.IdcardNo)
                    .HasColumnName("IDCardNo")
                    .HasMaxLength(100);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.PayeeBankId).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Provincial).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtOrderPayWaterLog>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Appid)
                    .HasColumnName("APPId")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderNo).HasMaxLength(300);

                entity.Property(e => e.PayUser).HasMaxLength(100);

                entity.Property(e => e.PlatformNo).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.ShopId).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNo).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtPayMchShopRelation>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MchId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MchKey)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MchType).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtQrcodePayApply>(entity =>
            {
                entity.ToTable("TtQRCodePayApply");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Idcard)
                    .HasColumnName("IDCard")
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QrcodeId).HasColumnName("QRCodeId");

                entity.Property(e => e.QrcodeNo)
                    .HasColumnName("QRCodeNo")
                    .HasMaxLength(200);

                entity.Property(e => e.ShopName).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.WeiXinOpenId).HasMaxLength(100);

                entity.Property(e => e.WxpayAppId)
                    .HasColumnName("WXPayAppId")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TtQrcodePayOrder>(entity =>
            {
                entity.ToTable("TtQRCodePayOrder");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Appid)
                    .HasColumnName("APPId")
                    .HasMaxLength(100);

                entity.Property(e => e.BusinessWeiXinOpenId).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FeeRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.FeeType).HasDefaultValueSql("((2))");

                entity.Property(e => e.Ip).HasMaxLength(100);

                entity.Property(e => e.OrderNo).HasMaxLength(300);

                entity.Property(e => e.OtherTransactionNo).HasMaxLength(300);

                entity.Property(e => e.PayBankType).HasMaxLength(100);

                entity.Property(e => e.PayDateTime).HasColumnType("datetime");

                entity.Property(e => e.PayUser).HasMaxLength(100);

                entity.Property(e => e.QrcodeId).HasColumnName("QRCodeId");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.ShopName).HasMaxLength(200);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TransactionNo).HasMaxLength(300);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WeiXinOpenId).HasMaxLength(50);

                entity.Property(e => e.ZoneNo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('SZ')");
            });

            modelBuilder.Entity<TtQrCodePayOrderStatistics>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastDayTradeAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastMonthTradeAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.StatisticsDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtShop>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.Appid)
                    .HasColumnName("APPId")
                    .HasMaxLength(100);

                entity.Property(e => e.BindMchLevel).HasDefaultValueSql("((1))");

                entity.Property(e => e.BindMchRelationId).HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.BusinessCertificate).HasMaxLength(256);

                entity.Property(e => e.BusinessLicense).HasMaxLength(150);

                entity.Property(e => e.CashInCapAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((9999))");

                entity.Property(e => e.CashInCapRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.CashInCapRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.CashInCapRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.CashInRateT11).HasDefaultValueSql("((6))");

                entity.Property(e => e.CommentLevel).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Doorway).HasMaxLength(256);

                entity.Property(e => e.IdCardInHand).HasMaxLength(150);

                entity.Property(e => e.IdNumber).HasMaxLength(50);

                entity.Property(e => e.IdcardNegative)
                    .HasColumnName("IDCardNegative")
                    .HasMaxLength(150);

                entity.Property(e => e.IdcardPositive)
                    .HasColumnName("IDCardPositive")
                    .HasMaxLength(150);

                entity.Property(e => e.IndustriesId).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShow).HasColumnName("isShow");

                entity.Property(e => e.Logo).HasMaxLength(300);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.QrcodeId).HasColumnName("QRCodeId");

                entity.Property(e => e.QuickAuthentication).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecommendCode).HasMaxLength(50);

                entity.Property(e => e.ReferrerCapAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((9999))");

                entity.Property(e => e.ReferrerCapRateD0).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerCapRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerCapRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerRate).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerRateD1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerRateT1).HasDefaultValueSql("((6))");

                entity.Property(e => e.ReferrerRateType).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReferrerUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesmanId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SecurityPwd).HasMaxLength(200);

                entity.Property(e => e.ShopNotece).HasMaxLength(500);

                entity.Property(e => e.ShopkeeperName).HasMaxLength(64);

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.Property(e => e.Subname).HasMaxLength(256);

                entity.Property(e => e.Tag).HasMaxLength(150);

                entity.Property(e => e.TaxRegistration).HasMaxLength(150);

                entity.Property(e => e.TelePhone).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WorkDateTime).HasMaxLength(150);
            });

            modelBuilder.Entity<TtShopRiskManagement>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DayTradeAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.DayWithdrawalAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsValid).HasDefaultValueSql("((1))");

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.SinglePayAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.SingleWithdrawalAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtWithdrawal>(entity =>
            {
                entity.Property(e => e.ActualFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BankCardInfo).HasMaxLength(150);

                entity.Property(e => e.BankCardName).HasMaxLength(100);

                entity.Property(e => e.BankCardNo).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Fee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FeeRate).HasDefaultValueSql("((3.8))");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Number).HasMaxLength(50);

                entity.Property(e => e.OrderNo).HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.SettlementMode).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WithdrawalAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UreferrerBindApply>(entity =>
            {
                entity.ToTable("UReferrerBindApply");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OutApplyId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferrerCode)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ReferrerName).HasMaxLength(64);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UreferrerOrder>(entity =>
            {
                entity.ToTable("UReferrerOrder");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeviceSn)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FeeRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.FeeType).HasDefaultValueSql("((0))");

                entity.Property(e => e.PayDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserOrderScoreLog>(entity =>
            {
                entity.Property(e => e.BranchShopId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GodOpenId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserScore>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserScoreLog>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderNo).HasMaxLength(100);

                entity.Property(e => e.PlatformNo).HasMaxLength(200);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserScoreWaterLog>(entity =>
            {
                entity.Property(e => e.BranchShopId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GodOpenId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SourceNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<WeiXinMchSetting>(entity =>
            {
                entity.Property(e => e.AppId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CerPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MchId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<WeiXinMsgTemplates>(entity =>
            {
                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<WeiXinMsgTemplateSetting>(entity =>
            {
                entity.Property(e => e.AppId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasMaxLength(1000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeputyIndustry).HasMaxLength(100);

                entity.Property(e => e.Example).HasMaxLength(1000);

                entity.Property(e => e.PrimaryIndustry).HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.TemplateId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<WeiXinRedLog>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderNo).HasMaxLength(100);

                entity.Property(e => e.PlatformNo).HasMaxLength(100);

                entity.Property(e => e.RedNo).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.TransactionNo).HasMaxLength(100);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WeiXinOpenId).HasMaxLength(50);
            });

            modelBuilder.Entity<WeiXinSetting>(entity =>
            {
                entity.Property(e => e.AppId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AppSecret)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(300);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Withdrawal>(entity =>
            {
                entity.Property(e => e.ActualFee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BankCardInfo).HasMaxLength(150);

                entity.Property(e => e.BankCardName).HasMaxLength(100);

                entity.Property(e => e.BankCardNo).HasMaxLength(100);

                entity.Property(e => e.BankNo).HasMaxLength(100);

                entity.Property(e => e.BankType).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateBy).HasMaxLength(64);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Fee).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FeeRate).HasDefaultValueSql("((3.8))");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Number).HasMaxLength(50);

                entity.Property(e => e.OrderNo).HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.SettlementMode).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShopAuthorizeSalesId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShopVoucherId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShopVoucherValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WithdrawalAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WithdrawalMode).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<WithdrawalRecord>(entity =>
            {
                entity.Property(e => e.Attach).HasMaxLength(300);

                entity.Property(e => e.BankCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankGodName).HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(100);

                entity.Property(e => e.BankUnionNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CallBackUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClientIdAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FailureMsg).HasMaxLength(400);

                entity.Property(e => e.FinishDateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTradeOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceOrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WeixinAppId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WeixinOpenId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
