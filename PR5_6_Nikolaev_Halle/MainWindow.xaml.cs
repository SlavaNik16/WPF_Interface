using System;
using System.Collections.Generic;
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

namespace PR5_6_Nikolaev_Halle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext= this;
            InitializeComponent();
            Image = "Volk.jpg";
            Str = "Волк";
        }
        private RelayCommand exit;
        public RelayCommand Exit
        {
            get => exit ?? (exit = new RelayCommand(x => Application.Current.Shutdown()));
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
        private string str;
        public string Str
        {
            get => str;
            set
            {
                str = value;
                OnPropertyChanged();
            }
        }


        private void Lisa_Click(object sender, RoutedEventArgs e)
        {
            Image = "Lis.jpeg";
            Str = "Лиса";
        }

        private void Enot_Click(object sender, RoutedEventArgs e)
        {
            Image = "Enot.jpeg";
            Str = "Енот";
        }

        private void Volk_Click(object sender, RoutedEventArgs e)
        {
            Image = "Volk.jpg";
            Str = "Волк";
        }

        private void Beer_Click(object sender, RoutedEventArgs e)
        {
            Image = "Beer.jpeg";
            Str = "Медведь";

        } 
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

      
    }
}
