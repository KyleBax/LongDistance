namespace LongDistance
{
    internal class Chat
    {
        private List<string> _meassages;

        public List<string> Messages
        {
            get { return _meassages; }
            set { _meassages = value; }
        }


        private int _sentByUserID;

        public int SentByUserID
        {
            get { return _sentByUserID; }
            set { _sentByUserID = value; }
        }


    }
}
