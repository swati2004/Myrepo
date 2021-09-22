using employee_management_system.Model;
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
     public class ManageEmployeeViewModelcs
    {

        SqlDataReader dr;
        public ManageEmployeeModel manageEmployee { get; set; }
        public ICommand MyCommand { get; set; }
        public  Designation designation { get; set; }

        public List<Designation> lst { get; set; }

        public List<ManageEmployeeModel> lst1 { get; set; }

        public ManageEmployeeViewModelcs()
        {

           

            lst = new List<Designation>();
            lst = new List<Designation>()
            {
            new Designation{Id=1,Name="Software Engineer"},
            new Designation{Id=2,Name="Analyst"},
            new Designation{Id=3,Name="Junior Developer"},
            new Designation{Id=4,Name="Automation engineer"}


            };

            lst1 = new List<ManageEmployeeModel>();



            dr = dal.FunSQLDataReader("select * from employee");
            while (dr.Read())
            {

                var value = dr.GetValue(0);
                var value1 = dr.GetValue(1);
                var value2 = dr.GetValue(2);
                var value3 = dr.GetValue(3);
                var value4 = dr.GetValue(4);
                var value5 = dr.GetValue(5);
                var value6 = dr.GetValue(6);
                var value7 = dr.GetValue(7);
                var value8 = dr.GetValue(8);
                var value9 = dr.GetValue(9);
                var value10 = dr.GetValue(10);
                var value11 = dr.GetValue(11);
                var value12 = dr.GetValue(12);


                ManageEmployeeModel manageEmployee = new ManageEmployeeModel();
                Designation designation = new Designation();
            
                manageEmployee.Id = (int)value;
                manageEmployee.Name = (string)value1;
                manageEmployee.ContactNo = (int)value2;
                designation.Id = (int)value3;
                manageEmployee.Email = (string)value4;
                manageEmployee.Salary = (int)value5;
                manageEmployee.dob = (DateTime)value6;
                manageEmployee.Address1 = (string)value7;
                manageEmployee.Address2 = (string)value8;
                manageEmployee.City = (string)value9;
                manageEmployee.State = (string)value10;
                manageEmployee.PinCode = (int)value11;
                manageEmployee.Country = (string)value12;
                lst1.Add(manageEmployee);
            }
            dr.Close();


            MyCommand = new command(ExecuteMethod, canExecuteMethod);
            manageEmployee = new ManageEmployeeModel { };

            designation = new Designation { };
        }

        private bool canExecuteMethod(object parameter)
        {
            return true;
        }
        DataAccessLayer dal = new DataAccessLayer();
        private void ExecuteMethod(object parameter)
        {
            switch (parameter)
            {
                case "Save":

                    int a = dal.funexecutenonQuery("exec insert_employee '" + manageEmployee.Name + "' ," + manageEmployee.ContactNo + "," + designation.Id + ",'" + manageEmployee.Email + "'," + manageEmployee.Salary + ",'"
                        + manageEmployee.dob + "','" + manageEmployee.Address1 + "','" + manageEmployee.Address2 + "','" + manageEmployee.City + "','" + manageEmployee.State + "'," + manageEmployee.PinCode + ",'" + manageEmployee.Country + "'");
                    if (a > 0)
                    {
                        MessageBox.Show("data Inserted");

                    }


                    break;
                case "Update":
                    int b = dal.funexecutenonQuery("exec update_employee'" + manageEmployee.Name + "' ," + manageEmployee.ContactNo + "," + designation.Id + ",'" + manageEmployee.Email + "'," + manageEmployee.Salary + ",'"
                      + manageEmployee.dob + "','" + manageEmployee.Address1 + "','" + manageEmployee.Address2 + "','" + manageEmployee.City + "','" + manageEmployee.State + "'," + manageEmployee.PinCode + ",'" + manageEmployee.Country + "'");
                    if (b > 0)
                    {
                        MessageBox.Show(" Data Updated");
                    }
                    break;
                case "Delete":
                    int c = dal.funexecutenonQuery("exec delete_employee '"+manageEmployee.Name+"' ");
                    if (c > 0)
                    {
                        MessageBox.Show("Data Deleted");
                    }
                    break;

               


            }
        }
    }
}
