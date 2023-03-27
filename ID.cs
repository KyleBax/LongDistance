namespace LongDistance
{
    internal class ID
    {
        private static int _highestID = 0;

        public static int GenerateID()
        {
            int newID = _highestID + 1;
            _highestID = newID;
            return newID;
        }
    }
}
