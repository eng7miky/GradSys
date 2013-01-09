using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradingSystem.DAO;

namespace GradingSystem.Business_logic
{
    class StudentBusinessLogic
    {
        public static Boolean addStudent(string fName, string lName, string address, bool gender, DateTime dob, int dept_no)
        {
            Boolean success = StudentDAO.addStudent(fName, lName, address, gender, dob, dept_no);
            return success;
        }

        public static Boolean updateStudent(int student_id, string fName, string lName, string address, bool gender, DateTime dob, int dept_no)
        {
            Boolean success = StudentDAO.updateStudent(student_id, fName, lName, address, gender, dob, dept_no);
            return success;
        }

        public static Boolean deleteStudent(int student_id)
        {
            Boolean success = StudentDAO.deleteStudent(student_id);
            return success;
        }
    }
}
