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
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.labelprice = new System.Windows.Forms.Label();
            this.labelfuel = new System.Windows.Forms.Label();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnsum = new System.Windows.Forms.RadioButton();
            this.btnquantity = new System.Windows.Forms.RadioButton();
            this.txtboxQuantity = new System.Windows.Forms.TextBox();
            this.txtboxSum = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelazn = new System.Windows.Forms.Label();
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
            this.label15 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.totalpriceLeft = new System.Windows.Forms.Label();
            this.totalPayment = new System.Windows.Forms.Label();
            this.grpboxAutofuel = new System.Windows.Forms.GroupBox();
            this.grpboxtotalLeft = new System.Windows.Forms.GroupBox();
            this.labelTotalLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxMinicafe = new System.Windows.Forms.GroupBox();
            this.grpboxtotalRight = new System.Windows.Forms.GroupBox();
            this.labelTotalRight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpboxTotalPayment = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.grpboxAutofuel.SuspendLayout();
            this.grpboxtotalLeft.SuspendLayout();
            this.grpboxMinicafe.SuspendLayout();
            this.grpboxtotalRight.SuspendLayout();
            this.grpboxTotalPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Location = new System.Drawing.Point(100, 25);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(148, 21);
            this.comboBoxFuel.TabIndex = 5;
            this.comboBoxFuel.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuel_SelectedIndexChanged);
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Location = new System.Drawing.Point(8, 72);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(31, 13);
            this.labelprice.TabIndex = 6;
            this.labelprice.Text = "Price";
            // 
            // labelfuel
            // 
            this.labelfuel.AutoSize = true;
            this.labelfuel.Location = new System.Drawing.Point(8, 28);
            this.labelfuel.Name = "labelfuel";
            this.labelfuel.Size = new System.Drawing.Size(27, 13);
            this.labelfuel.TabIndex = 7;
            this.labelfuel.Text = "Fuel";
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(100, 69);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.ReadOnly = true;
            this.txtboxPrice.Size = new System.Drawing.Size(148, 20);
            this.txtboxPrice.TabIndex = 8;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnsum);
            this.groupBox.Controls.Add(this.btnquantity);
            this.groupBox.Location = new System.Drawing.Point(14, 114);
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
            this.btnsum.CheckedChanged += new System.EventHandler(this.btnsum_CheckedChanged);
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
            this.btnquantity.CheckedChanged += new System.EventHandler(this.btnquantity_CheckedChanged);
            // 
            // txtboxQuantity
            // 
            this.txtboxQuantity.Enabled = false;
            this.txtboxQuantity.Location = new System.Drawing.Point(155, 130);
            this.txtboxQuantity.Name = "txtboxQuantity";
            this.txtboxQuantity.Size = new System.Drawing.Size(93, 20);
            this.txtboxQuantity.TabIndex = 11;
            this.txtboxQuantity.TextChanged += new System.EventHandler(this.txtboxQuantity_TextChanged);
            // 
            // txtboxSum
            // 
            this.txtboxSum.Enabled = false;
            this.txtboxSum.Location = new System.Drawing.Point(155, 156);
            this.txtboxSum.Name = "txtboxSum";
            this.txtboxSum.Size = new System.Drawing.Size(93, 20);
            this.txtboxSum.TabIndex = 12;
            this.txtboxSum.TextChanged += new System.EventHandler(this.txtboxSum_TextChanged);
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(254, 163);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(29, 13);
            this.sum.TabIndex = 13;
            this.sum.Text = "AZN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Litr";
            // 
            // labelazn
            // 
            this.labelazn.AutoSize = true;
            this.labelazn.Location = new System.Drawing.Point(254, 72);
            this.labelazn.Name = "labelazn";
            this.labelazn.Size = new System.Drawing.Size(29, 13);
            this.labelazn.TabIndex = 15;
            this.labelazn.Text = "AZN";
            // 
            // hotdog
            // 
            this.hotdog.AutoSize = true;
            this.hotdog.Location = new System.Drawing.Point(15, 50);
            this.hotdog.Name = "hotdog";
            this.hotdog.Size = new System.Drawing.Size(64, 17);
            this.hotdog.TabIndex = 18;
            this.hotdog.Text = "Hot-dog";
            this.hotdog.UseVisualStyleBackColor = true;
            this.hotdog.CheckedChanged += new System.EventHandler(this.hotdog_CheckedChanged);
            // 
            // cocacola
            // 
            this.cocacola.AutoSize = true;
            this.cocacola.Location = new System.Drawing.Point(15, 177);
            this.cocacola.Name = "cocacola";
            this.cocacola.Size = new System.Drawing.Size(74, 17);
            this.cocacola.TabIndex = 19;
            this.cocacola.Text = "Coca-cola";
            this.cocacola.UseVisualStyleBackColor = true;
            this.cocacola.CheckedChanged += new System.EventHandler(this.cocacola_CheckedChanged);
            // 
            // cheeseburger
            // 
            this.cheeseburger.AutoSize = true;
            this.cheeseburger.Location = new System.Drawing.Point(15, 135);
            this.cheeseburger.Name = "cheeseburger";
            this.cheeseburger.Size = new System.Drawing.Size(92, 17);
            this.cheeseburger.TabIndex = 20;
            this.cheeseburger.Text = "Cheeseburger";
            this.cheeseburger.UseVisualStyleBackColor = true;
            this.cheeseburger.CheckedChanged += new System.EventHandler(this.cheeseburger_CheckedChanged);
            // 
            // hamburger
            // 
            this.hamburger.AutoSize = true;
            this.hamburger.Location = new System.Drawing.Point(15, 93);
            this.hamburger.Name = "hamburger";
            this.hamburger.Size = new System.Drawing.Size(78, 17);
            this.hamburger.TabIndex = 21;
            this.hamburger.Text = "Hamburger";
            this.hamburger.UseVisualStyleBackColor = true;
            this.hamburger.CheckedChanged += new System.EventHandler(this.hamburger_CheckedChanged);
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(156, 20);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(31, 13);
            this.la.TabIndex = 22;
            this.la.Text = "Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(240, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Miqdar";
            // 
            // priceHotdog
            // 
            this.priceHotdog.Location = new System.Drawing.Point(131, 48);
            this.priceHotdog.Name = "priceHotdog";
            this.priceHotdog.ReadOnly = true;
            this.priceHotdog.Size = new System.Drawing.Size(66, 20);
            this.priceHotdog.TabIndex = 27;
            // 
            // countHotdog
            // 
            this.countHotdog.Enabled = false;
            this.countHotdog.Location = new System.Drawing.Point(215, 48);
            this.countHotdog.Name = "countHotdog";
            this.countHotdog.Size = new System.Drawing.Size(66, 20);
            this.countHotdog.TabIndex = 28;
            this.countHotdog.Text = "0";
            this.countHotdog.Enter += new System.EventHandler(this.counttxtbox_Enter);
            this.countHotdog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countHotdog_KeyPress);
            this.countHotdog.Leave += new System.EventHandler(this.counttxtbox_Leave);
            // 
            // countHamburger
            // 
            this.countHamburger.Enabled = false;
            this.countHamburger.Location = new System.Drawing.Point(215, 91);
            this.countHamburger.Name = "countHamburger";
            this.countHamburger.Size = new System.Drawing.Size(66, 20);
            this.countHamburger.TabIndex = 29;
            this.countHamburger.Text = "0";
            this.countHamburger.Enter += new System.EventHandler(this.counttxtbox_Enter);
            this.countHamburger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countHotdog_KeyPress);
            // 
            // priceCocacola
            // 
            this.priceCocacola.Location = new System.Drawing.Point(131, 174);
            this.priceCocacola.Name = "priceCocacola";
            this.priceCocacola.ReadOnly = true;
            this.priceCocacola.Size = new System.Drawing.Size(66, 20);
            this.priceCocacola.TabIndex = 30;
            // 
            // priceCheesebrgr
            // 
            this.priceCheesebrgr.Location = new System.Drawing.Point(131, 132);
            this.priceCheesebrgr.Name = "priceCheesebrgr";
            this.priceCheesebrgr.ReadOnly = true;
            this.priceCheesebrgr.Size = new System.Drawing.Size(66, 20);
            this.priceCheesebrgr.TabIndex = 31;
            // 
            // priceHamburger
            // 
            this.priceHamburger.Location = new System.Drawing.Point(131, 91);
            this.priceHamburger.Name = "priceHamburger";
            this.priceHamburger.ReadOnly = true;
            this.priceHamburger.Size = new System.Drawing.Size(66, 20);
            this.priceHamburger.TabIndex = 32;
            // 
            // countCheesebrgr
            // 
            this.countCheesebrgr.Enabled = false;
            this.countCheesebrgr.Location = new System.Drawing.Point(215, 132);
            this.countCheesebrgr.Name = "countCheesebrgr";
            this.countCheesebrgr.Size = new System.Drawing.Size(66, 20);
            this.countCheesebrgr.TabIndex = 33;
            this.countCheesebrgr.Text = "0";
            this.countCheesebrgr.Enter += new System.EventHandler(this.counttxtbox_Enter);
            this.countCheesebrgr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countHotdog_KeyPress);
            // 
            // countCocacola
            // 
            this.countCocacola.Enabled = false;
            this.countCocacola.Location = new System.Drawing.Point(215, 174);
            this.countCocacola.Name = "countCocacola";
            this.countCocacola.Size = new System.Drawing.Size(66, 20);
            this.countCocacola.TabIndex = 34;
            this.countCocacola.Text = "0";
            this.countCocacola.Enter += new System.EventHandler(this.counttxtbox_Enter);
            this.countCocacola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countHotdog_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(520, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "AZN";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(117, 19);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 53);
            this.btnCalculate.TabIndex = 38;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // totalpriceLeft
            // 
            this.totalpriceLeft.Location = new System.Drawing.Point(97, 269);
            this.totalpriceLeft.Name = "totalpriceLeft";
            this.totalpriceLeft.Size = new System.Drawing.Size(100, 45);
            this.totalpriceLeft.TabIndex = 39;
            // 
            // totalPayment
            // 
            this.totalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayment.Location = new System.Drawing.Point(361, 19);
            this.totalPayment.Name = "totalPayment";
            this.totalPayment.Size = new System.Drawing.Size(133, 62);
            this.totalPayment.TabIndex = 42;
            this.totalPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // grpboxAutofuel
            // 
            this.grpboxAutofuel.BackColor = System.Drawing.Color.Silver;
            this.grpboxAutofuel.Controls.Add(this.grpboxtotalLeft);
            this.grpboxAutofuel.Controls.Add(this.comboBoxFuel);
            this.grpboxAutofuel.Controls.Add(this.labelprice);
            this.grpboxAutofuel.Controls.Add(this.labelfuel);
            this.grpboxAutofuel.Controls.Add(this.totalpriceLeft);
            this.grpboxAutofuel.Controls.Add(this.txtboxPrice);
            this.grpboxAutofuel.Controls.Add(this.groupBox);
            this.grpboxAutofuel.Controls.Add(this.txtboxQuantity);
            this.grpboxAutofuel.Controls.Add(this.txtboxSum);
            this.grpboxAutofuel.Controls.Add(this.sum);
            this.grpboxAutofuel.Controls.Add(this.label7);
            this.grpboxAutofuel.Controls.Add(this.labelazn);
            this.grpboxAutofuel.Location = new System.Drawing.Point(12, 21);
            this.grpboxAutofuel.Name = "grpboxAutofuel";
            this.grpboxAutofuel.Size = new System.Drawing.Size(303, 369);
            this.grpboxAutofuel.TabIndex = 43;
            this.grpboxAutofuel.TabStop = false;
            this.grpboxAutofuel.Text = "Auto fuel";
            // 
            // grpboxtotalLeft
            // 
            this.grpboxtotalLeft.Controls.Add(this.labelTotalLeft);
            this.grpboxtotalLeft.Controls.Add(this.label1);
            this.grpboxtotalLeft.Location = new System.Drawing.Point(14, 250);
            this.grpboxtotalLeft.Name = "grpboxtotalLeft";
            this.grpboxtotalLeft.Size = new System.Drawing.Size(269, 100);
            this.grpboxtotalLeft.TabIndex = 40;
            this.grpboxtotalLeft.TabStop = false;
            this.grpboxtotalLeft.Text = "Total";
            // 
            // labelTotalLeft
            // 
            this.labelTotalLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLeft.Location = new System.Drawing.Point(77, 19);
            this.labelTotalLeft.Name = "labelTotalLeft";
            this.labelTotalLeft.Size = new System.Drawing.Size(126, 62);
            this.labelTotalLeft.TabIndex = 42;
            this.labelTotalLeft.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "AZN";
            // 
            // grpboxMinicafe
            // 
            this.grpboxMinicafe.BackColor = System.Drawing.Color.Silver;
            this.grpboxMinicafe.Controls.Add(this.grpboxtotalRight);
            this.grpboxMinicafe.Controls.Add(this.cheeseburger);
            this.grpboxMinicafe.Controls.Add(this.hotdog);
            this.grpboxMinicafe.Controls.Add(this.cocacola);
            this.grpboxMinicafe.Controls.Add(this.hamburger);
            this.grpboxMinicafe.Controls.Add(this.la);
            this.grpboxMinicafe.Controls.Add(this.label12);
            this.grpboxMinicafe.Controls.Add(this.priceHotdog);
            this.grpboxMinicafe.Controls.Add(this.countHotdog);
            this.grpboxMinicafe.Controls.Add(this.countCocacola);
            this.grpboxMinicafe.Controls.Add(this.countHamburger);
            this.grpboxMinicafe.Controls.Add(this.countCheesebrgr);
            this.grpboxMinicafe.Controls.Add(this.priceCocacola);
            this.grpboxMinicafe.Controls.Add(this.priceHamburger);
            this.grpboxMinicafe.Controls.Add(this.priceCheesebrgr);
            this.grpboxMinicafe.Location = new System.Drawing.Point(411, 21);
            this.grpboxMinicafe.Name = "grpboxMinicafe";
            this.grpboxMinicafe.Size = new System.Drawing.Size(303, 369);
            this.grpboxMinicafe.TabIndex = 44;
            this.grpboxMinicafe.TabStop = false;
            this.grpboxMinicafe.Text = "Mini-cafe";
            // 
            // grpboxtotalRight
            // 
            this.grpboxtotalRight.Controls.Add(this.labelTotalRight);
            this.grpboxtotalRight.Controls.Add(this.label2);
            this.grpboxtotalRight.Location = new System.Drawing.Point(28, 250);
            this.grpboxtotalRight.Name = "grpboxtotalRight";
            this.grpboxtotalRight.Size = new System.Drawing.Size(269, 100);
            this.grpboxtotalRight.TabIndex = 41;
            this.grpboxtotalRight.TabStop = false;
            this.grpboxtotalRight.Text = "Total";
            // 
            // labelTotalRight
            // 
            this.labelTotalRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRight.Location = new System.Drawing.Point(83, 19);
            this.labelTotalRight.Name = "labelTotalRight";
            this.labelTotalRight.Size = new System.Drawing.Size(126, 62);
            this.labelTotalRight.TabIndex = 43;
            this.labelTotalRight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "AZN";
            // 
            // grpboxTotalPayment
            // 
            this.grpboxTotalPayment.BackColor = System.Drawing.Color.Silver;
            this.grpboxTotalPayment.Controls.Add(this.btnCalculate);
            this.grpboxTotalPayment.Controls.Add(this.label15);
            this.grpboxTotalPayment.Controls.Add(this.totalPayment);
            this.grpboxTotalPayment.Location = new System.Drawing.Point(12, 405);
            this.grpboxTotalPayment.Name = "grpboxTotalPayment";
            this.grpboxTotalPayment.Size = new System.Drawing.Size(708, 89);
            this.grpboxTotalPayment.TabIndex = 45;
            this.grpboxTotalPayment.TabStop = false;
            this.grpboxTotalPayment.Text = "Total Payment";
            // 
            // BestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 506);
            this.Controls.Add(this.grpboxTotalPayment);
            this.Controls.Add(this.grpboxMinicafe);
            this.Controls.Add(this.grpboxAutofuel);
            this.Name = "BestOil";
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.BestOil_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.grpboxAutofuel.ResumeLayout(false);
            this.grpboxAutofuel.PerformLayout();
            this.grpboxtotalLeft.ResumeLayout(false);
            this.grpboxtotalLeft.PerformLayout();
            this.grpboxMinicafe.ResumeLayout(false);
            this.grpboxMinicafe.PerformLayout();
            this.grpboxtotalRight.ResumeLayout(false);
            this.grpboxtotalRight.PerformLayout();
            this.grpboxTotalPayment.ResumeLayout(false);
            this.grpboxTotalPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label labelfuel;
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton btnsum;
        private System.Windows.Forms.RadioButton btnquantity;
        private System.Windows.Forms.TextBox txtboxQuantity;
        private System.Windows.Forms.TextBox txtboxSum;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelazn;
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label totalpriceLeft;
        private System.Windows.Forms.Label totalPayment;
        private System.Windows.Forms.GroupBox grpboxAutofuel;
        private System.Windows.Forms.GroupBox grpboxMinicafe;
        private System.Windows.Forms.GroupBox grpboxtotalLeft;
        private System.Windows.Forms.GroupBox grpboxtotalRight;
        private System.Windows.Forms.GroupBox grpboxTotalPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalLeft;
        private System.Windows.Forms.Label labelTotalRight;
    }
}

