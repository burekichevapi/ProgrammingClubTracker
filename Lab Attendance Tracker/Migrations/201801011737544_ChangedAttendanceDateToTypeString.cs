namespace Lab_Attendance_Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedAttendanceDateToTypeString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Attendance", "Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Attendance", "Date", c => c.DateTime());
        }
    }
}
