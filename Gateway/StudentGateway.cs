using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tuto7.Models;
using System.Data;
using System.Data.SqlClient;
namespace Tuto7.Gateway
{
    public class StudentGateway
    {
        public List<Student> GetStudents()
        {

            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-059A10P\SQLEXPRESS;Database=ASPCRUD;Integrated Security=true;");


            string query = "SELECT * FROM Student_tb";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Student> students = new List<Student>();
            while (reader.Read())
            {

                Student student = new Student();
                student.Name = reader["Name"].ToString();
                student.Mobile = reader["Mobile"].ToString();
                students.Add(student); // students collection e sokal stdn add korsi
            }
            connection.Close();
            return students;
        }


        public List<Department> GetDepartments()
        {


            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-059A10P\SQLEXPRESS;Database=ASPCRUD;Integrated Security=true;");


            string query = "SELECT * FROM Department_td";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Department> departments = new List<Department>(); 

            while (reader.Read())


            {
                Department department = new Department();

                department.Id = (int)reader["Id"];
                department.ShortName = reader["ShortName"].ToString();
                departments.Add(department);

            }
            connection.Close();
            return departments;

        }

        private void ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}
