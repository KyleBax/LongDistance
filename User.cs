namespace LongDistance
{
    internal class User
    {
        private int _name;

        public int Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private TimeZoneInfo _timeZone;

        public TimeZoneInfo TimeZone
        {
            get { return _timeZone; }
            set { _timeZone = value; }
        }

        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        private List<CalanderEntry> _calendar;   

        public List<CalanderEntry> Calendar
        {
            get { return _calendar; }
            set { _calendar = value; }
        }

    }
}
