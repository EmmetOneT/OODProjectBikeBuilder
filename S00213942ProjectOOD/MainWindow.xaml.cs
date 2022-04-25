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

namespace S00213942ProjectOOD
{
    public partial class MainWindow : Window
    {
        ABikeContainer db = new ABikeContainer();
        public MainWindow()
        {
            InitializeComponent();
        }

        //reacts when selecting bike brand
        //private void cbxBrand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Frame selectedFrame = cbxBrand.SelectedItem as Frame;

        //    if (selectedFrame != null)
        //    {
        //        var FrameResults = from i in db.Frames
        //                           select i.Description;



        //    }
        //}

        private void cbxDrivetrain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lbxBasket_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //Fills Combo boxes when window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

     
        }


        private void lbxFrame_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                
            
        }

        private void lbxFork_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lbxDrive_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
