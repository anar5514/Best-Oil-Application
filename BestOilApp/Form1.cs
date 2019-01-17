using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilApp
{   
    public partial class BestOil : Form
    {
        //private Fuel CurrentFuel { get; set; }

        public BestOil()
        {
            InitializeComponent();
        }

        private void BestOil_Load(object sender, EventArgs e)
        {

            comboBoxFuel.Text = "Choose fuel";
            comboBoxFuel.Items.Add("A-95");
            comboBoxFuel.Items.Add("A-92");
            comboBoxFuel.Items.Add("DIZEL");
            comboBoxFuel.Items.Add("A-98");

            priceHotdog.Text = "3.00";
            priceHamburger.Text = "7.00";
            priceCheesebrgr.Text = "5.50";
            priceCocacola.Text = "5.30";

        }

        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFuel.SelectedIndex)
            {
                case 0:
                    comboBoxPrice.Text = "1.15";
                    break;
                case 1:
                    comboBoxPrice.Text = "0.90";
                    break;
                case 2:
                    comboBoxPrice.Text = "0.60";
                    break;
                case 3:
                    comboBoxPrice.Text = "1.50";
                    break;
                default:
                    break;
            }
        }

        
    }
    

    enum Fuel
    {
        A95,
        A98,
        A92,
        DIZEL,
        Premium
    }
    

}
