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
            sid.Clear();
        }
      
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearData();
        }

        private bool isValid()
        {
            if(uname.Text == string.Empty)
            {
                MessageBox.Show("Name cannot be null","Required", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            else if (email.Text == string.Empty)
            {
                MessageBox.Show("Email cannot be null", "Required", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            else if (age.Text == string.Empty)
            {
                MessageBox.Show("Age cannot be null", "Required", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            else if (cellno.Text == string.Empty)
            {
                MessageBox.Show("Cell no cannot be null", "Required", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            else if (city.Text == string.Empty)
            {
                MessageBox.Show("City cannot be null", "Required", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addStudent(object sender, RoutedEventArgs e)
        {
            if (isValid())
            {
                SqlCommand addStud = new SqlCommand("INSERT INTO students VALUES(@uname, @email, @age, @city, @cellno)", Conn);
                addStud.CommandType = CommandType.Text;
                Conn.Open();
                addStud.Parameters.AddWithValue("@uname",uname.Text);
                addStud.Parameters.AddWithValue("@email", email.Text);
                addStud.Parameters.AddWithValue("@age",age.Text);
                addStud.Parameters.AddWithValue("@city",city.Text);
                addStud.Parameters.AddWithValue("@cellno", cellno.Text);

                addStud.ExecuteNonQuery();
                Conn.Close();
                LoadStudentsGrid();
                ClearData();

            }
        }

        private void deleteStud(object sender, RoutedEventArgs e)
        {
           if (sid.Text != string.Empty)
            {
                SqlCommand delStud = new SqlCommand("DELETE FROM students WHERE Id= @Sid", Conn);
                delStud.CommandType = CommandType.Text;
                Conn.Open();
                delStud.Parameters.AddWithValue("@Sid", sid.Text);
             

                delStud.ExecuteNonQuery();
               
                Conn.Close();
                MessageBox.Show("Student deleted Successsfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                LoadStudentsGrid();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please provide student id to delete a record.", "Cant't Delete without Id", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
