﻿//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class STTPEntities : DbContext
{
    public STTPEntities()
        : base("name=STTPEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public DbSet<MemberData> MemberData { get; set; }
    public DbSet<SchoolData> SchoolData { get; set; }
    public DbSet<ShopData> ShopData { get; set; }
    public DbSet<ShopGoods> ShopGoods { get; set; }
    public DbSet<ShopGoodsCategory> ShopGoodsCategory { get; set; }
    public DbSet<ShopGoodsPic> ShopGoodsPic { get; set; }
    public DbSet<ShopGoodsSubCategory> ShopGoodsSubCategory { get; set; }
    public DbSet<StdntGoodsCategory> StdntGoodsCategory { get; set; }
    public DbSet<StdntGoodsPic> StdntGoodsPic { get; set; }
    public DbSet<StdntGoodsSubCategory> StdntGoodsSubCategory { get; set; }
    public DbSet<WishDetail> WishDetail { get; set; }
    public DbSet<WishList> WishList { get; set; }
    public DbSet<StdntGoodsView> StdntGoodsView { get; set; }
    public DbSet<GoodsOrderDetails> GoodsOrderDetails { get; set; }
    public DbSet<ProductOrder> ProductOrder { get; set; }
    public DbSet<StdntGoods> StdntGoods { get; set; }
    public DbSet<AdManagement> AdManagement { get; set; }
}
