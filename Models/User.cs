using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB21.Models
{
    public class User
    {
        private string userName;
        private string email;
        private string password;
        private string personalWeb;
        private string digitz;

        public string UserName
        {
            set
            {
                userName = value;
            }
            get
            {
                return userName;
            }
        }
        public string Email
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }
        }
        public string Password
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }
        public string PersonalWeb
        {
            set
            {
                personalWeb = value;
            }
            get
            {
                return personalWeb;
            }
        }
        public string Digitz
        {
            set
            {
                digitz = value;
            }
            get
            {
                return digitz;
            }
        }

        public User()
        {

        }

        public User(string _userName, string _email, string _password, string _personalWeb, string _digitz)
        {
            UserName = _userName;
            Email = _email;
            Password = _password;
            PersonalWeb = _personalWeb;
            Digitz = _digitz;

        }

    }
}