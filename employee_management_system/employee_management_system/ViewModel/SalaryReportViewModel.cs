using employee_management_system.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Data;

namespace employee_management_system.ViewModel
{
   public  class SalaryReportViewModel
    {
        //SqlDataReader dr;
        //DataTable dt;
        //public ICommand command5 { get; set; }
        //public ManageSalaryModel manage { get; set; }
        //public ManageEmployeeModel me { get; set; }
        //public List<ManageSalaryModel> slist { get; set; }

        //public SalaryReportViewModel()
        //{

        //    slist = new List<ManageSalaryModel>();

        //    dr = d.FunSQLDataReader("Select * from Salary");
        //    if (dr.Read())
        //    {
        //        var value = dr.GetValue(0);
        //        var value1 = dr.GetValue(1);
        //        var value2 = dr.GetValue(2);
        //        var value3 = dr.GetValue(3);
        //        var value4 = dr.GetValue(4);
        //        var value5 = dr.GetValue(5);

        //        ManageSalaryModel manage = new ManageSalaryModel();
        //        ManageEmployeeModel me = new ManageEmployeeModel();

              
        //        manage.Id = (int)value;
        //        me.Id = (int)value1;
        //        manage.Month = (string)value2;
        //        manage.Amount = (int)value3;
              
        //        manage.PaymentDate = (DateTime)value4;
        //        manage.Description = (string)value5;


        //    }
        //    dr.Close();



        //}

        //DataAccessLayer d = new DataAccessLayer();

        //public bool canexecute(object parameter)
        //{
        //    return true;
        //}
        //public void execute(object parameter)
        //{
        //    switch (parameter)
        //    {
        //        case "select":
        //            dt = d.fundataTable("select * from Salary");
        //            break;
        //    }
        //}
    }
}
