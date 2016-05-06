using System;

namespace Timetable_Manager
{
    [Serializable]
    public class LessonSetUpException : Exception
    {
        public LessonSetUpException() { }
        public LessonSetUpException(string message) : base(message) { }
        public LessonSetUpException(string message, Exception inner) : base(message, inner) { }
        protected LessonSetUpException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}