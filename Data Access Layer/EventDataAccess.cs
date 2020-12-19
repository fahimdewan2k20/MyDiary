using MyDiary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary.Data_Access_Layer
{
    class EventDataAccess
    {
        DataAccess dataAccess;

        public EventDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Event> GetAllEvents()
        {
            string sql = "SELECT * FROM Events";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Event> events = new List<Event>();
            while (reader.Read())
            {
                Event e = new Event();
                e.Id = (int)reader["Id"];
                e.PersonName = reader["PersonName"].ToString();
                e.Title = reader["Title"].ToString();
                e.Details = reader["Details"].ToString();
                e.Time = Convert.ToDateTime(reader["Time"].ToString());
                e.LastModification = Convert.ToDateTime(reader["LastModification"].ToString());
                e.Picture = reader["PictureName"].ToString();
                events.Add(e);
            }
            return events;
        }
    }
}
