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
    }
}
