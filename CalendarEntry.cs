namespace LongDistance
{
    internal class CalendarEntry
    {
        private DateTime _eventDateTime;

        public DateTime EventDateTime
        {
            get { return _eventDateTime; }
            set { _eventDateTime = value; }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


        private string _details;

        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }

        //unsure about this one, will think about this part of it further
        private bool _specialEvent;

        public bool SpecialEvent
        {
            get { return _specialEvent; }
            set { _specialEvent = value; }
        }



    }
}
