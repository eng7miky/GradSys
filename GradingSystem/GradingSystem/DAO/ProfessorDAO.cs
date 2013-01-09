using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradingSystem.DAO
{
    class ProfessorDAO
    {
        public static Professor getProfessor(string username, string password)
        {
            GradingSystem_DataClassesDataContext db = new GradingSystem_DataClassesDataContext();
            var query = from prof in db.Professors
                        where prof.Username == username && prof.Password == password
                        select prof;

            return query.First<Professor>();

        }
    }
}
