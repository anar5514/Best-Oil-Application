using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilApp
{
    public partial class BestOil : Form
    {
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

            priceHotdog.Text = "3,00";
            priceHamburger.Text = "7,00";
            priceCheesebrgr.Text = "5,50";
            priceCocacola.Text = "5,30";

        }

        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFuel.SelectedIndex)
            {
                case 0:
                    txtboxPrice.Text = "1,15";
                    break;
                case 1:
                    txtboxPrice.Text = "0,90";
                    break;
                case 2:
                    txtboxPrice.Text = "0,60";
                    break;
                case 3:
                    txtboxPrice.Text = "1,50";
                    break;
                default:
                    break;
            }
        }

        private void btnquantity_CheckedChanged(object sender, EventArgs e)
        {
            if (btnquantity.Checked)
                txtboxQuantity.Enabled = true;
            else
            {
                txtboxQuantity.Enabled = false;
                txtboxQuantity.Text = String.Empty;
            }
        }

        private void btnsum_CheckedChanged(object sender, EventArgs e)
        {
            if (btnsum.Checked)
                txtboxSum.Enabled = true;
            else
            {
                txtboxSum.Enabled = false;
                txtboxSum.Text = String.Empty;
            }
        }

        private void txtboxQuantity_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txtboxQuantity.Text, out double quantity);
            double.TryParse(txtboxPrice.Text, out double price);

            labelTotalLeft.Text = (quantity * price).ToString();
        }

        private void txtboxSum_TextChanged(object sender, EventArgs e)
        {
            labelTotalLeft.Text = txtboxSum.Text;
        }

        private void counttxtbox_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "0") (sender as TextBox).Text = String.Empty;
        }

        private void counttxtbox_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == String.Empty) (sender as TextBox).Text = "0";
        }

        private void hotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (hotdog.Checked)
                countHotdog.Enabled = true;
            else
            {
                countHotdog.Enabled = false;
                countHotdog.Text = "0";
            }
        }

        private void hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (hamburger.Checked)
                countHamburger.Enabled = true;
            else
            {
                countHamburger.Enabled = false;
                countHamburger.Text = "0";
            }
        }

        private void countHotdog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                (sender as TextBox).Text = String.Empty;
                labelTotalRight.Text = String.Empty;
            }
        }

        private void cheeseburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cheeseburger.Checked)
                countCheesebrgr.Enabled = true;
            else
            {
                countCheesebrgr.Enabled = false;
                countCheesebrgr.Text = "0";
            }
        }

        private void cocacola_CheckedChanged(object sender, EventArgs e)
        {
            if (cocacola.Checked)
                countCocacola.Enabled = true;
            else
            {
                countCocacola.Enabled = false;
                countCocacola.Text = "0";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double.TryParse(priceHotdog.Text, out double pricehotdog);
            double.TryParse(countHotdog.Text, out double counthotdog);

            double.TryParse(priceHamburger.Text, out double pricehamburg);
            double.TryParse(countHamburger.Text, out double counthamburg);

            double.TryParse(priceCheesebrgr.Text, out double pricecheese);
            double.TryParse(countCheesebrgr.Text, out double countcheese);

            double.TryParse(priceCocacola.Text, out double pricecola);
            double.TryParse(countCocacola.Text, out double countcola);

            labelTotalRight.Text = ((pricehotdog * counthotdog) + (pricehamburg * counthamburg)
                + (pricecheese * countcheese)
                + (pricecola * countcola)).ToString();

            if (labelTotalRight.Text == "0" && labelTotalLeft.Text != null) MessageBox.Show("There is no order !","Warning");
            else totalPayment.Text =  (Convert.ToDouble(labelTotalLeft.Text) + Convert.ToDouble(labelTotalRight.Text)).ToString();


            BestOilData bestOilData = new BestOilData()
            {
                FuelComboBox = comboBoxFuel.Text,
                PriceTextBox = txtboxPrice.Text,
                QuantityTextBox = txtboxQuantity.Text,
                SumTextBox = txtboxSum.Text,
                TotalLeft = labelTotalLeft.Text,

                HotDogPriceTextBox = priceHotdog.Text,
                HamburgerPriceTextBox = priceHamburger.Text,
                CheeseburgerPriceTextBox = priceCheesebrgr.Text,
                CocacolaPriceTextBox = priceCocacola.Text,

                HotDogQuantityTextBox = countHotdog.Text,
                HamburgerQuantityTextBox = countHamburger.Text,
                CheeseburgerQuantityTextBox = countCheesebrgr.Text,
                CocacolaQuantityTextBox = countCocacola.Text,

                TotalRight = labelTotalRight.Text,

                TotalPayment = totalPayment.Text
            };

            var content = JsonConvert.SerializeObject(bestOilData);

            File.WriteAllText("BestOil.json", content);

        }
    }


}
