using System;
using System.Collections.Generic;
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

namespace wpfcrud
{
    /// <summary>
    /// Interaction logic for deicde.xaml
    /// </summary>
    public partial class deicde : Window
    {
        public deicde()
        {
            InitializeComponent();
        }

        private void updateUser(object sender, RoutedEventArgs e)
        {

        }  private void deleteUser(object sender, RoutedEventArgs e)
        {
            var userid = id.Text;
            SqlCommand deleteUser = new SqlCommand("Delete from users where Id=@Uid", Config.abc);

            Config.abc.Open();
            deleteUser.Parameters.AddWithValue("@Uid", userid);
            int row = deleteUser.ExecuteNonQuery();
            Config.abc.Close();

            if (row > 0)
            {
                var resp = MessageBox.Show("Deleted Successfully.", "Succes", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if(resp == 0)
                {
                    MessageBox.Show("yes.", "Succes");
                }
            }
            else
            {
               MessageBox.Show("Deleted Successfully.", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        

        }
    }
}
