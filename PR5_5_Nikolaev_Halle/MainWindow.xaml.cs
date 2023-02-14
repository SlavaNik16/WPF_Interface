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

namespace PR5_5_Nikolaev_Halle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            Image = "Volk.jpg";
        }

        private void butOk_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Volk.IsChecked)
            {
                Image = "Volk.jpg";
            }else if ((bool)Lisa.IsChecked)
            {
                Image = "Lis.jpeg";
            }else if ((bool)Beer.IsChecked)
            {
                Image = "Beer.jpeg";
            }
            else if ((bool)Enot.IsChecked)
            {
                Image = "Enot.jpeg";
            }
        }
        private string image;
        public string Image
        {
            get => image;
            set
            {
                image = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
