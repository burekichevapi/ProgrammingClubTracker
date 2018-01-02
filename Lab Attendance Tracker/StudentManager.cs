using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using Lab_Attendance_Tracker.Tables.StudentTable;


namespace Lab_Attendance_Tracker
{
    public class StudentManager
    {
        private LabAttendanceContext context = new LabAttendanceContext();
        private Student student;

        public bool IsCheckedIn(int id)
        {
            if(IsStudentInDb(id))
            {
                student = context.Students.Single(s => s.StudentId == id);
                AddTallyForCheckIn();
                AddLastCheckInDate();
                context.SaveChanges();
                return true;
            }
            return false;
        }



        public bool AddNewStudent(int id, string firstName, string lastname)
        {
            if (!IsStudentInDb(id))
            {
                student = new Student
                {
                    StudentId = id,
                    FirstName = firstName,
                    LastName = lastname,
                    LastCheckInDate = DateTime.Now,
                    TotalCheckIns = 1
                };
                context.Students.Add(student);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Student GetStudent(int id)
        {
            if(IsStudentInDb(id))
                return student = context.Students.Single(s => s.StudentId == id);
            return null;
        }

            private bool IsStudentInDb(int id)
            {
                return context.Students.Any(s => s.StudentId == id);
            }

            private void AddTallyForCheckIn()
            {
                student.TotalCheckIns++;
            }

            private void AddLastCheckInDate()
            {
                student.LastCheckInDate = DateTime.Now;
            }


    }
}
