
namespace TipCalculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownTip = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPeople = new System.Windows.Forms.NumericUpDown();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxBill = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of People";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "per person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "per person";
            // 
            // numericUpDownTip
            // 
            this.numericUpDownTip.Location = new System.Drawing.Point(108, 199);
            this.numericUpDownTip.Maximum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.numericUpDownTip.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownTip.Name = "numericUpDownTip";
            this.numericUpDownTip.ReadOnly = true;
            this.numericUpDownTip.Size = new System.Drawing.Size(131, 22);
            this.numericUpDownTip.TabIndex = 9;
            this.numericUpDownTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownPeople
            // 
            this.numericUpDownPeople.Location = new System.Drawing.Point(108, 324);
            this.numericUpDownPeople.Maximum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.numericUpDownPeople.Name = "numericUpDownPeople";
            this.numericUpDownPeople.ReadOnly = true;
            this.numericUpDownPeople.Size = new System.Drawing.Size(131, 22);
            this.numericUpDownPeople.TabIndex = 12;
            this.numericUpDownPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip.Location = new System.Drawing.Point(566, 118);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(0, 25);
            this.labelTip.TabIndex = 13;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(566, 235);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 25);
            this.labelTotal.TabIndex = 14;
            // 
            // textBoxBill
            // 
            this.textBoxBill.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxBill.Location = new System.Drawing.Point(108, 93);
            this.textBoxBill.Name = "textBoxBill";
            this.textBoxBill.Size = new System.Drawing.Size(131, 22);
            this.textBoxBill.TabIndex = 8;
            this.textBoxBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBill_KeyPress);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(724, 427);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.textBoxBill);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.numericUpDownPeople);
            this.Controls.Add(this.numericUpDownTip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownTip;
        private System.Windows.Forms.NumericUpDown numericUpDownPeople;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxBill;
        private System.Windows.Forms.Button Clear;
    }
}

