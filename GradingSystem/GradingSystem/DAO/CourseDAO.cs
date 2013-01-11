using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradingSystem.DAO
{
    class CourseDAO
    {
        public static Boolean addCourse(int cCode, string cName, int credit_hours, int prof_id)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();
            Course course = new Course
            {
                Course_code = cCode,
                Course_name = cName,
                Credit_hours = credit_hours,
                Professor_id = prof_id
            };
            db.Courses.InsertOnSubmit(course);
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

        public static Boolean updateCourse(int cCode, string cName, int credit_hours, int prof_id)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();

            var query = from c in db.Courses 
                        where c.Course_code == cCode
                        select c;

            // Execute the query, and change the column values
            // you want to change.
            foreach (Course c in query)
            {
                c.Credit_hours = credit_hours;
                c.Professor_id = prof_id;
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

        public static Boolean deleteCourse(int cCode)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();

            var deleteQuery = from c in db.Courses
                              where c.Course_code == cCode
                              select c;

            foreach (var c in deleteQuery)
            {
                db.Courses.DeleteOnSubmit(c);
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

        public static List<Course> selectAll()
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();
            var query = from course in db.Courses
                        select course;
            return query.ToList<Course>();
        }
    }
}
