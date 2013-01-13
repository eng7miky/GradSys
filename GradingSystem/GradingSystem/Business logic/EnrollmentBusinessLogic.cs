using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradingSystem.DAO;

namespace GradingSystem.Business_logic
{
    class EnrollmentBusinessLogic
    {
        public static Boolean registerStudent(int cCode, int semester_id, int student_id, double year_work, double project_marks, double final_exam, double total_marks)
        {
            Boolean success = EnrollmentDAO.registerStudent(cCode, semester_id, student_id, year_work, project_marks, final_exam, total_marks);
            return success;
        }

        public static Boolean updateStudent_CourseMarks(int cCode, int semester_id, int student_id, double year_work, double project_marks, double final_exam, double total_marks)
        {
            Boolean success = EnrollmentDAO.updateStudent_CourseMarks(cCode, semester_id, student_id, year_work, project_marks, final_exam, total_marks);
            return success;
        }

        public static Boolean unregisterStudent(int cCode, int semester_id, int student_id)
        {
            Boolean success = EnrollmentDAO.unregisterStudent(cCode, semester_id, student_id);
            return success;
        }

        public static List<Student> getStudentsOFClass(int cCode, int semester_id)
        {
            List<Student> students = EnrollmentDAO.getStudentsOFClass(cCode, semester_id);
            return students;
        }

        public static List<GradingSystem.DAO.EnrollmentDAO.Student_Grades> getStudentsGradesOFClass(int cCode, int semester_id)
        {
            List<GradingSystem.DAO.EnrollmentDAO.Student_Grades> students = EnrollmentDAO.getStudentsGradesOFClass(cCode, semester_id);
            return students;
        }

        public static List<Enrollment> getEnrollmentsOFClass(int cCode, int semester_id)
        {
            List<Enrollment> enrollements = EnrollmentDAO.getEnrollmentsOFClass(cCode, semester_id);
            return enrollements;
        }
 
    }
}
