namespace Student.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "Code", c => c.String(maxLength: 20));
            AlterColumn("dbo.Student", "FirstName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Student", "LastName", c => c.String(maxLength: 255));
            CreateIndex("dbo.Student", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Student", new[] { "Code" });
            AlterColumn("dbo.Student", "LastName", c => c.String());
            AlterColumn("dbo.Student", "FirstName", c => c.String());
            AlterColumn("dbo.Student", "Code", c => c.String());
        }
    }
}
