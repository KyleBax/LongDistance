using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongDistance
{
    internal class TestUsers
    {
        public static List<User> TestUser()
        {

            List<User> users = new List<User>();

            User user1 = new User();
            user1.ID = ID.GenerateID();
            user1.Name = "John Smith";
            user1.Password = "password123";
            user1.Email = "john.smith@example.com";
            user1.TimeZone = TimeZoneInfo.Local;
            user1.DateOfBirth = new DateTime(1990, 1, 1);
            user1.Calendar = new List<CalendarEntry>();
            users.Add(user1);

            User user2 = new User();
            user2.ID = ID.GenerateID();
            user2.Name = "Tony Stark";
            user2.Password = "Iamironman";
            user2.Email = "tony.stark@starkindustries.com";
            user2.TimeZone = TimeZoneInfo.Local;
            user2.DateOfBirth = new DateTime(1990, 1, 1);
            user2.Calendar = new List<CalendarEntry>();
            users.Add(user2);

            User user3 = new User();
            user3.ID = ID.GenerateID();
            user3.Name = "Clint Barton";
            user3.Password = "Arrows";
            user3.Email = "clint@shield.com";
            user3.TimeZone = TimeZoneInfo.Local;
            user3.DateOfBirth = new DateTime(1992, 1, 1);
            user3.Calendar = new List<CalendarEntry>();
            users.Add(user3);

            users.Max(u => u.ID);

            return users;
        }

        public static List<User> TestCalendarEntry(List<User> users)
        {
            CalendarEntry entry1 = new CalendarEntry();
            entry1.Title = "Meeting with client";
            entry1.Details = "Discuss new project proposal";
            entry1.EventDateTime = new DateTime(2023, 3, 15, 14, 0, 0);

            CalendarEntry entry2 = new CalendarEntry();
            entry2.Title = "Dinner reservation";
            entry2.Details = "Reservation for two at fancy restaurant";
            entry2.EventDateTime = new DateTime(2023, 3, 20, 18, 30, 0);


            User user = new User();
            user.Calendar = new List<CalendarEntry>() { entry1, entry2 };


            return users;
        }
    }
}
