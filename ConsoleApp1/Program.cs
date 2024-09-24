using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User { Login = "user1", Email = "em1@gmail.com" };
            User user2 = new User { Login = "user2", Email = "em2@gmail.com" };

            Meeting meeting = new Meeting
            {
                Date = "20.09.2024",
                Desc = "Збори",
                StartTime = "13:00",
                EndTime = "15:00"

            };

            Birthday birthday = new Birthday
            {
                Date = "24.10.2024",
                Desc = "user1's день народження",
                BirthdayPersonContact = "em1@gmail.com"
            };

            Calendar calendar = new Calendar();
            calendar.AddEvent(meeting);
            calendar.AddEvent(birthday);

            calendar.DisplayEvents();
        }
    }
}