using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradingSystem.DAO;

namespace GradingSystem.Business_logic
{
    class DepartmentBusinessLogic
    {
        
        public static List<Department> selectAll()
        {
            return DepartmentDAO.selectAll();
        }
    }
}
