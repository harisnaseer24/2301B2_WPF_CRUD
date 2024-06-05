using System.Data;
using System.Data.SqlClient;
using System.Windows;


namespace wpfcrud
{
  
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }


        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Config.abc.Open();
            string uname = textBox.Text;
            string pass = textBox_Copy.Text;

            var xyz = new SqlCommand("insert into users values(@jhj,@jkk)",Config.abc);
            xyz.Parameters.AddWithValue("@jhj", uname);
            xyz.Parameters.AddWithValue("@jkk", pass);
            int row = xyz.ExecuteNonQuery();
            if(row > 0)
            {
                MessageBox.Show("JAni ho gaya");
            }
            else
            {
                MessageBox.Show("Nahi hua");
            }
            Config.abc.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
        Config.abc.Open();
            
            SqlCommand getUsers = new SqlCommand("SELECT * FROM users",Config.abc);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(getUsers);
            DataTable userTable = new DataTable();
            sqlDataAdapter.Fill(userTable);
            
            
            View viewData = new View();
            viewData.dataGrid.ItemsSource = userTable.DefaultView;


            Config.abc.Close();
            viewData.Show();
            Close();
        }
    }
}
