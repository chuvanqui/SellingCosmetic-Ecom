﻿namespace WebsiteSellingCosmetic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertReviewProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReviewProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        UserName = c.String(),
                        FullName = c.String(),
                        Email = c.String(),
                        Content = c.String(),
                        Rate = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Avatar = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReviewProducts");
        }
    }
}
