using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace CarSelectionMobile
{
    public partial class MainPage : ContentPage
    {
        public Label typeDriveLabel;
        public Label typeCarLabel;
        public Label countryLabel;
        public Picker typeDrivePicker;
        public Picker typeCarPicker;
        public Picker countryPicker;

        public MainPage()
        {
            //StackLayout stackLayout = new StackLayout();
            
            typeDriveLabel = new Label
            {
                Text = "Тип привода",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            typeDrivePicker = new Picker {Title = "Привод"};
            typeDrivePicker.Items.Add("All");
            typeDrivePicker.Items.Add("Rear-wheel drive");
            typeDrivePicker.Items.Add("Front-wheel drive");
            typeDrivePicker.Items.Add("All-wheel drive");
            typeDrivePicker.SelectedIndex = 0;
            
            typeCarLabel = new Label
            {
                Text = "Тип кузова",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            typeCarPicker = new Picker {Title = "Кузов"};
            typeCarPicker.Items.Add("All");
            typeCarPicker.Items.Add("Passenger");
            typeCarPicker.Items.Add("SUV");
            typeCarPicker.Items.Add("Coupe");
            typeCarPicker.Items.Add("Sport");
            typeCarPicker.Items.Add("Cabriolet");
            typeCarPicker.Items.Add("Liftback");
            typeCarPicker.SelectedIndex = 0;

            countryLabel = new Label
            {
                Text = "Страна-производитель",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            
            countryPicker = new Picker() {Title = "Страна"};
            countryPicker.Items.Add("All");
            countryPicker.Items.Add("USA");
            countryPicker.Items.Add("Russia");
            countryPicker.Items.Add("Japan");
            countryPicker.Items.Add("Germany");
            countryPicker.Items.Add("Italy");
            countryPicker.Items.Add("Great Britain");
            countryPicker.SelectedIndex = 0;

            this.Content = new StackLayout {
                Padding = new Thickness(40),
                Children = { 
                    typeDriveLabel,
                    typeDrivePicker,
                    typeCarLabel,
                    typeCarPicker,
                    countryLabel,
                    countryPicker
                }
                
            };

            /*    this.Content = new TableView
            {
                
                Intent = TableIntent.Data,
                Root = new TableRoot("Car Selection")
                {
                    new TableSection("Car Selection 1")
                    {
                        new TextCell
                        {
                            Text = "Car"
                        }
                    },
                    new TableSection("Car Selection 2")
                    {
                        new TextCell
                        {
                            Text = "Type drive"
                        }
                    },
                    new TableSection("Car Selection 3")
                    {
                        new TextCell
                        {
                            Text = "Type car"
                        }
                    },
                }
            };*/

            Button button = new Button
            {
                Text = "Find",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += OnButtonClicked;
            //stackLayout.Children.Add(button);
            //this.Content = stackLayout;

            Label header = new Label
            {
                Text = "Список машин",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
            
            var list = new List<Cars>();

            list.Add(new Mercedes_Benz_C());
            list.Add(new Ferrari_F());
            list.Add(new BMW_5());

            string[] cars = new string[10];

            for (int i = 0; i < list.Count; i++)
            {
                cars[i] = $"{list[i].name},\n {list[i].country}";
                //cars.Append(list[i].name);
            }
            //string[] cars = new string[]
            //    {"Mercedes-Benz C-classe 64 AMG Coupe", "BMW M5 Competition", "Ferrari F12TDF"};

            ListView listView = new ListView();
            listView.ItemsSource = cars;
            
            this.Content = new StackLayout { Padding = new Thickness(40), Children = {typeDriveLabel,
                    typeDrivePicker,
                    typeCarLabel,
                    typeCarPicker,
                    countryLabel,
                    countryPicker,
                    button,
                    header, listView}};

            InitializeComponent();
        }

        private void carList_ItemSelected(object sender, EventArgs  e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Уведомление", "Пришло новое сообщение", "ОK");
        }
        
        private void OnButtonClicked(object sender, System.EventArgs e)//, List<Cars> list, string[] cars)
        {
            /*Button button = (Button)sender;
            cars = new string[10];
            for (int i = 0; i < list.Count; i++)
            {
                if ((typeDrivePicker.SelectedItem.ToString() == list[i].typeDrive) | (typeDrivePicker.SelectedItem == "All"))
                {
                    if ((typeCarPicker.SelectedItem.ToString() == list[i].typeCar) | (typeCarPicker.SelectedItem == "All"))
                    {
                        if (countryPicker.SelectedItem.ToString() == list[i].country | countryPicker.SelectedItem == "All")
                        {
                            cars.Append(list[i].name);
                        }
                    }
                }
            } 
            ListView listView = new ListView();
            listView.ItemsSource = cars;
            button.Text = "Нажато!";
            button.BackgroundColor = Color.Red;*/
            var list = new List<Cars>();

            list.Add(new Mercedes_Benz_C());
            list.Add(new Ferrari_F());
            list.Add(new BMW_5());
            int j = 0;
            string[] cars = new string[10];

            for (int i = 0; i < list.Count; i++)
            {
                if ((typeDrivePicker.SelectedItem.ToString() == list[i].typeDrive) | (typeDrivePicker.SelectedItem == "All"))
                {
                    if ((typeCarPicker.SelectedItem.ToString() == list[i].typeCar) | (typeCarPicker.SelectedItem == "All"))
                    {
                        if (countryPicker.SelectedItem.ToString() == list[i].country | countryPicker.SelectedItem == "All")
                        {
                            cars[j] = list[i].name;
                            j++;
                        }
                    }
                }
            } 
            //string[] cars = new string[]
            //    {"Mercedes-Benz C-classe 64 AMG Coupe", "BMW M5 Competition", "Ferrari F12TDF"};

            ListView listView = new ListView();
            listView.ItemsSource = cars;
            
            Button button = new Button
            {
                Text = "Find",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += OnButtonClicked;
            
            Label header = new Label
            {
                Text = "Список машин",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
            
            this.Content = new StackLayout { Padding = new Thickness(40), Children = {typeDriveLabel,
                typeDrivePicker,
                typeCarLabel,
                typeCarPicker,
                countryLabel,
                countryPicker,
                button,
                header, listView}};
        }
        void picker_SelectedIndexChanged1(object sender, EventArgs e)
        {
            //typeDriveHeader.Text = "Вы выбрали: " + typeDrivePicker.Items[typeDrivePicker.SelectedIndex];
        }
        void picker_SelectedIndexChanged2(object sender, EventArgs e)
        {
            //typeCarHeader.Text = "Вы выбрали: " + typeCarPicker.Items[typeCarPicker.SelectedIndex];
        }
        void picker_SelectedIndexChanged3(object sender, EventArgs e)
        {
            //countryHeader.Text = "Вы выбрали: " + countryPicker.Items[countryPicker.SelectedIndex];
        }
    }
}