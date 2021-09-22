using employee_management_system.Model;
using employee_management_system.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace employee_management_system.ViewModel
{
   public class LoginViewModelCommand
    {
        SqlDataReader dr;
        public ICommand mycommand { get; set; }
        public LoginModel login { get; set; }

        public LoginViewModelCommand()
        {
            mycommand = new command(executeMethod, canexecuteMethod);
            login = new LoginModel { };

        }

        public bool canexecuteMethod(object parameter)
        {
            return true;
        }

        DataAccessLayer d = new DataAccessLayer();
        public void executeMethod(object parameter)
        {
            switch (parameter)
            {
                case "Select":
                    dr = d.FunSQLDataReader("exec usp_check '" + login.Username + "', '" + login.Password + "'");
                    if (dr.HasRows)
                    {
                        MainPage m = new MainPage();
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect");
                    }
                    break;
                case "Exitbtn":
                    LoginView lo = new LoginView();
                    lo.Close();
                    break;
            

            }
        }
    }
}
