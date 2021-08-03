using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_11
{
    class User
    {
        private string password;
        private string userName;
        private bool isLogin;
        static User[] users = new User[5];

        public static int Login(string name, string pass)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].userName == name && users[i].password == pass)
                {
                    users[i].isLogin = true;
                    return i;
                }
            }
            return 8;
        }
        public void Logout(User u)
        {
            u.isLogin = false;
        }

    }
}
