using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradingSystem.DAO
{
    class Semester_YearDAO
    {
        //Semester_id is auto increment field
        public static Boolean addSemester_Year(int semester_code, string year)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();
            Semester_Year Semester_Year = new Semester_Year
            {
                Semester_code = semester_code,
                Year = year,
            };
            db.Semester_Years.InsertOnSubmit(Semester_Year);
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

        public static Boolean updateSemester_Year(int semester_id, int semester_code, string year)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();
            var query = from sem in db.Semester_Years
                        where sem.Semester_id == semester_id
                        select sem;

            // Execute the query, and change the column values
            // you want to change.
            foreach (Semester_Year sem in query)
            {
                sem.Semester_code = semester_code;
                sem.Year = year;
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

        public static Boolean deleteSemester_Year(int semester_id)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();

            var deleteQuery = from sem in db.Semester_Years
                              where sem.Semester_id == semester_id
                              select sem;

            foreach (var sem in deleteQuery)
            {
                db.Semester_Years.DeleteOnSubmit(sem);
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

        public static List<Semester_Year> selectAll()
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();
            var query = from Semester_Year in db.Semester_Years
                        select Semester_Year;
            return query.ToList<Semester_Year>();
        }
    }
}
