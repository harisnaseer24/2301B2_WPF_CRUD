using System.Numerics;
using System.Security.Claims;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Media3D;
using System.Xml.Linq;

namespace WpfApp3
{

    public partial class MainWindow : Window
    {  
        //public bool state_running=false;
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void toggleProcess(object sender, RoutedEventArgs e)
        //{
        //if (state_running)
        //{
        //    status.Text = "Stopped";
        //    toggle.Content = "Run";
        //}
        //else
        //{
        //    status.Text = "Running";
        //    toggle.Content = "Stop";
        //}
        //state_running = !state_running;
        //}
    }
}
        //< TextBlock Name = "status"  VerticalAlignment = "Stretch" HorizontalAlignment = "Center" FontSize = "70" />
        //< Button Name = "toggle" Width = "100" Height = "50" Content = "Run" VerticalAlignment = "Center" HorizontalAlignment = "Center" FontSize = "20" Click = "toggleProcess" />
    //    < Window x: Class = "WpfApp3.MainWindow"
    //    xmlns = "http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    //    xmlns: x = "http://schemas.microsoft.com/winfx/2006/xaml"
    //    xmlns: d = "http://schemas.microsoft.com/expression/blend/2008"
    //    xmlns: mc = "http://schemas.openxmlformats.org/markup-compatibility/2006"
    //    xmlns: local = "clr-namespace:WpfApp3"
    //    mc: Ignorable = "d"
    //    Title = "MainWindow" Height = "450" Width = "800" >
    //< Grid >
    //    < Grid.RowDefinitions >
    //        < RowDefinition Height = "70" />
    //        < RowDefinition />
    //        < RowDefinition Height = "20" />
    //    </ Grid.RowDefinitions >
    //    < !--Title Bar-- >
    //        < Rectangle Grid.Row = "0" Fill = "black" />
    //    < !--Content Pane-- >
    //    < Grid Grid.Row = "1" >
    //        < Grid.ColumnDefinitions >
    //            < ColumnDefinition  Width = "17*" />
    //            < ColumnDefinition  Width = "66*" />
    //            < ColumnDefinition  Width = "17*" />
    //        </ Grid.ColumnDefinitions >

    //        < Rectangle Grid.Column = "0" Fill = "Silver" />
    //        < Rectangle Grid.Column = "1" Fill = "DarkGray" />
    //        < Rectangle Grid.Column = "2" Fill = "Gray" />

    //    </ Grid >
    //    < !--Footer-- >
    //    < Rectangle Grid.Row = "2" Fill = "DimGray" />


    //</ Grid >




//</ Window >