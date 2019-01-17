namespace BestOilApp
{
    partial class BestOil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.minicafe = new System.Windows.Forms.Label();
            this.autofuel = new System.Windows.Forms.Label();
            this.zz = new System.Windows.Forms.Label();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.labelprice = new System.Windows.Forms.Label();
            this.labelfuel = new System.Windows.Forms.Label();
            this.comboBoxPrice = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnsum = new System.Windows.Forms.RadioButton();
            this.btnquantity = new System.Windows.Forms.RadioButton();
            this.txtboxQuantity = new System.Windows.Forms.TextBox();
            this.txtboxSum = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelazn = new System.Windows.Forms.Label();
            this.totalLeft = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.hotdog = new System.Windows.Forms.CheckBox();
            this.cocacola = new System.Windows.Forms.CheckBox();
            this.cheeseburger = new System.Windows.Forms.CheckBox();
            this.hamburger = new System.Windows.Forms.CheckBox();
            this.la = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.priceHotdog = new System.Windows.Forms.TextBox();
            this.countHotdog = new System.Windows.Forms.TextBox();
            this.countHamburger = new System.Windows.Forms.TextBox();
            this.priceCocacola = new System.Windows.Forms.TextBox();
            this.priceCheesebrgr = new System.Windows.Forms.TextBox();
            this.priceHamburger = new System.Windows.Forms.TextBox();
            this.countCheesebrgr = new System.Windows.Forms.TextBox();
            this.countCocacola = new System.Windows.Forms.TextBox();
            this.totalRight = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.totalpriceLeft = new System.Windows.Forms.Label();
            this.totalpriceRight = new System.Windows.Forms.Label();
            this.totalPayment = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // minicafe
            // 
            this.minicafe.BackColor = System.Drawing.SystemColors.Control;
            this.minicafe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minicafe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minicafe.Location = new System.Drawing.Point(417, 21);
            this.minicafe.Name = "minicafe";
            this.minicafe.Size = new System.Drawing.Size(303, 369);
            this.minicafe.TabIndex = 1;
            this.minicafe.Text = "Mini-cafe";
            // 
            // autofuel
            // 
            this.autofuel.BackColor = System.Drawing.SystemColors.Control;
            this.autofuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autofuel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.autofuel.Location = new System.Drawing.Point(12, 21);
            this.autofuel.Name = "autofuel";
            this.autofuel.Size = new System.Drawing.Size(303, 369);
            this.autofuel.TabIndex = 2;
            this.autofuel.Text = "Auto fuel";
            // 
            // zz
            // 
            this.zz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zz.Location = new System.Drawing.Point(12, 408);
            this.zz.Name = "zz";
            this.zz.Size = new System.Drawing.Size(708, 89);
            this.zz.TabIndex = 3;
            this.zz.Text = "Total Payment";
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Location = new System.Drawing.Point(116, 60);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(148, 21);
            this.comboBoxFuel.TabIndex = 5;
            this.comboBoxFuel.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuel_SelectedIndexChanged);
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Location = new System.Drawing.Point(24, 107);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(31, 13);
            this.labelprice.TabIndex = 6;
            this.labelprice.Text = "Price";
            // 
            // labelfuel
            // 
            this.labelfuel.AutoSize = true;
            this.labelfuel.Location = new System.Drawing.Point(24, 63);
            this.labelfuel.Name = "labelfuel";
            this.labelfuel.Size = new System.Drawing.Size(27, 13);
            this.labelfuel.TabIndex = 7;
            this.labelfuel.Text = "Fuel";
            // 
            // comboBoxPrice
            // 
            this.comboBoxPrice.Location = new System.Drawing.Point(116, 104);
            this.comboBoxPrice.Name = "comboBoxPrice";
            this.comboBoxPrice.ReadOnly = true;
            this.comboBoxPrice.Size = new System.Drawing.Size(148, 20);
            this.comboBoxPrice.TabIndex = 8;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnsum);
            this.groupBox.Controls.Add(this.btnquantity);
            this.groupBox.Location = new System.Drawing.Point(30, 149);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(106, 70);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            // 
            // btnsum
            // 
            this.btnsum.AutoSize = true;
            this.btnsum.Location = new System.Drawing.Point(19, 42);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(46, 17);
            this.btnsum.TabIndex = 1;
            this.btnsum.TabStop = true;
            this.btnsum.Text = "Sum";
            this.btnsum.UseVisualStyleBackColor = true;
            // 
            // btnquantity
            // 
            this.btnquantity.AutoSize = true;
            this.btnquantity.Location = new System.Drawing.Point(19, 17);
            this.btnquantity.Name = "btnquantity";
            this.btnquantity.Size = new System.Drawing.Size(64, 17);
            this.btnquantity.TabIndex = 0;
            this.btnquantity.TabStop = true;
            this.btnquantity.Text = "Quantity";
            this.btnquantity.UseVisualStyleBackColor = true;
            // 
            // txtboxQuantity
            // 
            this.txtboxQuantity.Location = new System.Drawing.Point(171, 165);
            this.txtboxQuantity.Name = "txtboxQuantity";
            this.txtboxQuantity.Size = new System.Drawing.Size(93, 20);
            this.txtboxQuantity.TabIndex = 11;
            // 
            // txtboxSum
            // 
            this.txtboxSum.Location = new System.Drawing.Point(171, 191);
            this.txtboxSum.Name = "txtboxSum";
            this.txtboxSum.Size = new System.Drawing.Size(93, 20);
            this.txtboxSum.TabIndex = 12;
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(270, 198);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(29, 13);
            this.sum.TabIndex = 13;
            this.sum.Text = "AZN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Litr";
            // 
            // labelazn
            // 
            this.labelazn.AutoSize = true;
            this.labelazn.Location = new System.Drawing.Point(270, 107);
            this.labelazn.Name = "labelazn";
            this.labelazn.Size = new System.Drawing.Size(29, 13);
            this.labelazn.TabIndex = 15;
            this.labelazn.Text = "AZN";
            // 
            // totalLeft
            // 
            this.totalLeft.Location = new System.Drawing.Point(27, 256);
            this.totalLeft.Name = "totalLeft";
            this.totalLeft.Size = new System.Drawing.Size(267, 116);
            this.totalLeft.TabIndex = 16;
            this.totalLeft.Text = "Total";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(233, 336);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 13);
            this.label.TabIndex = 17;
            this.label.Text = "AZN";
            // 
            // hotdog
            // 
            this.hotdog.AutoSize = true;
            this.hotdog.Location = new System.Drawing.Point(436, 64);
            this.hotdog.Name = "hotdog";
            this.hotdog.Size = new System.Drawing.Size(64, 17);
            this.hotdog.TabIndex = 18;
            this.hotdog.Text = "Hot-dog";
            this.hotdog.UseVisualStyleBackColor = true;
            // 
            // cocacola
            // 
            this.cocacola.AutoSize = true;
            this.cocacola.Location = new System.Drawing.Point(436, 191);
            this.cocacola.Name = "cocacola";
            this.cocacola.Size = new System.Drawing.Size(74, 17);
            this.cocacola.TabIndex = 19;
            this.cocacola.Text = "Coca-cola";
            this.cocacola.UseVisualStyleBackColor = true;
            // 
            // cheeseburger
            // 
            this.cheeseburger.AutoSize = true;
            this.cheeseburger.Location = new System.Drawing.Point(436, 149);
            this.cheeseburger.Name = "cheeseburger";
            this.cheeseburger.Size = new System.Drawing.Size(92, 17);
            this.cheeseburger.TabIndex = 20;
            this.cheeseburger.Text = "Cheeseburger";
            this.cheeseburger.UseVisualStyleBackColor = true;
            // 
            // hamburger
            // 
            this.hamburger.AutoSize = true;
            this.hamburger.Location = new System.Drawing.Point(436, 107);
            this.hamburger.Name = "hamburger";
            this.hamburger.Size = new System.Drawing.Size(78, 17);
            this.hamburger.TabIndex = 21;
            this.hamburger.Text = "Hamburger";
            this.hamburger.UseVisualStyleBackColor = true;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(577, 34);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(31, 13);
            this.la.TabIndex = 22;
            this.la.Text = "Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(661, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Miqdar";
            // 
            // priceHotdog
            // 
            this.priceHotdog.Location = new System.Drawing.Point(552, 62);
            this.priceHotdog.Name = "priceHotdog";
            this.priceHotdog.ReadOnly = true;
            this.priceHotdog.Size = new System.Drawing.Size(66, 20);
            this.priceHotdog.TabIndex = 27;
            // 
            // countHotdog
            // 
            this.countHotdog.Location = new System.Drawing.Point(636, 62);
            this.countHotdog.Name = "countHotdog";
            this.countHotdog.Size = new System.Drawing.Size(66, 20);
            this.countHotdog.TabIndex = 28;
            this.countHotdog.Text = "0";
            // 
            // countHamburger
            // 
            this.countHamburger.Location = new System.Drawing.Point(636, 105);
            this.countHamburger.Name = "countHamburger";
            this.countHamburger.Size = new System.Drawing.Size(66, 20);
            this.countHamburger.TabIndex = 29;
            this.countHamburger.Text = "0";
            // 
            // priceCocacola
            // 
            this.priceCocacola.Location = new System.Drawing.Point(552, 188);
            this.priceCocacola.Name = "priceCocacola";
            this.priceCocacola.ReadOnly = true;
            this.priceCocacola.Size = new System.Drawing.Size(66, 20);
            this.priceCocacola.TabIndex = 30;
            // 
            // priceCheesebrgr
            // 
            this.priceCheesebrgr.Location = new System.Drawing.Point(552, 146);
            this.priceCheesebrgr.Name = "priceCheesebrgr";
            this.priceCheesebrgr.ReadOnly = true;
            this.priceCheesebrgr.Size = new System.Drawing.Size(66, 20);
            this.priceCheesebrgr.TabIndex = 31;
            // 
            // priceHamburger
            // 
            this.priceHamburger.Location = new System.Drawing.Point(552, 105);
            this.priceHamburger.Name = "priceHamburger";
            this.priceHamburger.ReadOnly = true;
            this.priceHamburger.Size = new System.Drawing.Size(66, 20);
            this.priceHamburger.TabIndex = 32;
            // 
            // countCheesebrgr
            // 
            this.countCheesebrgr.Location = new System.Drawing.Point(636, 146);
            this.countCheesebrgr.Name = "countCheesebrgr";
            this.countCheesebrgr.Size = new System.Drawing.Size(66, 20);
            this.countCheesebrgr.TabIndex = 33;
            this.countCheesebrgr.Text = "0";
            // 
            // countCocacola
            // 
            this.countCocacola.Location = new System.Drawing.Point(636, 188);
            this.countCocacola.Name = "countCocacola";
            this.countCocacola.Size = new System.Drawing.Size(66, 20);
            this.countCocacola.TabIndex = 34;
            this.countCocacola.Text = "0";
            // 
            // totalRight
            // 
            this.totalRight.Location = new System.Drawing.Point(433, 256);
            this.totalRight.Name = "totalRight";
            this.totalRight.Size = new System.Drawing.Size(267, 116);
            this.totalRight.TabIndex = 35;
            this.totalRight.Text = "Total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(646, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "AZN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(616, 473);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "AZN";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(140, 424);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 53);
            this.btnCalculate.TabIndex = 38;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // totalpriceLeft
            // 
            this.totalpriceLeft.Location = new System.Drawing.Point(113, 304);
            this.totalpriceLeft.Name = "totalpriceLeft";
            this.totalpriceLeft.Size = new System.Drawing.Size(100, 45);
            this.totalpriceLeft.TabIndex = 39;
            // 
            // totalpriceRight
            // 
            this.totalpriceRight.Location = new System.Drawing.Point(530, 304);
            this.totalpriceRight.Name = "totalpriceRight";
            this.totalpriceRight.Size = new System.Drawing.Size(100, 45);
            this.totalpriceRight.TabIndex = 41;
            // 
            // totalPayment
            // 
            this.totalPayment.Location = new System.Drawing.Point(457, 424);
            this.totalPayment.Name = "totalPayment";
            this.totalPayment.Size = new System.Drawing.Size(133, 62);
            this.totalPayment.TabIndex = 42;
            // 
            // BestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 506);
            this.Controls.Add(this.totalPayment);
            this.Controls.Add(this.totalpriceRight);
            this.Controls.Add(this.totalpriceLeft);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.totalRight);
            this.Controls.Add(this.countCocacola);
            this.Controls.Add(this.countCheesebrgr);
            this.Controls.Add(this.priceHamburger);
            this.Controls.Add(this.priceCheesebrgr);
            this.Controls.Add(this.priceCocacola);
            this.Controls.Add(this.countHamburger);
            this.Controls.Add(this.countHotdog);
            this.Controls.Add(this.priceHotdog);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.la);
            this.Controls.Add(this.hamburger);
            this.Controls.Add(this.cheeseburger);
            this.Controls.Add(this.cocacola);
            this.Controls.Add(this.hotdog);
            this.Controls.Add(this.label);
            this.Controls.Add(this.totalLeft);
            this.Controls.Add(this.labelazn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.txtboxSum);
            this.Controls.Add(this.txtboxQuantity);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.comboBoxPrice);
            this.Controls.Add(this.labelfuel);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.comboBoxFuel);
            this.Controls.Add(this.zz);
            this.Controls.Add(this.autofuel);
            this.Controls.Add(this.minicafe);
            this.Name = "BestOil";
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.BestOil_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minicafe;
        private System.Windows.Forms.Label autofuel;
        private System.Windows.Forms.Label zz;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label labelfuel;
        private System.Windows.Forms.TextBox comboBoxPrice;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton btnsum;
        private System.Windows.Forms.RadioButton btnquantity;
        private System.Windows.Forms.TextBox txtboxQuantity;
        private System.Windows.Forms.TextBox txtboxSum;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelazn;
        private System.Windows.Forms.Label totalLeft;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox hotdog;
        private System.Windows.Forms.CheckBox cocacola;
        private System.Windows.Forms.CheckBox cheeseburger;
        private System.Windows.Forms.CheckBox hamburger;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox priceHotdog;
        private System.Windows.Forms.TextBox countHotdog;
        private System.Windows.Forms.TextBox countHamburger;
        private System.Windows.Forms.TextBox priceCocacola;
        private System.Windows.Forms.TextBox priceCheesebrgr;
        private System.Windows.Forms.TextBox priceHamburger;
        private System.Windows.Forms.TextBox countCheesebrgr;
        private System.Windows.Forms.TextBox countCocacola;
        private System.Windows.Forms.Label totalRight;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label totalpriceLeft;
        private System.Windows.Forms.Label totalpriceRight;
        private System.Windows.Forms.Label totalPayment;
    }
}

