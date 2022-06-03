using System.Data;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        /*public struct Car
        {
            public string name;
            public string typeDrive;


            public Car(string name, string typeDrive)
            {
                this.name = name;
                this.typeDrive = typeDrive;
            }
        }
        List<Car> cars = new List<Car>();*/

        DataTable table = new DataTable();
        public void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            
            table.Columns.Add("Car");
            table.Columns.Add("Name");
            table.Columns.Add("Drive Type");
            table.Columns.Add("Body Type");
            table.Columns.Add("Country Of Origin");
            table.Columns.Add("Power");
            table.Columns.Add("0-100");
            table.Columns.Add("Max. Speed");
            table.Columns.Add("Photo", typeof(Image));

            dataGridView1.DataSource = table;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
        } 
        
        public Form1()
        {
            InitializeComponent();
            comboBoxWheels.Items.Add("All");
            comboBoxWheels.Items.Add("Front-wheel drive");
            comboBoxWheels.Items.Add("Rear-wheel drive");
            comboBoxWheels.Items.Add("All-wheel drive");
            comboBoxWheels.SelectedIndex = 0;


            comboBoxCarBody.Items.Add("All");
            comboBoxCarBody.Items.Add("Passenger");
            comboBoxCarBody.Items.Add("SUV");
            comboBoxCarBody.Items.Add("Coupe");
            comboBoxCarBody.Items.Add("Sport");
            comboBoxCarBody.Items.Add("Cabriolet");
            comboBoxCarBody.Items.Add("Liftback");
            comboBoxCarBody.SelectedIndex = 0;


            comboBoxCountry.Items.Add("All");
            comboBoxCountry.Items.Add("USA");
            comboBoxCountry.Items.Add("Russia");
            comboBoxCountry.Items.Add("Japan");
            comboBoxCountry.Items.Add("Germany");
            comboBoxCountry.Items.Add("Italy");
            comboBoxCountry.Items.Add("Great Britain");
            comboBoxCountry.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Clear(); 
            /*var MercedeS = new Mercedes_Benz();
            var Bmw = new BMW();
            var Ferrari = new Ferrari();*/
            var list = new List<Cars>();
            Image img = Image.FromFile("C:\\Users\\roma-\\OneDrive\\Изображения\\Savki\\12aa19589d49f0d8ef08a50119c800df.jpg");

            list.Add(new Mercedes_Benz_C());
            list.Add(new Ferrari_F());
            list.Add(new BMW_5());

            for (int i = 0; i < list.Count; i++)
            {
                if ((comboBoxWheels.SelectedItem.ToString() == list[i].typeDrive) | (comboBoxWheels.SelectedItem == "All"))
                {
                    if ((comboBoxCarBody.SelectedItem.ToString() == list[i].typeCar) | (comboBoxCarBody.SelectedItem == "All"))
                    {
                        if (comboBoxCountry.SelectedItem.ToString() == list[i].country | comboBoxCountry.SelectedItem == "All")
                        {
                            //table.Rows.Remove(table.Rows[i]);
                            //listBox1.Items.Add(list[i].name);
                            table.Rows.Add(list[i].brand, list[i].name, list[i].typeDrive, list[i].typeCar, list[i].country, list[i].power, list[i].zeroTo, list[i].maxSpeed, list[i].image);
                        }
                    }
                }
            }

            Your_Car.Text = "Your Cars:";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //table.Rows.Add(table.Rows[0]);
        }

      
    }
}