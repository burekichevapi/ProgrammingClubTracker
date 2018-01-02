using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Lab_Attendance_Tracker
{
    public partial class MainForm:Form
    {
        private readonly StudentManager studentManager = new StudentManager();
        private readonly AttendanceManager attendanceManager = new AttendanceManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            if (InputValidator.IsIntValue(studentNumberTextBox.Text))
            {
                int id = int.Parse(studentNumberTextBox.Text);
                if (studentManager.IsCheckedIn(id))
                {
                    var s = studentManager.GetStudent(id);
                    attendanceManager.UpdateDate(id);
                    MessageBox.Show($"Welcome back {s.FirstName}, this is visit number {s.TotalCheckIns}!", "Checked-in");
                }
                else
                    MessageBox.Show("Could not find this student number. Register or try again.", "Invalid Input");
                studentNumberTextBox.Text = "";
            }
            else
                MessageBox.Show("Please input your student number or register.", "Invalid Input");
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Registration registerForm = new Registration();
            registerForm.ShowDialog();
        }
    }
}
