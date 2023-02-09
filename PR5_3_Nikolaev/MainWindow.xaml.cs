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

namespace PR5_3_Nikolaev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
       
        public MainWindow()
        {
            InitializeComponent();
            DataContext= this;
            str = new ObservableCollection<String>();
            foreach(Animals anim in Enum.GetValues(typeof(Animals)))
            {
                string item = anim.ToString();
                Str.Add(item);
            }
            Index = 0;
            Image = "Volk.jpg";
            

        }
        private ObservableCollection<String> str;
        public ObservableCollection<String> Str
        {
            get => str;
            set
            {
                str = value;
                OnPropertyChanged();
            }
        }
        private int index;
        public int Index
        {
            get => index;
            set
            {
                index = value;
                switch (index)
                {
                    case 0:
                        Image = "Volk.jpg";
                        break;
                    case 1:
                        Image = "Lis.jpeg";
                        break;
                    case 2:
                        Image = "Beer.jpeg";
                        break;
                    case 3:
                        Image = "Enot.jpeg";
                        break;
                }   
                OnPropertyChanged();
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
