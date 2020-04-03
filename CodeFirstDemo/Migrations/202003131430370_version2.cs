namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Firstname", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.People", "Lastname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.People", "DateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.People", "Lastname", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.People", "Firstname", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
