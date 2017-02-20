namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertInitialDataIntoTables : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO GENRES (Name) VALUES ('Action')");
            Sql("INSERT INTO GENRES (Name) VALUES ('Romance')");
            Sql("INSERT INTO GENRES (Name) VALUES ('Classic')");
            Sql("INSERT INTO VIDEOS (Name, ReleaseDate) VALUES ('Titanic', '1997-10-12')");
            Sql("INSERT INTO VIDEOS (Name, ReleaseDate) VALUES ('Troy', '2004-01-22')");
        }
        
        public override void Down()
        {
            Sql("DELETE GENRES");
            Sql("DELETE VIDEOS");
        }
    }
}
