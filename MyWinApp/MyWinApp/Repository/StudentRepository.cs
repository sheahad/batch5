using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWinApp.Models;

namespace MyWinApp.Repository
{
    public class StudentRepository
    {
        string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS; Database=StudentDB; Integrated Security=True";
        private SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;

        public DataTable LoadDistrict()
        {
            sqlConnection = new SqlConnection(connectionString);

            commandString = @"SELECT * FROM Districts";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.SelectCommand = sqlCommand;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //    districtComboBox.DataSource = dataTable;

            sqlConnection.Close();
            return dataTable;
        }

        public DataTable ShowStudents()
        {
            commandString = @"SELECT * FROM StudentsView";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.SelectCommand = sqlCommand;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //    displayDataGridView.DataSource = dataTable;

            sqlConnection.Close();

            return dataTable;

        }

        public DataTable SearchStudents(Student student)
        {
            commandString = @"SELECT * FROM StudentsView WHERE RollNo LIKE '%"+student.RollNo+"%'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.SelectCommand = sqlCommand;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //    displayDataGridView.DataSource = dataTable;

            sqlConnection.Close();

            return dataTable;

        }

        public int InsertStudent(Student student)
        {
            commandString = @"INSERT INTO Students (RollNo, Name, Age, Address, DistrictID) VALUES ('" + student.RollNo + "', '" + student.Name + "', " + student.Age + ", '" + student.Address + "'," + student.DistrictID + ")";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();
            
           

            sqlConnection.Close();

            return isExecuted;
        }

        public int UpdateStudent(Student student)
        {
            commandString = @"UPDATE Students SET Name='"+student.Name+"', Age="+student.Age+", Address='"+student.Address+"', DistrictID="+ student.DistrictID + " WHERE RollNo='"+student.RollNo+"'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;
            isExecuted = sqlCommand.ExecuteNonQuery();



            sqlConnection.Close();

            return isExecuted;
        }
    }
}
