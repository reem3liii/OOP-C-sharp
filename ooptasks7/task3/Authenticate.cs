using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Authenticate
    {
        public Student Std { get; set; }
        public bool Login(string userName, string pass, string email)
        {
            if(Std.UserName == userName && Std.UserPass == pass && Std.Email == email)
                return true;
            else return false;
        }
        public bool Login(string email, string pass)
        {
            if ( Std.UserPass == pass && Std.Email == email)
                return true;
            else return false;
        }
        public bool Login(int id, string pass)
        {
            if (Std.UserPass == pass && Std.ID == id)
                return true;
            else return false;
        }
        public bool Login(string email, int id)
        {
            if (Std.Email == email && Std.ID == id)
                return true;
            else return false;
        }
        public string ForgetPass(string userName)
        {
            if(userName==Std.UserName) 
                return Std.UserPass;
            else
                return "User not found!";
        }
        public string ForgetPass(string email, int id)
        {
            if (email == Std.Email && id == Std.ID)
                return Std.UserPass;
            else
                return "User not found!";
        }
        public string ForgetPass(int id)
        {
            if (id == Std.ID)
                return Std.UserPass;
            else
                return "User not found!";
        }
        public bool ResetPass(int id, string oldPass, string newPass)
        {
            if(Std.ID == id && Std.UserPass == oldPass)
            {
                Std.UserPass = newPass;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ResetPass(string email, string oldPass, string newPass)
        {
            if (Std.Email == email && Std.UserPass == oldPass)
            {
                Std.UserPass = newPass;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ResetPass(int id,string userName, string oldPass, string newPass)
        {
            if (Std.ID == id && Std.UserName == userName && Std.UserPass == oldPass)
            {
                Std.UserPass = newPass;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
