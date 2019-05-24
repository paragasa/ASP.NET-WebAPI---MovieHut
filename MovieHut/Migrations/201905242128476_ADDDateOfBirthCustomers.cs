namespace MovieHut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDDateOfBirthCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BrirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BrirthDate");
        }
    }
}
