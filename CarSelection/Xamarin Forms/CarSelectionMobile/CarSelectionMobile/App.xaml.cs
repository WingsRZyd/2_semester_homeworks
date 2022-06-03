using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace CarSelectionMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}


/*<StackLayout>
        <Label x:Name="typeDriveHeader" Text="Тип привода" FontSize="Large" />
        <Picker x:Name="typeDrivePicker" SelectedIndexChanged="picker_SelectedIndexChanged1">
            <Picker.Items>
                <x:String>All</x:String>
                <x:String>Rear-wheel drive</x:String>
                <x:String>Front-wheel drive</x:String>
                <x:String>All-wheel drive</x:String>
            </Picker.Items>
        </Picker>
        
        <Label x:Name="typeCarHeader" Text="Тип кузова" FontSize="Large" />
        <Picker x:Name="typeCarPicker" SelectedIndexChanged="picker_SelectedIndexChanged2">
            <Picker.Items>
                <x:String>All</x:String>
                <x:String>Passenger</x:String>
                <x:String>SUV</x:String>
                <x:String>Coupe</x:String>
                <x:String>Sport</x:String>
                <x:String>Cabriolet</x:String>
                <x:String>Liftback</x:String>
            </Picker.Items>
        </Picker>
        
        <Label x:Name="countryHeader" Text="Страна-производитель" FontSize="Large" />
        <Picker x:Name="countryPicker" SelectedIndexChanged="picker_SelectedIndexChanged3">
            <Picker.Items>
                <x:String>All</x:String>
                <x:String>USA</x:String>
                <x:String>Russia</x:String>
                <x:String>Japan</x:String>
                <x:String>Germany</x:String>
                <x:String>Italy</x:String>
                <x:String>Great Britain</x:String>
            </Picker.Items>
        </Picker>
        
        <Label Text="Список моделей" HorizontalOptions="Center" FontSize="Large" />
        <ListView x:Name="phonesList" ItemsSource="{StaticResource Key=phones}" />
    </StackLayout>
    
    <ContentPage.Resources>
        <ResourceDictionary>
            <x:Array x:Key="phones" Type="{x:Type x:String}">
                <x:String>iPhone 7</x:String>
                <x:String>Google Pixel 5</x:String>
                <x:String>Huawei P10</x:String>
                <x:String>Xiaomi Mi6</x:String>
            </x:Array>
        </ResourceDictionary>
    </ContentPage.Resources>
    
    
    */