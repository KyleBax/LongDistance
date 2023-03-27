namespace LongDistance
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool isTest = true;

            if (isTest)
            {
                List<User> users = TestUsers.TestUser();
                users = TestUsers.TestCalendarEntry(users);
                foreach(User user in users)
                {
                    foreach (CalendarEntry c in user.Calendar)
                    {

                    }

                }

                var x = new List<ChatMessage>();


            }

        }
    }
}