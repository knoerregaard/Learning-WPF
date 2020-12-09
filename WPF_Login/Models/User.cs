using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Login.Models
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        private bool isAuthenticated;

        public bool IsAuthenticated
        {
            get { return isAuthenticated; }
        }



        public bool Login(string username, string password)
        {
            if ((username != null && password != null) && username == "klaus" && password == "12345")
            {
                isAuthenticated = true;

            }
            else
            {
                isAuthenticated = false;
            }
            return IsAuthenticated;
        }    


        
    }
}
