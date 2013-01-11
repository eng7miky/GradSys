using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradingSystem.DAO
{
    class EnrollmentDAO
    {
        public static Boolean registerStudent(int cCode, int semester_id, int student_id, double year_work, double project_marks, double final_exam, double total_marks)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();
            Enrollment enroll  = new Enrollment
            {
                Course_code = cCode,
                Semester_id = semester_id,
                Student_id = student_id,
                Year_work = (Decimal) year_work,
                Project_marks = (Decimal) project_marks,
                Final_exam = (Decimal) final_exam,
                Total_marks = (Decimal) total_marks
            };
            db.Enrollments.InsertOnSubmit(enroll);
            // Submit the change to the database.
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public static Boolean updateStudent_CourseMarks(int cCode, int semester_id, int student_id, double year_work, double project_marks, double final_exam, double total_marks)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();

            var query = from c in db.Enrollments
                        where c.Course_code == cCode && c.Semester_id == semester_id && c.Student_id == student_id
                        select c;

            // Execute the query, and change the column values
            // you want to change.
            foreach (Enrollment c in query)
            {
                c.Year_work = (Decimal) year_work;
                c.Project_marks = (Decimal) project_marks;
                c.Final_exam = (Decimal) final_exam;
                c.Total_marks = (Decimal) total_marks;
            }

            // Submit the changes to the database.
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public static Boolean unregisterStudent(int cCode, int semester_id, int student_id)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();

            var deleteQuery = from enroll in db.Enrollments
                              where enroll.Course_code == cCode && enroll.Semester_id == semester_id && enroll.Student_id == student_id
                                     select enroll;

            foreach (var enroll in deleteQuery)
            {
                db.Enrollments.DeleteOnSubmit(enroll);
            }

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
                // Provide for exceptions.
            }
        }
    }
}
