namespace LongDistance
{
    internal class Chat
    {
        private List<string> _messagesSent;

        public List<string> MessagesSent
        {
            get { return _messagesSent; }
            set { _messagesSent = value; }
        }


        private List<string> _messagesRecieved;

        public List<string> MessagesRecieved
        {
            get { return _messagesRecieved; }
            set { _messagesRecieved = value; }
        }


    }
}
