using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradingSystem.DAO
{
    class ClassDAO
    {
        public static Boolean addClass(int cCode, int semester_id, int max_enrollment, int enrollment, DateTime Class_time)
        {
            GradingSystem_DataClassesDataContext db = new GradingSystem_DataClassesDataContext();
            Class classObj = new Class
            {
                Course_code = cCode,
                Semester_id = semester_id,
                Max_enrollment = max_enrollment,
                Enrollment = enrollment,
                Class_time = Class_time,
            };
            db.Classes.InsertOnSubmit(classObj);
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

        public static Boolean updateClass(int cCode, int semester_id, int max_enrollment, int enrollment, DateTime Class_time)
        {
            GradingSystem_DataClassesDataContext db = new GradingSystem_DataClassesDataContext();

            var query = from c in db.Classes
                        where c.Course_code == cCode && c.Semester_id == semester_id
                        select c;

            // Execute the query, and change the column values
            // you want to change.
            foreach (Class c in query)
            {
                c.Max_enrollment = max_enrollment;
                c.Enrollment = enrollment;
                c.Class_time = Class_time;
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

        public static Boolean deleteClass(int cCode, int semester_id)
        {
            GradingSystem_DataClassesDataContext db = new GradingSystem_DataClassesDataContext();

            var deleteQuery = from c in db.Classes
                              where c.Course_code == cCode && c.Semester_id == semester_id
                              select c;

            foreach (var c in deleteQuery)
            {
                db.Classes.DeleteOnSubmit(c);
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
