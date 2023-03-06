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

        private int _senderUserID;

        public int SenderUserID
        {
            get { return _senderUserID; }
            set { _senderUserID = value; }
        }

        private int _receiverUserID;

        public int ReceiverUserID
        {
            get { return _receiverUserID; }
            set { _receiverUserID = value; }
        }

    }
}
