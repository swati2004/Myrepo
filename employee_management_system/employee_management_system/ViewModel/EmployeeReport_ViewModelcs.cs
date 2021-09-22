using employee_management_system.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data.SqlClient;

namespace employee_management_system.ViewModel
{
    class EmployeeReport_ViewModelcs
    {

        DataTable dt;
        SqlDataReader dr;
      
        public ICommand command3 { get; set; }
        public List<Designation> lst { get; set; }

        public List<ManageEmployeeModel> lst1 { get; set; }


        public EmployeeReport_ViewModelcs()
        {
            command3 = new command(Execute, canexecute);

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
            

        }

        public bool canexecute(object parameter)
        {
            return true;
        }

        DataAccessLayer dal = new DataAccessLayer();
        public void Execute(object parameter)
        {
            switch (parameter)
            {
                case "show":
                    dt = dal.fundataTable("select * from employee");
                    break;
            }

        }

    }
}
