﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FirstUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Bygga listan med kunder skapas en gång
        // List<Customer> customers = new List<Customer>();
        ObservableCollection<Customer> customers =new ObservableCollection<Customer>();
       
        public Status selected;
        public int type; 
            //public string FirstName, LastName, InfoText;
        public MainPage()
        {
            this.InitializeComponent();

            this.DataContext = this;

          


            customers.Add(new BusinessCustomer(1,"Allan","Ballan",150,new Ticket(1,Status.Closed,"")));
            customers.Add(new BusinessCustomer(1, "Ylva", "Yster",300, new Ticket(1, Status.Completed,"")));
            customers.Add(new BusinessCustomer(1, "Kjell", "Kriminell",150, new Ticket(1, Status.Processing,"")));

            CustomersList.ItemsSource = customers;

            var selections = Enum.GetValues(typeof(Status)).Cast<Status>();
            SelectStatus.ItemsSource = selections.ToList();

            

            Button saveButton = new Button();
            saveButton.Click += SaveButton_Click;

           
            FirstGrid.Children.Add(saveButton);

        }

        private  void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            if (type == 1) { 
            BusinessCustomer c = new BusinessCustomer(1, FirstName.Text, LastName.Text, 150,new Ticket(1, selected, Description.Text));
            customers.Add(c);
                //InfoText.Text = "Sparade " + FirstName.Text + "KOLLA " + c.CalculateDiscountPrice(100);
            }
            else if(type==2){
                PrivateCustomer c = new PrivateCustomer(1, FirstName.Text, LastName.Text,300, new Ticket(1, selected, Description.Text));
                customers.Add(c);
                //InfoText.Text = "Sparade " + FirstName.Text + "KOLLA " + c.CalculateDiscountPrice(100);
            }

            FirstName.Text = "";
            LastName.Text = "";
           
        }
        private void status_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var container = sender as ComboBox;
            selected = (Status) container.SelectedItem;
           
        }

        private void Business_Click(object sender, RoutedEventArgs e)
        {
            type = 1;
            Price.Text = "150";
        }

        private void Private_Click(object sender, RoutedEventArgs e)
        {
            type = 2;
            Price.Text = "300";
        }
    }
    }


