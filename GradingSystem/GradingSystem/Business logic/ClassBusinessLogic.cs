﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradingSystem.DAO;

namespace GradingSystem.Business_logic
{
    class ClassBusinessLogic
    {
        public static Boolean addClass(int cCode, int semester_id, int max_enrollment, int enrollment, DateTime Class_time, int prof_id)
        {
            Boolean success = ClassDAO.addClass(cCode, semester_id, max_enrollment, enrollment, Class_time, prof_id);
            return success;
        }

        public static Boolean updateClass(int cCode, int semester_id, int max_enrollment, int enrollment, DateTime Class_time, int prof_id)
        {
            Boolean success = ClassDAO.updateClass(cCode, semester_id, max_enrollment, enrollment, Class_time, prof_id);
            return success;
        }

        public static Boolean deleteClass(int cCode, int semester_id)
        {
            Boolean success = ClassDAO.deleteClass(cCode, semester_id);
            return success;
        }

        public static List<Class> selectAll()
        {
            return ClassDAO.selectAll();
        }

        public static List<Class> getClassesOfProfessor(int semester_id, int prof_id)
        {
            return ClassDAO.getClassesOfProfessor(semester_id, prof_id);
        }
    }
}
