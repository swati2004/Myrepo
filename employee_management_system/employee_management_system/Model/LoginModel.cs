using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace employee_management_system.Model
{
    public class LoginModel:IDataErrorInfo
    {
        #region Declaration
        private string username;
        private string password;
        #endregion

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string propertyName]
        {
            get
            {
                return GetValidationError(propertyName);
            }
        }

        public string funusername()
        {
            if (string.IsNullOrEmpty(Username))
            {
                return "Please enter username";
            }
            return null;
        }
        public string funpassword()
        {
            if (string.IsNullOrEmpty(Password))
            {
                return "Please enter password";
            }
            return null;
        }

        string GetValidationError(string propertyName)
        {
            string error = null;
            switch (propertyName)
            {
                case "Username":
                    error = funusername();
                    break;
                case "Password":
                    error = funpassword();
                    break;
            }
            return error;
        }

    }
}