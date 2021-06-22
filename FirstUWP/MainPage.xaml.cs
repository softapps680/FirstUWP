using System;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FirstUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        private ObservableCollection<Customer> customers =new ObservableCollection<Customer>();
        private Status selectedStatus;
        private int selectedCustomerType;
        private decimal privatePrice = 300.0m, businessPrice = 150.0m;    
        
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = this;

          
            customers.Add(new BusinessCustomer(1,"Allan","Ballan",businessPrice,new Ticket(1,Status.Closed,"")));
            customers.Add(new PrivateCustomer(1, "Ylva", "Yster",privatePrice, new Ticket(1, Status.Completed,"")));
            customers.Add(new BusinessCustomer(1, "Kjell", "Kriminell",businessPrice, new Ticket(1, Status.Processing,"")));
            CustomersList.ItemsSource = customers;

            var selections = Enum.GetValues(typeof(Status)).Cast<Status>();
            SelectStatus.ItemsSource = selections.ToList();

        }

        private  void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            if (selectedCustomerType == 1) { 
            BusinessCustomer c = new BusinessCustomer(1, FirstName.Text, LastName.Text, businessPrice,new Ticket(1, selectedStatus, Description.Text));
            
            customers.Add(c);
            InfoText.Text = "Sparat";
            }
            
            else if(selectedCustomerType == 2){
            PrivateCustomer c = new PrivateCustomer(1, FirstName.Text, LastName.Text,privatePrice, new Ticket(1, selectedStatus, Description.Text));
           
            customers.Add(c);
            InfoText.Text = "Sparat";
            }

            FirstName.Text = "";
            LastName.Text = "";
           
        }
        private void status_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var container = sender as ComboBox;
            selectedStatus = (Status) container.SelectedItem;
           
        }

        private void Business_Click(object sender, RoutedEventArgs e)
        {
            selectedCustomerType = 1;
            Price.Text = businessPrice.ToString();
        }

        private void Private_Click(object sender, RoutedEventArgs e)
        {
            selectedCustomerType = 2;
            Price.Text = privatePrice.ToString();
        }
    }
    }


