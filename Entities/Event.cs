using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary.Entities
{
    class Event
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime Time { get; set; }
        public DateTime LastModification { get; set; }
        public char Importance { get; set; }
        public string Picture { get; set; }
    }
}
