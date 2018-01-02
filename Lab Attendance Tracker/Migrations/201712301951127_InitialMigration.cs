namespace Lab_Attendance_Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendance",
                c => new
                    {
                        AttendanceID = c.Int(name: "Attendance ID", nullable: false, identity: true),
                        Date = c.DateTime(),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AttendanceID)
                .ForeignKey("dbo.Student", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.Int(name: "Student ID", nullable: false),
                        LastName = c.String(name: "Last Name", maxLength: 16),
                        FirstName = c.String(name: "First Name", maxLength: 16),
                        LastCheckin = c.DateTime(name: "Last Check-in"),
                        TotalCheckins = c.Int(name: "Total Check-ins", nullable: false),
                        Attendance_AttendanceId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Attendance", t => t.Attendance_AttendanceId)
                .Index(t => t.Attendance_AttendanceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendance", "StudentId", "dbo.Student");
            DropForeignKey("dbo.Student", "Attendance_AttendanceId", "dbo.Attendance");
            DropIndex("dbo.Student", new[] { "Attendance_AttendanceId" });
            DropIndex("dbo.Attendance", new[] { "StudentId" });
            DropTable("dbo.Student");
            DropTable("dbo.Attendance");
        }
    }
}
