using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_system.Model
{
   public class ManageSalaryModel
    {

        public int? Emp_id { get; set; }
        public int? id { get; set; }
        public string month { get; set; }
        public int? Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string description { get; set; }

        
        public string Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
      
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

       

      
    }
}
