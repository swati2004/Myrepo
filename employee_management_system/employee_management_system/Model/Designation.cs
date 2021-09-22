using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_management_system.Model
{
    public class Designation
    {

        #region Declaration
        private int id;
        private String name;
        #endregion

        #region Getters & Setters
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        #endregion
    }
}

