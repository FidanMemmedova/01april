using System;
using System.Collections.Generic;
using System.Text;

namespace _04april
{
    class User : IAccount
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public bool isUpper;
        public bool isLower;
        public bool isNumber;

        public User(string fullname, string email)
        {
            Fullname = fullname;
            Email = email;
        }
        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8)
            {
                foreach (var item in password)
                {
                    if (char.IsUpper((item)))
                    {
                        isUpper = true;
                    }
                    if (char.IsLower((item)))
                    {
                        isLower = true;
                    }
                    if (char.IsNumber((item)))
                    {
                        isNumber = true;
                    }
                }
                if (isUpper && isLower && isNumber)
                {
                    Console.WriteLine("Parol duzgun yazilmisdir");
                    return true;
                }
                else
                {

                    Console.WriteLine("Parolun yazisilinda sehvlik var");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Parolun uzunlugu en azi 8 xarakterli olmalidir");
                return false;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Fullname : {Fullname} Email : {Email}"); ;
        }
    }
}


