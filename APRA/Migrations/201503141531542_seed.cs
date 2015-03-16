namespace APRA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Caretakers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        ImageLink = c.String(),
                        Name = c.String(),
                        Relationship = c.String(),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Relationship = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.PatientID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Location = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PatientID = c.Int(nullable: false),
                        Week = c.Int(nullable: false),
                        TaskName = c.String(nullable: false),
                        TimeOfDay = c.String(nullable: false),
                        TaskNotes = c.String(),
                        ImageLink = c.String(),
                        Date = c.DateTime(nullable: false),
                        Difficulty = c.Int(),
                        Stress = c.Int(),
                        FeedbackNotes = c.String(),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.PatientID);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.String(nullable: false),
                        Role = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.Tasks", "PatientID", "dbo.Patients");
            DropIndex("dbo.Tasks", new[] { "PatientID" });
            DropIndex("dbo.Contacts", new[] { "PatientID" });
            DropTable("dbo.Permissions");
            DropTable("dbo.Tasks");
            DropTable("dbo.Patients");
            DropTable("dbo.Contacts");
            DropTable("dbo.Caretakers");
        }
    }
}
