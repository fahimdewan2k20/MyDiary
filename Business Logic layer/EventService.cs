using MyDiary.Data_Access_Layer;
using MyDiary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary.Business_Logic_layer
{
    class EventService
    {
        EventDataAccess eventDataAccess;
        public EventService()
        {
            eventDataAccess = new EventDataAccess();
        }

        public List<Event> GetEventList(string personName)
        {
            return eventDataAccess.GetAllEvents(personName);
        }

        public int AddNewEvent(string personName, string title, string details, byte importance, string pictureName)
        {
            Event e = new Event()
            {
                PersonName = personName,
                Title = title,
                Details = details,
                Importance = importance,
                PictureName = pictureName
            };
            eventDataAccess = new EventDataAccess();
            return this.eventDataAccess.AddEvent(e);
        }

        public int RemoveEvent(int id)
        {
            return this.eventDataAccess.RemoveEvent(id);
        }
        
        public int ModifyEvent(int id, string personName, string title, string details, byte importance, string pictureName)
        {
            Event e = new Event()
            {
                Id = id,
                PersonName = personName,
                Title = title,
                Details = details,
                Importance = importance,
                PictureName = pictureName
            };
            return this.eventDataAccess.ModifyEvent(e);
        }

    /*    public List<Product> GetProduct(string productName)
        {
            return this.productDataAccess.GetProductForSearch(productName);
        }
    }*/
    }
}
