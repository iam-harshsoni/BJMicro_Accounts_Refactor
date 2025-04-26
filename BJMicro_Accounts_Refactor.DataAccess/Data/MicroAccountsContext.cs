using System;
using System.Collections.Generic;
using BJMicro_Accounts_Refactor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BJMicro_Accounts_Refactor.DataAccess.Data;

public partial class MicroAccountsContext : DbContext
{
    public MicroAccountsContext()
    {
    }

    public MicroAccountsContext(DbContextOptions<MicroAccountsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DailyRate> DailyRates { get; set; }

    public virtual DbSet<TblAccGroup> TblAccGroups { get; set; }

    public virtual DbSet<TblAccLedger> TblAccLedgers { get; set; }

    public virtual DbSet<TblCategoryMaster> TblCategoryMasters { get; set; }

    public virtual DbSet<TblEntry> TblEntries { get; set; }

    public virtual DbSet<TblEntryDetail> TblEntryDetails { get; set; }

    public virtual DbSet<TblItemMaster> TblItemMasters { get; set; }

    public virtual DbSet<TblLedgerDetail> TblLedgerDetails { get; set; }

    public virtual DbSet<TblPurchaseDetail> TblPurchaseDetails { get; set; }

    public virtual DbSet<TblPurchaseMaster> TblPurchaseMasters { get; set; }

    public virtual DbSet<TblSalesDetail> TblSalesDetails { get; set; }

    public virtual DbSet<TblSalesMaster> TblSalesMasters { get; set; }

    public virtual DbSet<TblStockItemDetail> TblStockItemDetails { get; set; }

    public virtual DbSet<TblTaxDetail> TblTaxDetails { get; set; }

    public virtual DbSet<TblTaxMaster> TblTaxMasters { get; set; }

    public virtual DbSet<TblTransactionMaster> TblTransactionMasters { get; set; }

    public virtual DbSet<TblUserLogiln> TblUserLogilns { get; set; }

    public virtual DbSet<TblUserProfile> TblUserProfiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-DM834UN;Initial Catalog=MicroAccounts;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DailyRate>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EighteenC)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("eighteenC");
            entity.Property(e => e.FineGold)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("fineGold");
            entity.Property(e => e.Hallmark)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("hallmark");
            entity.Property(e => e.HallmarkBuyBack)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("hallmarkBuyBack");
            entity.Property(e => e.Silver)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("silver");
            entity.Property(e => e.TwentyThreeC)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("twentyThreeC");
            entity.Property(e => e.TwentyTwoC)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("twentyTwoC");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
        });

        modelBuilder.Entity<TblAccGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("tbl_AccGroup");

            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.AffectsGross).HasColumnName("affects_gross");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.GroupName)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("groupName");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ParentId).HasColumnName("parentId");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("updateDate");
        });

        modelBuilder.Entity<TblAccLedger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AccLedger_1");

            entity.ToTable("tbl_AccLedger");

            entity.Property(e => e.CrId).HasColumnName("crId");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DrId).HasColumnName("drId");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.LedgerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ledgerName");
            entity.Property(e => e.Notes)
                .HasMaxLength(550)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.OpBalance)
                .HasColumnType("decimal(25, 2)")
                .HasColumnName("opBalance");
            entity.Property(e => e.OpBalanceDc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("opBalanceDC");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");

            entity.HasOne(d => d.Group).WithMany(p => p.TblAccLedgers)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_AccLedger_tbl_AccGroup");
        });

        modelBuilder.Entity<TblCategoryMaster>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PK_Category");

            entity.ToTable("tbl_CategoryMaster");

            entity.Property(e => e.CId).HasColumnName("cId");
            entity.Property(e => e.CName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cName");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Prefix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prefix");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
        });

        modelBuilder.Entity<TblEntry>(entity =>
        {
            entity.HasKey(e => e.VoucherRefNo).HasName("PK_tbl_Payment");

            entity.ToTable("tbl_Entry");

            entity.Property(e => e.VoucherRefNo)
                .ValueGeneratedNever()
                .HasColumnName("voucherRefNo");
            entity.Property(e => e.Amt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amt");
            entity.Property(e => e.CrId).HasColumnName("crId");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DrId).HasColumnName("drId");
            entity.Property(e => e.EntryType).HasColumnName("entryType");
            entity.Property(e => e.Remarks)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.StringDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stringDate");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
        });

        modelBuilder.Entity<TblEntryDetail>(entity =>
        {
            entity.HasKey(e => e.PDetailsId).HasName("PK_tbl_PaymentDetails");

            entity.ToTable("tbl_EntryDetails");

            entity.Property(e => e.PDetailsId).HasColumnName("pDetailsId");
            entity.Property(e => e.AmtPaid)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amtPaid");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.PurchaseSalesIds).HasColumnName("purchaseSalesIds");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
            entity.Property(e => e.VoucherRefNo).HasColumnName("voucherRefNo");
        });

        modelBuilder.Entity<TblItemMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ItemMaster");

            entity.ToTable("tbl_ItemMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("itemCode");
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("photo");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("updateDate");

            entity.HasOne(d => d.Category).WithMany(p => p.TblItemMasters)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_ItemMaster_CategoryMaster");
        });

        modelBuilder.Entity<TblLedgerDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LedgerDetails");

            entity.ToTable("tbl_LedgerDetails");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .IsFixedLength()
                .HasColumnName("address");
            entity.Property(e => e.Contact)
                .HasColumnType("numeric(13, 0)")
                .HasColumnName("contact");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.LedgerId).HasColumnName("ledgerId");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("updateDate");

            entity.HasOne(d => d.Ledger).WithMany(p => p.TblLedgerDetails)
                .HasForeignKey(d => d.LedgerId)
                .HasConstraintName("FK_tbl_LedgerDetails_tbl_AccLedger");
        });

        modelBuilder.Entity<TblPurchaseDetail>(entity =>
        {
            entity.HasKey(e => e.PdetailsId).HasName("PK_PurchaseDetail");

            entity.ToTable("tbl_PurchaseDetail");

            entity.Property(e => e.PdetailsId).HasColumnName("pdetailsId");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Fine)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("fine");
            entity.Property(e => e.KRate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kRate");
            entity.Property(e => e.Karat)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("karat");
            entity.Property(e => e.Making)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("making");
            entity.Property(e => e.Melting)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("melting");
            entity.Property(e => e.ProductId).HasColumnName("productID");
            entity.Property(e => e.PurchaseId).HasColumnName("purchaseID");
            entity.Property(e => e.PurchaseMelting)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("purchaseMelting");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("qty");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("rate");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unit");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("weight");

            entity.HasOne(d => d.Product).WithMany(p => p.TblPurchaseDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_PurchaseDetail_PurchaseDetail");

            entity.HasOne(d => d.Purchase).WithMany(p => p.TblPurchaseDetails)
                .HasForeignKey(d => d.PurchaseId)
                .HasConstraintName("FK_PurchaseDetail_PurchaseMaster");
        });

        modelBuilder.Entity<TblPurchaseMaster>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("PK_PurchaseMaster");

            entity.ToTable("tbl_PurchaseMaster");

            entity.Property(e => e.PId).HasColumnName("pId");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.LedgerId).HasColumnName("ledgerId");
            entity.Property(e => e.RefNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("refNo");
            entity.Property(e => e.Remarks)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.TotalAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalAmt");
            entity.Property(e => e.TotalFine)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalFine");
            entity.Property(e => e.TotalMaking)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalMaking");
            entity.Property(e => e.TotalMelting)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalMelting");
            entity.Property(e => e.TotalPurchaseMelting)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalPurchaseMelting");
            entity.Property(e => e.TotalWeight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalWeight");
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("unit");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("updateDate");

            entity.HasOne(d => d.Ledger).WithMany(p => p.TblPurchaseMasters)
                .HasForeignKey(d => d.LedgerId)
                .HasConstraintName("FK_PurchaseMaster_AccLedger");
        });

        modelBuilder.Entity<TblSalesDetail>(entity =>
        {
            entity.HasKey(e => e.SDetailsId).HasName("PK_SalesDetails");

            entity.ToTable("tbl_SalesDetails");

            entity.Property(e => e.SDetailsId).HasColumnName("sDetailsId");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.KRate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kRate");
            entity.Property(e => e.Karat)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("karat");
            entity.Property(e => e.Making)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("making");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("qty");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("rate");
            entity.Property(e => e.SalesId).HasColumnName("salesId");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unit");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("updateDate");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("weight");

            entity.HasOne(d => d.Product).WithMany(p => p.TblSalesDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_SalesDetails_tbl_ItemMaster");

            entity.HasOne(d => d.Sales).WithMany(p => p.TblSalesDetails)
                .HasForeignKey(d => d.SalesId)
                .HasConstraintName("FK_SalesDetails_SalesDetails");
        });

        modelBuilder.Entity<TblSalesMaster>(entity =>
        {
            entity.HasKey(e => e.SId).HasName("PK_SalesDetail");

            entity.ToTable("tbl_SalesMaster");

            entity.Property(e => e.SId).HasColumnName("sId");
            entity.Property(e => e.BillNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("billNo");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.LedgerId).HasColumnName("ledgerId");
            entity.Property(e => e.Remarks)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.TotalAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalAmt");
            entity.Property(e => e.TotalKarat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalKarat");
            entity.Property(e => e.TotalMaking)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalMaking");
            entity.Property(e => e.TotalWeight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalWeight");
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("unit");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("updateDate");

            entity.HasOne(d => d.Ledger).WithMany(p => p.TblSalesMasters)
                .HasForeignKey(d => d.LedgerId)
                .HasConstraintName("FK_SalesDetail_SalesDetail");
        });

        modelBuilder.Entity<TblStockItemDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StockItemDetails");

            entity.ToTable("tbl_StockItemDetails");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Carret)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("carret");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.ItemId).HasColumnName("itemId");
            entity.Property(e => e.Melting)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("melting");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("qty");
            entity.Property(e => e.Remarks)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("unit");
            entity.Property(e => e.UpadtedDate)
                .HasColumnType("datetime")
                .HasColumnName("upadtedDate");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("weight");

            entity.HasOne(d => d.Item).WithMany(p => p.TblStockItemDetails)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_StockItemDetails_ItemMaster");
        });

        modelBuilder.Entity<TblTaxDetail>(entity =>
        {
            entity.HasKey(e => e.TaxDetailsId);

            entity.ToTable("tbl_TaxDetail");

            entity.Property(e => e.TaxDetailsId)
                .ValueGeneratedNever()
                .HasColumnName("taxDetailsId");
            entity.Property(e => e.CDate)
                .HasColumnType("datetime")
                .HasColumnName("cDate");
            entity.Property(e => e.CgstPer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cgst_per");
            entity.Property(e => e.CgstRate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cgst_rate");
            entity.Property(e => e.IgstPer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("igst_per");
            entity.Property(e => e.IgstRate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("igst_rate");
            entity.Property(e => e.SgstPer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sgst_per");
            entity.Property(e => e.SgstRate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sgst_rate");
            entity.Property(e => e.TId).HasColumnName("tId");
            entity.Property(e => e.UDate)
                .HasColumnType("datetime")
                .HasColumnName("uDate");

            entity.HasOne(d => d.TIdNavigation).WithMany(p => p.TblTaxDetails)
                .HasForeignKey(d => d.TId)
                .HasConstraintName("FK_tbl_TaxDetail_tbl_TaxMaster");
        });

        modelBuilder.Entity<TblTaxMaster>(entity =>
        {
            entity.HasKey(e => e.TId).HasName("PK_tbl_TaxDetails");

            entity.ToTable("tbl_TaxMaster");

            entity.Property(e => e.TId).HasColumnName("tId");
            entity.Property(e => e.CDate)
                .HasColumnType("datetime")
                .HasColumnName("cDate");
            entity.Property(e => e.TotalTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalTax");
            entity.Property(e => e.UDate)
                .HasColumnType("datetime")
                .HasColumnName("uDate");
            entity.Property(e => e.VoucherId).HasColumnName("voucherId");
            entity.Property(e => e.VoucherType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("voucherType");
        });

        modelBuilder.Entity<TblTransactionMaster>(entity =>
        {
            entity.HasKey(e => e.TId);

            entity.ToTable("tbl_TransactionMaster");

            entity.Property(e => e.TId).HasColumnName("tId");
            entity.Property(e => e.CrAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("crAmt");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DrAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("drAmt");
            entity.Property(e => e.LedgerId).HasColumnName("ledgerId");
            entity.Property(e => e.LoginId).HasColumnName("loginId");
            entity.Property(e => e.TDate)
                .HasColumnType("datetime")
                .HasColumnName("tDate");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
            entity.Property(e => e.VoucherRefNo).HasColumnName("voucherRefNo");
            entity.Property(e => e.VoucherType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("voucherType");

            entity.HasOne(d => d.Login).WithMany(p => p.TblTransactionMasters)
                .HasForeignKey(d => d.LoginId)
                .HasConstraintName("FK_tbl_TransactionMaster_tbl_UserLogiln");
        });

        modelBuilder.Entity<TblUserLogiln>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserLogin");

            entity.ToTable("tbl_UserLogiln");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.LastLogin)
                .HasColumnType("datetime")
                .HasColumnName("lastLogin");
            entity.Property(e => e.LoginId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("loginId");
            entity.Property(e => e.Password)
                .HasMaxLength(550)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("updateDate");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.TblUserLogilns)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserLogin_UserLogin");
        });

        modelBuilder.Entity<TblUserProfile>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_UserProfile");

            entity.ToTable("tbl_UserProfile");

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.Mobile)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("mobile");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("updateDate");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
