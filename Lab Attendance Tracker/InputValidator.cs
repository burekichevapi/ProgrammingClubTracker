using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Attendance_Tracker
{
    public static class InputValidator
    {
        public static bool IsStringValid(string s)
        {
            foreach(char c in s)
            {
                if(char.IsNumber(c))
                    return false;
            }
            return true;
        }

        public static bool IsIntValue(string s)
        {
            if(int.TryParse(s, out int i))
                return true;
            return false;
        }
    }
}
