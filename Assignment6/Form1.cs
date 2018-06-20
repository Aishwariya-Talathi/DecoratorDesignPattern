using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        Car car = null;
        String complete_info = "New Order : ";

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                car = new Car_C();
                car.Initial_car_cost();
                int i = car.Cost;
                textBox1.Text = i.ToString();
                complete_info += "\nCar: " + car.Model + " with ";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                car = new Car_E();
                car.Initial_car_cost();
                int i = car.Cost;
                textBox1.Text = i.ToString();
                complete_info += "\nCar: " + car.Model + " with ";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                car = new Car_CS();
                car.Initial_car_cost();
                int i = car.Cost;
                textBox1.Text = i.ToString();
                complete_info += "\nCar: " + car.Model + " with ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked))
            {
                MessageBox.Show("Car Model Not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(car != null)
            {
                if (checkBox4.Checked)
                {
                    String temp = checkBox4.Tag.ToString();
                    ComputeCost(temp);
                }

                if (checkBox5.Checked)
                {
                    String temp = checkBox5.Tag.ToString();
                    ComputeCost(temp);
                }
                if (checkBox6.Checked)
                {
                    String temp = checkBox6.Tag.ToString();
                    ComputeCost(temp);
                }
                if (checkBox7.Checked)
                {
                    String temp = checkBox7.Tag.ToString();
                    ComputeCost(temp);
                }
                if (checkBox8.Checked)
                {
                    String temp = checkBox8.Tag.ToString();
                    ComputeCost(temp);
                }
                    
                if (checkBox9.Checked)
                {
                    String temp = checkBox9.Tag.ToString();
                    ComputeCost(temp);
                }
                if (checkBox10.Checked)
                {
                    String temp = checkBox10.Tag.ToString();
                    ComputeCost(temp);
                }
                if (checkBox11.Checked)
                {
                    String temp = checkBox11.Tag.ToString();
                    ComputeCost(temp);
                }
                if (checkBox12.Checked)
                {
                    String temp = checkBox12.Tag.ToString();
                    ComputeCost(temp);
                }
                if (checkBox13.Checked)
                {
                    String temp = checkBox13.Tag.ToString();
                    ComputeCost(temp);
                }
                if (checkBox14.Checked)
                {
                    String temp = checkBox14.Tag.ToString();
                    ComputeCost(temp);
                }
                if (checkBox15.Checked)
                {
                    String temp = checkBox15.Tag.ToString();
                    ComputeCost(temp);
                }
                complete_info += " \nEnd Order";
                complete_info += "\nCost: "+ car.Cost.ToString();
                MessageBox.Show(complete_info,"Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValues();
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to quit?", "Exit application",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (dr == DialogResult.Yes) {
                Application.Exit();
            }      
        }

        private void ResetValues()
        {
            complete_info = "";
            car.Cost = 0;
            car = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            textBox1.Text = "";
        }

        public void ComputeCost(String Addons)
        {
            DecoratorClass decorations = null;
            if (Addons == "V-8 Engine")
            {
                decorations = new V8Engine(car);
            }
            else if (Addons == "V-12 Engine")
            {
                decorations = new V12Engine(car);
            }
            else if (Addons == "Sun Roof")
            {
                decorations = new SunRoof(car);
            }
            else if (Addons == "Towing Package")
            {
                decorations = new TowingPackage(car);
            }
            else if (Addons == "OverSized Gas Tank")
            {
                decorations = new OverSizedGasTank(car);
            }
            else if (Addons == "Puma Skin Seats")
            {
                decorations = new PumaSkinSeats(car);
            }
            else if (Addons == "Seal Skin Seats")
            {
                decorations = new SealSkinSeats(car);
            }
            else if (Addons == "Komodo Dragon Skin Seats")
            {
                decorations = new komodoDragonSkinSeats(car);
            }
            else if (Addons == "32 oz Cup Holders")
            {
                decorations = new CupHolder(car);
            }
            else if (Addons == "Blaupunkt New York 800 Radio")
            {
                decorations = new Radio(car);
            }

            else if (Addons == "Spare Tire")
            {
                decorations = new SpareTire(car);
            }
            else if (Addons == "Free First Oil Change")
            {
                decorations = new FirstFreeOilChange(car);
            }
            if (decorations != null)
            {
                decorations.Initial_car_cost();
                if (!decorations.Error.Equals(""))
                {
                    MessageBox.Show(decorations.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    decorations.Error = "";
                }
                else
                {
                    complete_info = complete_info + "\n"+ Addons + " ";
                    textBox1.Text = car.Cost.ToString();
                }
            }
        }


        public void UpdateCostAndPrintError(DecoratorClass decorations,String Addons)
        {
            if (decorations != null)
            {
                decorations.Initial_car_cost();
                if (!decorations.Error.Equals(""))
                {
                    MessageBox.Show(decorations.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    decorations.Error = "";
                }
                else
                {
                    complete_info = complete_info + Addons + " ";
                    textBox1.Text = car.Cost.ToString();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
