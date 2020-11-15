using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Name = "Сашко", Age = 12, Mail = "john@doe-family.com", Phone_number = "249524952" });
            items.Add(new User() { Name = "Міша", Age = 39, Mail = "jane@doe-family.com" , Phone_number = "512452184" });
            items.Add(new User() { Name = "Роман", Age = 71, Mail = "roma.doe@gmail.com", Phone_number = "258484632" });
            items.Add(new User() { Name = "Діма", Age = 31, Mail = "dima.doe@gmail.com", Phone_number = "9595693243245" });
            items.Add(new User() { Name = "Андрій", Age = 21, Mail = "manut.doe@gmail.com", Phone_number = "4895959523555" });
            items.Add(new User() { Age = 51, Mail = "sasaha2123.doe@gmail.com", Phone_number = "595959534535" }) ;
            lvUsers.ItemsSource = items;
        }
        public class User : INotifyPropertyChanged
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string Mail { get; set; }

            public string Phone_number { get; set; }

            public string PersonName
            {
                get { return Name; }
                set
                {
                    Name = value;
                    OnPropertyChanged();
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChanged([CallerMemberName] string Name = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
            }
        }
    }
}
