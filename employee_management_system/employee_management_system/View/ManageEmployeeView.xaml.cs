using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for ManageEmployeeView.xaml
    /// </summary>
    public partial class ManageEmployeeView : Window
    {
        DataTable dt2;
        public ManageEmployeeView()
        {
            InitializeComponent();
        }


        private void Button_search_Click(object sender, RoutedEventArgs e)
        {
            DataAccessLayer dataAccess = new DataAccessLayer();
            dt2 = dataAccess.fundataTable("select * from employee where Emp_name='" + Searchname.Text + "'");
            if (dt2.Rows.Count > 0)
            {
                grid1.ItemsSource = dt2.DefaultView;
            }

            MyPopup.IsOpen = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyPopup.IsOpen = true;
        }

     
    }
}
