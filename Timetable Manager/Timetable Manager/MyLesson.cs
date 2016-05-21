using System;
using System.Text;

namespace Timetable_Manager
{ 
    public sealed class MyLesson
    {
        public String Name { get; set; }
        public TimeSpan TimeRest { get; set; }
        public String Id { get; set; }
        public StringBuilder Comments { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", Name, TimeRest);
        }
    }
}