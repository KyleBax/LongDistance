namespace LongDistance
{
    internal class CalendarEntry
    {
        private List<string> _birthdays;

        public List<string> Birthdays
        {
            get { return _birthdays; }
            set { _birthdays = value; }
        }

        private List<string> _events;

        public List<string> Events
        {
            get { return _events; }
            set { _events = value; }
        }

        private List<string> _holidays;

        public List<string> Holidays
        {
            get { return _holidays; }
            set { _holidays = value; }
        }



    }
}
