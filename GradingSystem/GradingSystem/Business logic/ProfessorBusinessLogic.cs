using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradingSystem.DAO;

namespace GradingSystem.Business_logic
{
    class ProfessorBusinessLogic
    {
        public static Professor getProfessor(string username, string password)
        {
            return ProfessorDAO.getProfessor(username, password);

        }

        public static List<Professor> selectAll()
        {
            return ProfessorDAO.selectAll();
        }
    }
}
