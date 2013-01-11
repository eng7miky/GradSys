using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradingSystem.DAO
{
    class StudentDAO
    {
        //student_id is auto increment field
        public static Boolean addStudent(string fName, string lName, string address, bool gender, DateTime dob, int dept_no)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();
            Student student = new Student
            {
                First_name = fName,
                Last_name = lName,
                Address = address,
                Gender = gender,
                DOB = dob,
                Dept_no = dept_no,
            };
            db.Students.InsertOnSubmit(student);
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

        public static Boolean updateStudent(int student_id, string fName, string lName, string address, bool gender, DateTime dob, int dept_no)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();
            var query = from stud in db.Students
                        where stud.Student_id == student_id
                        select stud;

            // Execute the query, and change the column values
            // you want to change.
            foreach (Student stud in query)
            {
                stud.First_name = fName;
                stud.Last_name = lName;
                stud.Address = address;
                stud.Gender = gender;
                stud.DOB = dob;
                stud.Dept_no = dept_no;
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

        public static Boolean deleteStudent(int student_id)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();

            var deleteQuery = from stud in db.Students
                              where stud.Student_id == student_id
                              select stud;

            foreach (var stud in deleteQuery)
            {
                db.Students.DeleteOnSubmit(stud);
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

        public static List<Student> selectAll()
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();
            var query = from student in db.Students
                        select student;
            return query.ToList<Student>();
        }
    }
}
