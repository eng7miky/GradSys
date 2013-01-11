using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradingSystem.DAO
{
    class ProfessorDAO
    {
        //prof_id is auto increment field
        public static Professor getProfessor(string username, string password)
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();
            var query = from prof in db.Professors
                        where prof.Username == username && prof.Password == password
                        select prof;
            if (query.Count() == 0)
                return null;

            return query.First<Professor>();

        }
        public static List<Professor> selectAll()
        {
            GradingSys_DataClassesDataContext db = new GradingSys_DataClassesDataContext();
            var query = from prof in db.Professors
                         select prof;

            return query.ToList<Professor>();

        }

    }
}
