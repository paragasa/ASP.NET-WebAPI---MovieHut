namespace MovieHut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (0, 'Unknown')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Documentary')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Children')");
        }
        
        public override void Down()
        {
        }
    }
}
