namespace TipCalculator
{
    partial class TipCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxTipPersent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.TextBoxPerson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelBill = new System.Windows.Forms.Label();
            this.labelTotalTip = new System.Windows.Forms.Label();
            this.labelTotalPerson = new System.Windows.Forms.Label();
            this.labelPerPersonTip = new System.Windows.Forms.Label();
            this.labelTotalBills = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxBill
            // 
            this.TextBoxBill.Location = new System.Drawing.Point(12, 76);
            this.TextBoxBill.Name = "TextBoxBill";
            this.TextBoxBill.Size = new System.Drawing.Size(133, 23);
            this.TextBoxBill.TabIndex = 0;
            this.TextBoxBill.Text = "0";
            this.TextBoxBill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBill_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill:*";
            // 
            // TextBoxTipPersent
            // 
            this.TextBoxTipPersent.Location = new System.Drawing.Point(12, 124);
            this.TextBoxTipPersent.Name = "TextBoxTipPersent";
            this.TextBoxTipPersent.Size = new System.Drawing.Size(133, 23);
            this.TextBoxTipPersent.TabIndex = 1;
            this.TextBoxTipPersent.Text = "0";
            this.TextBoxTipPersent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxTipPersent_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(191, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip Calculator";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Heading.Location = new System.Drawing.Point(11, 104);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(110, 17);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Tip Persantage:*";
            // 
            // TextBoxPerson
            // 
            this.TextBoxPerson.Location = new System.Drawing.Point(12, 174);
            this.TextBoxPerson.Name = "TextBoxPerson";
            this.TextBoxPerson.Size = new System.Drawing.Size(134, 23);
            this.TextBoxPerson.TabIndex = 2;
            this.TextBoxPerson.Text = "1";
            this.TextBoxPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPerson_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tip For:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(151, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(147, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(147, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Taka";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(191, 109);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 42);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.Location = new System.Drawing.Point(11, 255);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 23);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(489, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(289, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bill                 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(286, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total Tip         :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(284, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Total Person    :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(283, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Per Person Tip :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(282, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total Bill         :";
            // 
            // labelBill
            // 
            this.labelBill.AutoSize = true;
            this.labelBill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBill.Location = new System.Drawing.Point(395, 56);
            this.labelBill.Name = "labelBill";
            this.labelBill.Size = new System.Drawing.Size(15, 17);
            this.labelBill.TabIndex = 5;
            this.labelBill.Text = "0";
            // 
            // labelTotalTip
            // 
            this.labelTotalTip.AutoSize = true;
            this.labelTotalTip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalTip.Location = new System.Drawing.Point(395, 83);
            this.labelTotalTip.Name = "labelTotalTip";
            this.labelTotalTip.Size = new System.Drawing.Size(15, 17);
            this.labelTotalTip.TabIndex = 5;
            this.labelTotalTip.Text = "0";
            // 
            // labelTotalPerson
            // 
            this.labelTotalPerson.AutoSize = true;
            this.labelTotalPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPerson.Location = new System.Drawing.Point(395, 109);
            this.labelTotalPerson.Name = "labelTotalPerson";
            this.labelTotalPerson.Size = new System.Drawing.Size(15, 17);
            this.labelTotalPerson.TabIndex = 5;
            this.labelTotalPerson.Text = "0";
            // 
            // labelPerPersonTip
            // 
            this.labelPerPersonTip.AutoSize = true;
            this.labelPerPersonTip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPerPersonTip.Location = new System.Drawing.Point(395, 134);
            this.labelPerPersonTip.Name = "labelPerPersonTip";
            this.labelPerPersonTip.Size = new System.Drawing.Size(15, 17);
            this.labelPerPersonTip.TabIndex = 5;
            this.labelPerPersonTip.Text = "0";
            // 
            // labelTotalBills
            // 
            this.labelTotalBills.AutoSize = true;
            this.labelTotalBills.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalBills.Location = new System.Drawing.Point(395, 164);
            this.labelTotalBills.Name = "labelTotalBills";
            this.labelTotalBills.Size = new System.Drawing.Size(18, 20);
            this.labelTotalBills.TabIndex = 5;
            this.labelTotalBills.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(11, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 285);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelTotalBills);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelPerPersonTip);
            this.Controls.Add(this.labelTotalPerson);
            this.Controls.Add(this.labelTotalTip);
            this.Controls.Add(this.labelBill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxTipPersent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxBill);
            this.MaximumSize = new System.Drawing.Size(592, 324);
            this.MinimumSize = new System.Drawing.Size(592, 324);
            this.Name = "TipCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxBill;
        private Label label1;
        private TextBox TextBoxTipPersent;
        private Label label2;
        private Label Heading;
        private TextBox TextBoxPerson;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button btnCalculate;
        private Button btnHistory;
        private Button btnExit;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label labelBill;
        private Label labelTotalTip;
        private Label labelTotalPerson;
        private Label labelPerPersonTip;
        private Label labelTotalBills;
        private Button btnClear;
    }
}