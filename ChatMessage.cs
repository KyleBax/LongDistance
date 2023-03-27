namespace LongDistance
{
    internal class ChatMessage
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private DateTime _sentTime;

        public DateTime SentTime
        {
            get { return _sentTime; }
            set { _sentTime = value; }
        }

        private User _sender;

        public User Sender
        {
            get { return _sender; }
            set { _sender = value; }
        }


    }
}
