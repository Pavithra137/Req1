using System;
using System.Collections.Generic;
using System.Text;

namespace Storybook
{
    class User
    {
        private string username, mailid, password;

        public User(string username, string mailid, string password)
        {
            this.username = username;
            this.mailid = mailid;
            this.password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Mailid { get => mailid; set => mailid = value; }
        public string Password { get => password; set => password = value; }
        public override string ToString()
        {
            return String.Format("Username : {0} \nMailid : {1} \nPassword : {2}", Username, Mailid, Password);
        }
        public override bool Equals(object obj)
        {
            User obje= (User)obj;
            return this.username.Equals(obje.Username);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
   
}
