﻿namespace SalaryApp
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtHours = new TextBox();
            txtRate = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtOvertime = new TextBox();
            txtRegularPay = new TextBox();
            txtTotalPay = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtHourlyRate = new TextBox();
            txtHoursWorked = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 44);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "HoursWorked:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 81);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "HourlyRate:";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(198, 44);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(100, 23);
            txtHours.TabIndex = 2;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(198, 81);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(198, 121);
            button1.Name = "button1";
            button1.Size = new Size(103, 44);
            button1.TabIndex = 4;
            button1.Text = "Calculation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 258);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "RegularPay:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 287);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Overtime:";
            // 
            // txtOvertime
            // 
            txtOvertime.Location = new Point(195, 279);
            txtOvertime.Name = "txtOvertime";
            txtOvertime.Size = new Size(100, 23);
            txtOvertime.TabIndex = 7;
            // 
            // txtRegularPay
            // 
            txtRegularPay.Location = new Point(195, 250);
            txtRegularPay.Name = "txtRegularPay";
            txtRegularPay.Size = new Size(100, 23);
            txtRegularPay.TabIndex = 8;
            // 
            // txtTotalPay
            // 
            txtTotalPay.Location = new Point(195, 319);
            txtTotalPay.Name = "txtTotalPay";
            txtTotalPay.Size = new Size(100, 23);
            txtTotalPay.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 322);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "TotalPay:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 184);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 12;
            label6.Text = "HoursWorked:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 215);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 13;
            label7.Text = "HourlyRate:";
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Location = new Point(195, 215);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(100, 23);
            txtHourlyRate.TabIndex = 14;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Location = new Point(195, 184);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(100, 23);
            txtHoursWorked.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtHoursWorked);
            Controls.Add(txtHourlyRate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTotalPay);
            Controls.Add(txtRegularPay);
            Controls.Add(txtOvertime);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtRate);
            Controls.Add(txtHours);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHours;
        private TextBox txtRate;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox txtOvertime;
        private TextBox txtRegularPay;
        private TextBox txtTotalPay;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtHourlyRate;
        private TextBox txtHoursWorked;
    }
}
