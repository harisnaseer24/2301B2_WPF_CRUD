using System.Windows;
using System.Windows.Controls;

namespace WpfApp3.View.UserControls
{

    public partial class ClearableTextBox : UserControl
    {

      
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placeholder;
        public string Placeholder
        {
            get { return placeholder; }
            set
            {
                placeholder = value;
                txtPlaceholder.Text = placeholder;
            }
        }
        private void Clearbtn_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void TxtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput.Text))
            {
                txtPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                txtPlaceholder.Visibility = Visibility.Hidden;
            }

        }
    }
}
