using employee_management_system.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Windows;

namespace employee_management_system.ViewModel
{
   public class ManagesalaryViewModel
    {
        SqlDataReader  dr;
        SqlDataReader dr1;
        public ICommand command4 { get; set; }

        public ManageEmployeeModel manageEmployee { get; set; }

        public ManageSalaryModel manageSalary { get; set; }
        public List<ManageSalaryModel> lst3 { get; set; }
        public List<ManageSalaryModel> lst4 { get; set; }
     
        public ManagesalaryViewModel()
        {

            command4 = new command(execute, canexecute);
            manageSalary = new ManageSalaryModel { };
            manageEmployee = new ManageEmployeeModel { };

            lst3 = new List<ManageSalaryModel>();
            dr1 = dal.FunSQLDataReader(" exec usp_select1_employee");


            if (dr.Read())
            {
                var value = dr1.GetValue(0);
                ManageSalaryModel manageSalary = new ManageSalaryModel();
                manageSalary.Emp_id = (int)value;
                lst3.Add(manageSalary);
            }

            dr1.Close();


            lst4 = new List<ManageSalaryModel>();
            dr = dal.FunSQLDataReader("exec usp_select_salary");
            while (dr.Read())
            {


                var value = dr.GetValue(0);

                var value1 = dr.GetValue(1);

                var value2 = dr.GetValue(2);

                var value3 = dr.GetValue(3);

                var value4 = dr.GetValue(4);

                var value5 = dr.GetValue(5);



                ManageSalaryModel manageSalary = new ManageSalaryModel();
                manageSalary.id = (int)value;
                manageSalary.Emp_id = (int)value1;
                manageSalary.Month = (string)value2;
                manageSalary.Amount = (int)value3;
                manageSalary.PaymentDate = (DateTime)value4;
                manageSalary.Description = (string)value5;




                lst4.Add(manageSalary);






            }
            dr.Close();

        }


        public bool canexecute(object parameter)
        {
            return true;
        }

        DataAccessLayer dal = new DataAccessLayer();
        public void execute(object parameter)
        {
            switch (parameter)
            {
                case "save":

                    int a = dal.funexecutenonQuery("exec Usp_Insert_Salary " + manageSalary.Emp_id + " , '" + manageSalary.Month + "'," + manageSalary.Amount + " ,'" + manageSalary.PaymentDate + "' , '" + manageSalary.Description + "'");
                    if (a > 0)
                    {
                        MessageBox.Show("data Inserted");
                    }
                    else
                    {
                        MessageBox.Show("data not Inserted");
                    }
                    break;
                case "Update":
                    int b = dal.funexecutenonQuery(" exec Usp_Update_Salary " + manageSalary.Emp_id + " , '" + manageSalary.Month + "'," + manageSalary.Amount + " ,'" + manageSalary.PaymentDate + "' , '" + manageSalary.Description + "'");
                    if (b > 0)
                    {
                        MessageBox.Show("data Updated");
                    }
                    else
                    {
                        MessageBox.Show("data not Updated");
                    }
                    break;
                case "Delete":
                    int c = dal.funexecutenonQuery("Usp_Delete_Salary " + manageSalary.Emp_id);
                    if (c > 0)
                    {
                        MessageBox.Show("data deleted");
                    }
                    else
                    {
                        MessageBox.Show("data not deleted");
                    }
                    break;
              
            }
        }



    }

}
