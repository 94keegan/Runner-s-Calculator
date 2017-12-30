using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace Runners_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Regex regex = new Regex(@"(?<=^| )\d+(\.\d+)?(?=$| )|(?<=^| )\.\d+(?=$| )");

        public MainWindow()
        {
            InitializeComponent();
            cmbDistance.SelectedIndex = 0;
            cmbPace.SelectedIndex = 0;
        }

        /// <summary>
        /// Close application when "X" button is clicked
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Calculates the time given the distance and pace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTime_Click(object sender, RoutedEventArgs e)
        {
            // Create object from Runner class
            Runner timeRun = new Runner();

            // Validate the input from the textboxes then MessageBox.Show an appropriate exception
            try
            {
                // Set Distance
                    if (txtDistance.Text == "")
                    {
                        timeRun.Distance = 0;
                    }
                    else
                    {
                        // Verify only numbers are entered
                        if (regex.IsMatch(timeRun.Distance.ToString()))
                        {
                            timeRun.Distance = double.Parse(txtDistance.Text);
                        }
                    }
                
                // Set Pace
                if (txtPaceHours.Text == "")
                {
                    timeRun.PaceHours = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(timeRun.PaceHours.ToString()))
                    {
                        timeRun.PaceHours = double.Parse(txtPaceHours.Text);
                    }
                }
                if (txtPaceMinutes.Text == "")
                {
                    timeRun.PaceMinutes = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(timeRun.PaceMinutes.ToString()))
                    {
                        timeRun.PaceMinutes = double.Parse(txtPaceMinutes.Text);
                    }
                }
                if (txtPaceSeconds.Text == "")
                {
                    timeRun.PaceSeconds = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(timeRun.PaceSeconds.ToString()))
                    {
                        timeRun.PaceSeconds = double.Parse(txtPaceSeconds.Text);
                    }
                }

                timeRun.CalcTime(timeRun.Distance, timeRun.CalcSeconds(timeRun.PaceHours, timeRun.PaceMinutes, timeRun.PaceSeconds));

                // Print the time values in the time textboxes
                if (timeRun.TimeHours == 0)
                {
                    txtTimeHours.Text = "";
                }
                else
                {
                    txtTimeHours.Text = timeRun.TimeHours.ToString();
                }
                if (timeRun.TimeMinutes == 0)
                {
                    txtTimeMinutes.Text = "";
                }
                else
                {
                    txtTimeMinutes.Text = timeRun.TimeMinutes.ToString();
                }
                if (timeRun.TimeSeconds == 0)
                {
                    txtTimeSeconds.Text = "";
                }
                else
                {
                    txtTimeSeconds.Text = timeRun.TimeSeconds.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - To calculate Time, enter the Distance and Pace", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Calculates the distance given the time and pace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDistance_Click(object sender, RoutedEventArgs e)
        {
            // Create object from Runner class
            Runner distanceRun = new Runner();

            // Validate the input from the textboxes then MessageBox.Show an appropriate exception
            try
            {
                // Set Time
                if (txtTimeHours.Text == "")
                {
                    distanceRun.TimeHours = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(distanceRun.TimeHours.ToString()))
                    {
                        distanceRun.TimeHours = double.Parse(txtTimeHours.Text);
                    }
                }
                if (txtTimeMinutes.Text == "")
                {
                    distanceRun.TimeMinutes = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(distanceRun.TimeMinutes.ToString()))
                    {
                        distanceRun.TimeMinutes = double.Parse(txtTimeMinutes.Text);
                    }

                }
                if (txtTimeSeconds.Text == "")
                {
                    distanceRun.TimeSeconds = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(distanceRun.TimeSeconds.ToString()))
                    {
                        distanceRun.TimeSeconds = double.Parse(txtTimeSeconds.Text);
                    }
                }

                // Set Pace
                if (txtPaceHours.Text == "")
                {
                    distanceRun.PaceHours = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(distanceRun.PaceHours.ToString()))
                    {
                        distanceRun.PaceHours = double.Parse(txtPaceHours.Text);
                    }
                }
                if (txtPaceMinutes.Text == "")
                {
                    distanceRun.PaceMinutes = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(distanceRun.PaceMinutes.ToString()))
                    {
                        distanceRun.PaceMinutes = double.Parse(txtPaceMinutes.Text);
                    }
                }
                if (txtPaceSeconds.Text == "")
                {
                    distanceRun.PaceSeconds = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(distanceRun.PaceSeconds.ToString()))
                    {
                        distanceRun.PaceSeconds = double.Parse(txtPaceSeconds.Text);
                    }
                }

                distanceRun.CalcDistance(distanceRun.CalcSeconds(distanceRun.TimeHours, distanceRun.TimeMinutes, distanceRun.TimeSeconds),
                    distanceRun.CalcSeconds(distanceRun.PaceHours, distanceRun.PaceMinutes, distanceRun.PaceSeconds));

                // Print the distance value in the textbox
                if (distanceRun.Distance == 0)
                {
                    txtDistance.Text = "";
                }
                else
                {
                    txtDistance.Text = distanceRun.Distance.ToString("#.##");                        
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - To calculate Distance, enter the Time and Pace", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Calculates the pace given the time and distance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPace_Click(object sender, RoutedEventArgs e)
        {
            // Create object from Runner class
            Runner paceRun = new Runner();

            //Validate the input from the textboxes then MessageBox.Show an appropriate exception
            try
            {
                // Set Time
                if (txtTimeHours.Text == "")
                {
                    paceRun.TimeHours = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(paceRun.TimeHours.ToString()))
                    {
                        paceRun.TimeHours = double.Parse(txtTimeHours.Text);
                    }
                }
                if (txtTimeMinutes.Text == "")
                {
                    paceRun.TimeMinutes = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(paceRun.TimeMinutes.ToString()))
                    {
                        paceRun.TimeMinutes = double.Parse(txtTimeMinutes.Text);
                    }
                }
                if (txtTimeSeconds.Text == "")
                {
                    paceRun.TimeSeconds = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(paceRun.TimeSeconds.ToString()))
                    {
                        paceRun.TimeSeconds = double.Parse(txtTimeSeconds.Text);
                    }
                }

                // Set Distance
                if (txtDistance.Text == "")
                {
                    paceRun.Distance = 0;
                }
                else
                {
                    // Verify only numbers are entered
                    if (regex.IsMatch(paceRun.Distance.ToString()))
                    {
                        paceRun.Distance = double.Parse(txtDistance.Text);
                    }
                }

                paceRun.CalcPace(paceRun.CalcSeconds(paceRun.TimeHours, paceRun.TimeMinutes, paceRun.TimeSeconds), paceRun.Distance);

                // Print the pace values in the texboxes
                if (paceRun.PaceHours == 0)
                {
                    txtPaceHours.Text = "";
                }
                else
                {
                    txtPaceHours.Text = paceRun.PaceHours.ToString();
                }
                if (paceRun.PaceMinutes == 0)
                {
                    txtPaceMinutes.Text = "";
                }
                else
                {
                    txtPaceMinutes.Text = paceRun.PaceMinutes.ToString();
                }
                if (paceRun.PaceSeconds == 0)
                {
                    txtPaceSeconds.Text = "";
                }
                else
                {
                    txtPaceSeconds.Text = paceRun.PaceSeconds.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - To calculate Pace, enter the Time and Distance", MessageBoxButton.OK  , MessageBoxImage.Error);
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtTimeHours.Text = "";
            txtTimeMinutes.Text = "";
            txtTimeSeconds.Text = "";
            txtDistance.Text = "";
            txtPaceHours.Text = "";
            txtPaceMinutes.Text = "";
            txtPaceSeconds.Text = "";
        }
    }
}