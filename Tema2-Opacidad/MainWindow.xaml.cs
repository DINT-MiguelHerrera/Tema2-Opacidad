using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Tema2_Opacidad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            if(Mouse)
            {

            }
            imagen1.Opacity = 1;
            imagen2.Opacity = 1;    
            imagen3.Opacity = 1;    
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e) {
            imagen1.Opacity = 0.5;
            imagen2.Opacity = 0.5;
            imagen3.Opacity = 0.5;
        }
    }
}
