using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradingSystem.DAO;

namespace GradingSystem.Business_logic
{
    class CourseBusinessLogic
    {
        public static Boolean addCourse(int cCode, string cName, int credit_hours, int prof_id)
        {
            Boolean success = CourseDAO.addCourse(cCode, cName, credit_hours);
            return success;
        }

        public static Boolean updateCourse(int cCode, string cName, int credit_hours, int prof_id)
        {
            Boolean success = CourseDAO.updateCourse(cCode, cName, credit_hours);
            return success;
        }

        public static Boolean deleteCourse(int cCode)
        {
            Boolean success = CourseDAO.deleteCourse(cCode);
            return success;
        }

        public static List<Course> selectAll()
        {
            return CourseDAO.selectAll();
        }

    }
}

