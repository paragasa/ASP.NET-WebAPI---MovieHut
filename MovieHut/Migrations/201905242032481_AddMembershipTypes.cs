namespace MovieHut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypes : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MembershipTypes");
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.MembershipTypes", "Id");
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropPrimaryKey("dbo.MembershipTypes");
            AlterColumn("dbo.MembershipTypes", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Customers", "MembershipTypeId");
            AddPrimaryKey("dbo.MembershipTypes", "Id");
        }
    }
}
