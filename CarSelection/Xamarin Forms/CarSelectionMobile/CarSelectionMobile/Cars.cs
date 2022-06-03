namespace CarSelectionMobile
{
    public class Cars
    {
        public string brand;
        public string name;
        public string typeDrive;
        public string typeCar;
        public string country;
        public string power;
        public string zeroTo;
        public string maxSpeed;

        public Cars(string brand, string name, string typeDrive, string typeCar, string country, string power, string zeroTo, string maxSpeed)
        {
            this.brand = brand;
            this.name = name;
            this.typeDrive = typeDrive;
            this.typeCar = typeCar;
            this.country = country;
            this.power = power;
            this.zeroTo = zeroTo;
            this.maxSpeed = maxSpeed;
        }

    }

    public class Mercedes_Benz_C : Cars
    {
        public Mercedes_Benz_C() : base("Mercedes-Benz", "Mercedes -Benz C-Classe 63 AMG Coupe", "Rear-wheel drive", "Coupe", "Germany", "476 h.p.", "4 sec.", "\nMax. speed - 250 km/h")
        { }
    }

    public class BMW_5 : Cars
    {
        public BMW_5() : base("BMW", "BMW M5 Competition", "All-wheel drive", "Passenger", "Germany", "625 h.p.", "3.3 sec.", "250 km/h")
        { }

    }
    public class Ferrari_F : Cars
    {
        public Ferrari_F() : base("Ferrari", "Ferrari F12TDF", "Rear-wheel drive", "Sport", "Italy", "770 h.p.", "0-100 - 2.9 sec.", "340+ km/h")
        { }
    }
}