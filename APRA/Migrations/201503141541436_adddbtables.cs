namespace APRA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddbtables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Name", c => c.String());
            AlterColumn("dbo.Contacts", "Phone", c => c.String());
            AlterColumn("dbo.Contacts", "Relationship", c => c.String());
            AlterColumn("dbo.Patients", "Name", c => c.String());
            AlterColumn("dbo.Patients", "Location", c => c.String());
            AlterColumn("dbo.Tasks", "TaskName", c => c.String());
            AlterColumn("dbo.Tasks", "TimeOfDay", c => c.String());
            AlterColumn("dbo.Permissions", "UserID", c => c.String());
            AlterColumn("dbo.Permissions", "Role", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Permissions", "Role", c => c.String(nullable: false));
            AlterColumn("dbo.Permissions", "UserID", c => c.String(nullable: false));
            AlterColumn("dbo.Tasks", "TimeOfDay", c => c.String(nullable: false));
            AlterColumn("dbo.Tasks", "TaskName", c => c.String(nullable: false));
            AlterColumn("dbo.Patients", "Location", c => c.String(nullable: false));
            AlterColumn("dbo.Patients", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Relationship", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Name", c => c.String(nullable: false));
        }
    }
}
