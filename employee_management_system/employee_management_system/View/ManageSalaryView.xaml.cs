using employee_management_system.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace employee_management_system.View
{
    /// <summary>
    /// Interaction logic for ManageSalaryView.xaml
    /// </summary>
    public partial class ManageSalaryView : Window
    {
        DataTable dt;
        DataAccessLayer da = new DataAccessLayer();
        public ManageSalaryView()
        {
            InitializeComponent();

         

        }
       
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dt = da.fundataTable("exec usp_Search_Salary " + combo1.SelectedValue);
            if (dt.Rows.Count > 0)
            {
                grid1.ItemsSource = dt.DefaultView;
            }
        }
    }
}
