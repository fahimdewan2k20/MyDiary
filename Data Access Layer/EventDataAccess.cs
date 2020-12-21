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

        public List<Event> GetAllEvents(string personName)
        {
            string sql = "SELECT * FROM Events WHERE PersonName='"+ personName +"' ORDER BY Importance DESC";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Event> events = new List<Event>();
            while (reader.Read())
            {
                Event e = new Event();
                e.Id = (int)reader["Id"];
                e.PersonName = personName;
                e.Title = reader["Title"].ToString();
                e.Details = reader["Details"].ToString();
                e.Time = Convert.ToDateTime(reader["Time"].ToString());
                e.LastModification = reader["LastModification"].ToString();
                e.Importance = Convert.ToByte(reader["Importance"]);
                e.PictureName = reader["PictureName"].ToString();
                events.Add(e);
            }
            return events;
        }

        /*public Event GetEvent(int id)
        {
            string sql = "SELECT * FROM Events WHERE Id='+id+'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Event e = new Event();
            e.Id = (int)reader["Id"];
            e.PersonName = reader["PersonName"].ToString();
            e.Title = reader["Title"].ToString();
            e.Details = reader["Details"].ToString();
            e.Time = Convert.ToDateTime(reader["Time"].ToString());
            e.LastModification = reader["LastModification"].ToString();
            e.Importance = Convert.ToByte(reader["Importance"]);
            e.PictureName = reader["PictureName"].ToString();
            return e;
        }*/

        public int AddEvent(Event e)
        {
            string sql = "INSERT INTO Events(PersonName, Title, Details, Importance, PictureName) Values('"+e.PersonName+"', '"+e.Title+"', '"+e.Details+"', '"+e.Importance+"', '"+e.PictureName+"')";
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int ModifyEvent(Event e)
        {
            string sql = "UPDATE Events SET Title='" + e.Title + "', Details='" + e.Details + "', Importance='" + e.Importance + "', LastModification='"+ DateTime.Now.ToString() +"', PictureName='" + e.PictureName + "' WHERE Id='" + e.Id +"'";
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int RemoveEvent(int id)
        {
            string sql = "DELETE FROM Events WHERE Id=" + id;
            int result = dataAccess.ExecuteQuery(sql);
            return result;
        }

       /* public List<Event> GetEventForSearch(string title)
        {
            string sql = "SELECT * FROM Events WHERE Title LIKE '" + title + "%'";
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
                e.LastModification = reader["LastModification"].ToString();
                e.Importance = Convert.ToByte(reader["Importance"]);
                e.PictureName = reader["PictureName"].ToString();
                events.Add(e);
            }
            return events;
        }*/
    }
}
