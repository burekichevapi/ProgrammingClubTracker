using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Attendance_Tracker
{
    public partial class Registration:Form
    {
        private readonly StudentManager studentManager = new StudentManager();
        private readonly AttendanceManager attendanceManager = new AttendanceManager(); 
        public Registration()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(InputValidator.IsIntValue(studentNumTextBox.Text)
               && InputValidator.IsStringValid(firstNameTextBox.Text)
               && InputValidator.IsStringValid(lastNameTextBox.Text))
                if(!String.IsNullOrEmpty(firstNameTextBox.Text) && !String.IsNullOrEmpty(lastNameTextBox.Text))
                {
                    if (studentManager.AddNewStudent(int.Parse(studentNumTextBox.Text), firstNameTextBox.Text,
                        lastNameTextBox.Text))
                    {
                        attendanceManager.AddAttendance(int.Parse(studentNumTextBox.Text));
                        MessageBox.Show($"Welcome {firstNameTextBox.Text}!", "Registration Successful");
                        this.Close();
                    }
                    else
                        MessageBox.Show("There is already a user with this ID.", "Registration");
                }
                else
                    MessageBox.Show("Please fill the registration form in correctly", "Registration Error");
            else
                MessageBox.Show("Please fill the registration form in correctly", "Registration Error");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
