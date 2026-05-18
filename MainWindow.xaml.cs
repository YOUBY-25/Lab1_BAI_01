using System;
using System.Windows;
using System.Windows.Controls;
using Lab1_BAI_01.Models;

namespace Lab1_BAI_01
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Safe ComboBox reading (fixes null warning)
                string type =
                    (TransportBox.SelectedItem as ComboBoxItem)?.Content?.ToString();

                if (string.IsNullOrEmpty(type))
                {
                    MessageBox.Show("Please select transport type");
                    return;
                }

                string model = ModelBox.Text;

                if (!double.TryParse(SpeedBox.Text, out double speed) ||
                    !int.TryParse(PassengersBox.Text, out int passengers) ||
                    !double.TryParse(DistanceBox.Text, out double distance))
                {
                    MessageBox.Show("Please enter valid numbers");
                    return;
                }

                // Fix nullable warning
                Transport? transport = null;

                switch (type)
                {
                    case "Bicycle":
                        transport = new Bicycle(speed, model, passengers);
                        break;

                    case "Car":
                        transport = new Car(speed, model, passengers);
                        break;

                    case "Truck":
                        transport = new Truck(speed, model, passengers);
                        break;
                }

                if (transport == null)
                {
                    MessageBox.Show("Invalid transport type");
                    return;
                }

                double fuel = transport.CalculateFuelConsumption(distance);
                double time = transport.CalculateTravelTime(distance);
                double extra = transport.CalculateTravelTime(distance, 1);

                ResultBlock.Text =
                    transport.GetInfo() +
                    $"\nFuel Consumption: {fuel:F2}" +
                    $"\nTravel Time: {time:F2} hours" +
                    $"\nTravel Time (+1 hour): {extra:F2} hours";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}