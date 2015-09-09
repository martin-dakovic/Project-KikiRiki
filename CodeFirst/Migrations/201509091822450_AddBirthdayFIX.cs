namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayFIX : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Subjects", "BirthDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subjects", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Students", "BirthDate");
        }
    }
}
