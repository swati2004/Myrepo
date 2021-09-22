using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Input;
using employee_management_system.Model;
using System.Windows;
using employee_management_system.View;

namespace employee_management_system.ViewModel
{
    class MainPageViewModel
    {
       
        public ICommand mycommand1 { get; set; }
       
        public MainPageViewModel()
        {
            mycommand1 = new command(executeMethod, canexecuteMethod);
           

        }

        public bool canexecuteMethod(object parameter)
        {
            return true;
        }

      
        public void executeMethod(object parameter)
        {
            switch (parameter)
            {
                case "Manage_emp":
                    ManageEmployeeView m = new ManageEmployeeView();
                    m.Show();
                    break;
                case "Emp_report":
                    EmployeeReportView m1 = new EmployeeReportView();
                    m1.Show();
                    break;
                case "Select_ManageSalary":
                    ManageSalaryView m2 = new ManageSalaryView();
                    m2.Show();
                    break;
                case "salaryReport":
                    SalaryReportView m3 = new SalaryReportView();
                    m3.Show();
                    break;

            }
        }
    }
}
