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
        List<Frame> allFrames;
        List<Fork> allForks;
        List<Drivetrain> allDrivetrains;
        public int TotalCost;
        //ABikeContainer db = new ABikeContainer();
        public MainWindow()
        {
            InitializeComponent();
        }
        //Add to basket listbox
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Frame selectedFrame = lbxFrame.SelectedItem as Frame;
            if (selectedFrame != null)
            {
                lbxBasket.Items.Add(selectedFrame).ToString();
                lbxFrame.UnselectAll(); //Deselects the frame in the listbox so the user cant accidentally add more than they mean to
                TotalCost += selectedFrame.Price; //Getting the frame from the frame listbox and adding to total cost
                tbTotalCost.Text = selectedFrame.Price.ToString();
                if (allFrames.Count == 0)
                    TotalCost = 0;
                tbTotalCost.Text = TotalCost.ToString();
               
            }
            //same as above
            Fork selectedFork = lbxFork.SelectedItem as Fork;
            if (selectedFork != null)
            {
                lbxBasket.Items.Add(selectedFork).ToString();
                lbxFork.UnselectAll();
                TotalCost += selectedFork.Price;
                tbTotalCost.Text = selectedFork.Price.ToString();
                if (allForks.Count == 0)
                    TotalCost = 0;
                tbTotalCost.Text = TotalCost.ToString();
            }
           //same as above
            Drivetrain selectedDrive = lbxDrive.SelectedItem as Drivetrain;
           
            if (selectedDrive != null)
            {
                lbxBasket.Items.Add(selectedDrive).ToString();
                lbxDrive.UnselectAll();
                   TotalCost += selectedDrive.Price;
                tbTotalCost.Text = selectedDrive.Price.ToString();
                if (allDrivetrains.Count == 0)
                    TotalCost = 0;
                tbTotalCost.Text = TotalCost.ToString();
            }
        }

        //Remove from basket list
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            
            Frame selectedFrame = lbxBasket.SelectedItem as Frame;
            if (selectedFrame != null)
            {
                lbxBasket.Items.Remove(selectedFrame);//Removes selected item from list
                lbxFrame.UnselectAll();
                TotalCost -= selectedFrame.Price; //Remove value of item from total price
                tbTotalCost.Text = selectedFrame.Price.ToString();
                if (allFrames.Count == 0)
                    TotalCost = 0;
                tbTotalCost.Text = TotalCost.ToString();
            }
            Fork selectedFork = lbxBasket.SelectedItem as Fork;
            if (selectedFork != null)
            {
                lbxBasket.Items.Remove(selectedFork);
                lbxFork.UnselectAll();
                TotalCost -= selectedFork.Price;
                tbTotalCost.Text = selectedFork.Price.ToString();
                if (allForks.Count == 0)
                    TotalCost = 0;
                tbTotalCost.Text = TotalCost.ToString();

            }
            Drivetrain selectedDrive = lbxBasket.SelectedItem as Drivetrain;
            if (selectedDrive != null)
            {
                lbxBasket.Items.Remove(selectedDrive);
                lbxDrive.UnselectAll();
                TotalCost -= selectedDrive.Price;
                tbTotalCost.Text = selectedDrive.Price.ToString();
                if (allDrivetrains.Count == 0)
                    TotalCost = 0;
                tbTotalCost.Text = TotalCost.ToString();
            }
        }

        //Not Used
        private void lbxBasket_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //Fills list boxes when window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FrameInfo db = new FrameInfo(); //referencing database

            var queryFrame = from f in db.Frames //query to get frames
                             select f;
            var queryFork = from fk in db.Forks
                            select fk;
            var queryDrive = from d in db.Drivetrains
                            select d;

            allFrames = queryFrame.ToList(); //var from query
            allForks = queryFork.ToList();
            allDrivetrains = queryDrive.ToList();

            lbxFrame.ItemsSource = allFrames; //adding querys to respectivelists
            lbxFork.ItemsSource = allForks;
            lbxDrive.ItemsSource = allDrivetrains;
        }

        //Filling information for parts selected
        private void lbxFrame_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Frame selectedFrame = lbxFrame.SelectedItem as Frame;

            if (selectedFrame != null)
            {
                tbPartInfo.Text = selectedFrame.GetPartInfo(); //filling the part information textblock with the selected part info
                imgPart.Source = new BitmapImage(new Uri(selectedFrame.FrameImage, UriKind.Relative)); //filling the image block with the image from the database
            }
            
        }

        private void lbxFork_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Fork selectedFork = lbxFork.SelectedItem as Fork;

            if (selectedFork != null)
            {
                tbPartInfo.Text = selectedFork.GetPartInfo();
                imgPart.Source = new BitmapImage(new Uri(selectedFork.ForkImage, UriKind.Relative));
            }
        }

        private void lbxDrive_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Drivetrain selectedDrive = lbxDrive.SelectedItem as Drivetrain;

            if (selectedDrive != null)
            {
                tbPartInfo.Text = selectedDrive.GetPartInfo();
                imgPart.Source = new BitmapImage(new Uri(selectedDrive.DriveImage, UriKind.Relative));
            }
        }

        //Checking what radio button is pressed
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            string discipline = rb.Content.ToString();
            //radio buttons check based on the discipline set in the database for each frame, fork and drivetrain
            //Fills out the listboxes with the parts
            switch (discipline)
            {
                case "Trail":
                    lbxFrame.ItemsSource = allFrames.Where(f => f.Discipline.Contains("Trail"));
                    lbxFork.ItemsSource = allForks.Where(f => f.Discipline.Contains("Trail"));
                    lbxDrive.ItemsSource = allDrivetrains.Where(f => f.Discipline.Contains("Trail"));
                    break;

                case "Downhill":
                    lbxFrame.ItemsSource = allFrames.Where(g => g.Discipline.Contains("Downhill"));
                    lbxFork.ItemsSource = allForks.Where(f => f.Discipline.Contains("Downhill"));
                    lbxDrive.ItemsSource = allDrivetrains.Where(f => f.Discipline.Contains("Downhill"));
                    break;
                case "Cross Country":
                    lbxFrame.ItemsSource = allFrames.Where(g => g.Discipline.Contains("Cross Country"));
                    lbxFork.ItemsSource = allForks.Where(f => f.Discipline.Contains("Cross Country"));
                    lbxDrive.ItemsSource = allDrivetrains.Where(f => f.Discipline.Contains("Cross Country"));
                    break;
                default:
                    lbxFrame.ItemsSource = allFrames;
                    lbxFork.ItemsSource = allForks;
                    lbxDrive.ItemsSource = allDrivetrains;
                    break;

            }
        }
        //not used
        private void tbTotalCost_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Printing a message to a messagebox with the parts from the basket listbox and total cost textblock
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder message = new StringBuilder();
            foreach (object selectedItem in lbxBasket.Items)
            {
                message.AppendLine(selectedItem.ToString());
            }
            MessageBox.Show(message.ToString() +"\nTotal Parts cost\n" + "€:" + tbTotalCost.Text);
        }
    }
}
