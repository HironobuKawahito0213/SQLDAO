using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_0302
{
    internal class Exec1
    {    static void Main(string[] args) 
        { 
            Person pr = new Person();

            StudentGpaDTO dto = new StudentGpaDTO();

            Console.WriteLine("{0}",dto.semester);

            pr.name = "やまだaaaaaaa";
            pr.age = 18;
            Console.WriteLine("{0}あいう{1}", pr.name, pr.age);

            StudentGpaDAO dao = new StudentGpaDAO();
            string sql1 = "INSERT INTO StudentGPA VALUES(" + dto.gradeYear +",'"  + dto.semester + "'," +  dto.gradeScore + "," +  dto.gpa + "," + dto.completedFlag + ")";
            string sql2 = "SELECT * FROM StudentGPA";
            dao.ExecuteNonQuery(sql1);
            dao.SelectFromTable(sql2);

            dao.InsertDB();

        }
    }
}
