using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradingSystem.DAO;

namespace GradingSystem.Business_logic
{
    class Semester_YearBusinessLogic
    {
        public static Boolean addSemester_Year(int semester_id, int semester_code, string year)
        {
            return Semester_YearDAO.addSemester_Year(semester_code, year);
        }

        public static Boolean updateSemester_Year(int semester_id, int semester_code, string year)
        {
            return Semester_YearDAO.updateSemester_Year(semester_id, semester_code, year);
        }

        public static Boolean deleteSemester_Year(int semester_id)
        {
            return Semester_YearDAO.deleteSemester_Year(semester_id);
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
