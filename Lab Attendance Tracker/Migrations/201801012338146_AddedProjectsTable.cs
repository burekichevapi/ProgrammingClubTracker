namespace Lab_Attendance_Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProjectsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectName = c.String(name: "Project Name", nullable: false, maxLength: 32),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ProjectName);
            
            CreateTable(
                "dbo.Students Projects",
                c => new
                    {
                        ProjectName = c.String(name: "Project Name", nullable: false, maxLength: 32),
                        StudentID = c.Int(name: "Student ID", nullable: false),
                    })
                .PrimaryKey(t => new { t.ProjectName, t.StudentID })
                .ForeignKey("dbo.Projects", t => t.ProjectName, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.ProjectName)
                .Index(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students Projects", "Student ID", "dbo.Student");
            DropForeignKey("dbo.Students Projects", "Project Name", "dbo.Projects");
            DropIndex("dbo.Students Projects", new[] { "Student ID" });
            DropIndex("dbo.Students Projects", new[] { "Project Name" });
            DropTable("dbo.Students Projects");
            DropTable("dbo.Projects");
        }
    }
}
