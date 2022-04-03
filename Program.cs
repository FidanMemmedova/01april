using System;

namespace _04april
{
    class Program
    {
        static void Main(string[] args)
        {
            User Fidan = new User("Fidan Mammadova", "fidanmammadova@gmail.com");
            Fidan.PasswordChecker("B201P@");
            Fidan.ShowInfo(); ;
        }
    }
}
