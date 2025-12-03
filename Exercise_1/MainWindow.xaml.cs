using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person person = new Person
            {
                Name = "Jamie",
                Number = 1234567890,
                Address = "900 Saint Catherine, Montreal",
                Email = "jamie@123.com"
            };

            this.DataContext = person;
        }
    }





    }

public class Person
{
    public Person()
    {
        Name = string.Empty;
        Address = string.Empty;
        Email = string.Empty;
    }

    public string Name { get; set; }
    public int? Number { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }


}


