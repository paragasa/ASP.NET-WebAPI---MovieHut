namespace MovieHut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectionDateOfBirthCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime());
            DropColumn("dbo.Customers", "BrirthDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "BrirthDate", c => c.DateTime());
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
