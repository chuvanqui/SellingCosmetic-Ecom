﻿namespace WebsiteSellingCosmetic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpadteProduct : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "PriceSale", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "PriceSale", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
