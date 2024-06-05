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

namespace wpfcrud
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();

        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView user = dataGrid.SelectedValue as DataRowView;

            deicde form = new deicde();
          
            //var uid = user["Id"];
            //var uname = user["username"];
            //var upass = user["password"];

            form.id.Text = user["Id"].ToString();
            form.username.Text = user["username"].ToString();
            form.password.Text = user["password"].ToString();
            form.Show();
            Close();




        }
    }
}
