using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_0302
{
    internal class StudentGpaDTO
    {
        private int _gradeYear = 8;

        private String _semester = "Spring";

        private double _gradeScore = 2.00;

        private String _gpa = "4";

        private int _completedFlag = 0;
        public int gradeYear
        {
            get { return _gradeYear; }
            set { _gradeYear = value; }
        }
        public String semester
        {
            get { return _semester; }
            set { _semester = value; }   
        }
        public double gradeScore
        {
            get { return _gradeScore; }
            set { _gradeScore = value; }
        }
        public String gpa
        {
            get { return _gpa; }
            set
            {
                _gpa = value;
            }   
        }
        public int completedFlag
        {
            get { return _completedFlag; }
            set
            {
                _completedFlag = value;
            }
        }


    }
}
