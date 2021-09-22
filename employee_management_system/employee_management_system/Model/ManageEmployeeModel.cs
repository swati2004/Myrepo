using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_system.Model
{
   public  class ManageEmployeeModel:IDataErrorInfo
    {
        private int id;
        private string name;
        private int contactNo;

      
        private string email;

        private int salary;

        public DateTime? dob { get; set; }

        private string address1;
        private string address2;

        private string city;

        private string state;

        private int pincode;

        private string country;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }

        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }
        public int ContactNo
        {
            get
            {
                return contactNo;
            }

            set
            {
                contactNo = value;
            }

        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }

        }
        //public DateTime DOB
        //{
        //    get
        //    {
        //        return dob;
        //    }

        //    set
        //    {
        //        dob = value;
        //    }

        //}
        public string Address1
        {
            get
            {
                return address1;
            }

            set
            {
                address1 = value;
            }

        }
        public string Address2
        {
            get
            {
                return address2;
            }

            set
            {
                address2 = value;
            }

        }
        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }

        }
        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }

        }
        public int PinCode
        {
            get
            {
                return pincode;
            }

            set
            {
                pincode = value;
            }

        }
        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }

        }


        List<Designation> lst = new List<Designation>()
        {
        new Designation{Id=1,Name="Software Engineer"},
        new Designation{Id=2,Name="Analyst"},
        new Designation{Id=3,Name="Junior Developer"},
        new Designation{Id=4,Name="Automation engineer"}
        };

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

        private string funname()
        {
            if (string.IsNullOrEmpty(Name))
            {
                return "Please enter name";
            }
            return null;
        }
        private string funcity()
        {
            if (string.IsNullOrEmpty(City))
            {
                return "Please enter city";
            }
            return null;
        }

        private string funemail()
        {
            if (string.IsNullOrEmpty(Email))
            {
                return "Please enter email";
            }
            return null;
        }

        private string funaddress1()
        {
            if (string.IsNullOrEmpty(Address1))
            {
                return "Please enter address1";
            }
            return null;
        }
        private string funstate()
        {
            if (string.IsNullOrEmpty(State))
            {
                return "Please enter state";
            }
            return null;
        }
        private string funcountry()
        {
            if (string.IsNullOrEmpty(Country))
            {
                return "Please enter country";
            }
            return null;
        }
     
        

        private string funaddress2()
            {
                if (string.IsNullOrEmpty(Address2))
                {
                    return "Please enter address2";
                }
                return null;
            }


        string GetValidationError(string propertyName)
        {
            string error = null;
            switch (propertyName)
            {
                case "Name":
                    error = funname();
                    break;
                case "Email":
                    error = funemail();
                    break;
                case "Address1":
                    error = funaddress1();
                    break;
                case "City":
                    error = funcity();
                    break;
                case "State":
                    error = funstate();
                    break;
                case "Country":
                    error = funcountry();
                    break;
                case "Address2":
                    error = funaddress2();
                    break;
            }
            return error;
        }
    }
}
