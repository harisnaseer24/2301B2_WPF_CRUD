using System.Windows;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Controls;

namespace _2301B2Crud
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadStudentsGrid();
        }

         SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=wpfCrud;User ID=sa;Password=aptech;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");


        private void LoadStudentsGrid()
        {
            SqlCommand getStudents = new SqlCommand("SELECT * FROM students",Conn);
            DataTable dt = new DataTable();
            Conn.Open();
            SqlDataReader dr= getStudents.ExecuteReader();     
            dt.Load(dr);
            studentGrid.ItemsSource = dt.DefaultView;
            Conn.Close();
        }

        private void ClearData()
        {
            uname.Clear();
            email.Clear();
            cellno.Clear();
            city.Clear();
            age.Clear();
        }
      
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
        }
    }
}
