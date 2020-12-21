using MyDiary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary.Data_Access_Layer
{
    class PersonDataAccess
    {
        DataAccess dataAccess;

        public PersonDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public bool LoginValidation(string personName, string password)
        {
            string sql = "SELECT * FROM Persons WHERE PersonName='" + personName + "' AND Password='" + password + "'";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            if (reader.Read())
                return true;
            else
                return false;
        }

        public int AddNewPerson(Person person)
        {
            string sql = "SELECT * FROM Persons WHERE PersonName='"+person.PersonName+"'";
            SqlDataReader reader = dataAccess.GetData(sql);
            if (reader.Read())
            {
                return 0;
            }
            sql = "INSERT INTO Persons(PersonName, Password) VALUES('"+person.PersonName+"', '"+person.Password+"')";
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }
    }
}
