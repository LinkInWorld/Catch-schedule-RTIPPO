﻿namespace lab6
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.catchPlanGroupBox = new System.Windows.Forms.GroupBox();
            this.catchPlanScheduleGroupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selectedIdLabel = new System.Windows.Forms.Label();
            this.catchPlanScheduleButton4 = new System.Windows.Forms.Button();
            this.catchPlanScheduleButton3 = new System.Windows.Forms.Button();
            this.catchPlanScheduleGroupBox2 = new System.Windows.Forms.GroupBox();
            this.ExceptionLabel2 = new System.Windows.Forms.Label();
            this.catchPlanScheduleButton2 = new System.Windows.Forms.Button();
            this.catchPlanScheduleRadioButton3 = new System.Windows.Forms.RadioButton();
            this.catchPlanScheduleRadioButton2 = new System.Windows.Forms.RadioButton();
            this.catchPlanScheduleRadioButton1 = new System.Windows.Forms.RadioButton();
            this.catchSheduleTextBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.catchPlanScheduleGroupBox1 = new System.Windows.Forms.GroupBox();
            this.ExceptionLabel1 = new System.Windows.Forms.Label();
            this.catchPlanScheduleButton1 = new System.Windows.Forms.Button();
            this.catchSheduleTextBox1 = new System.Windows.Forms.TextBox();
            this.catchScheduleComboBox2 = new System.Windows.Forms.ComboBox();
            this.catchScheduleComboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.catchPlanGroupBox.SuspendLayout();
            this.catchPlanScheduleGroupBox3.SuspendLayout();
            this.catchPlanScheduleGroupBox2.SuspendLayout();
            this.catchPlanScheduleGroupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Реестр муниципальных контрактов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(594, 504);
            this.dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Реестр организаций";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "Реестр планов отлова";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // catchPlanGroupBox
            // 
            this.catchPlanGroupBox.Controls.Add(this.catchPlanScheduleGroupBox3);
            this.catchPlanGroupBox.Controls.Add(this.catchPlanScheduleGroupBox1);
            this.catchPlanGroupBox.Controls.Add(this.catchPlanScheduleGroupBox2);
            this.catchPlanGroupBox.Location = new System.Drawing.Point(613, 10);
            this.catchPlanGroupBox.Name = "catchPlanGroupBox";
            this.catchPlanGroupBox.Size = new System.Drawing.Size(212, 504);
            this.catchPlanGroupBox.TabIndex = 5;
            this.catchPlanGroupBox.TabStop = false;
            this.catchPlanGroupBox.Text = "Реестр планов графиков";
            // 
            // catchPlanScheduleGroupBox3
            // 
            this.catchPlanScheduleGroupBox3.Controls.Add(this.label8);
            this.catchPlanScheduleGroupBox3.Controls.Add(this.label7);
            this.catchPlanScheduleGroupBox3.Controls.Add(this.selectedIdLabel);
            this.catchPlanScheduleGroupBox3.Controls.Add(this.catchPlanScheduleButton4);
            this.catchPlanScheduleGroupBox3.Controls.Add(this.catchPlanScheduleButton3);
            this.catchPlanScheduleGroupBox3.Location = new System.Drawing.Point(6, 373);
            this.catchPlanScheduleGroupBox3.Name = "catchPlanScheduleGroupBox3";
            this.catchPlanScheduleGroupBox3.Size = new System.Drawing.Size(200, 125);
            this.catchPlanScheduleGroupBox3.TabIndex = 4;
            this.catchPlanScheduleGroupBox3.TabStop = false;
            this.catchPlanScheduleGroupBox3.Text = "Разное";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Выберите строку в реестре";
            // 
            // selectedIdLabel
            // 
            this.selectedIdLabel.AutoSize = true;
            this.selectedIdLabel.Location = new System.Drawing.Point(19, 43);
            this.selectedIdLabel.Name = "selectedIdLabel";
            this.selectedIdLabel.Size = new System.Drawing.Size(77, 13);
            this.selectedIdLabel.TabIndex = 13;
            this.selectedIdLabel.Text = "Выбранный id";
            // 
            // catchPlanScheduleButton4
            // 
            this.catchPlanScheduleButton4.Location = new System.Drawing.Point(119, 38);
            this.catchPlanScheduleButton4.Name = "catchPlanScheduleButton4";
            this.catchPlanScheduleButton4.Size = new System.Drawing.Size(75, 23);
            this.catchPlanScheduleButton4.TabIndex = 3;
            this.catchPlanScheduleButton4.Text = "Открыть";
            this.catchPlanScheduleButton4.UseVisualStyleBackColor = true;
            // 
            // catchPlanScheduleButton3
            // 
            this.catchPlanScheduleButton3.Location = new System.Drawing.Point(119, 96);
            this.catchPlanScheduleButton3.Name = "catchPlanScheduleButton3";
            this.catchPlanScheduleButton3.Size = new System.Drawing.Size(75, 23);
            this.catchPlanScheduleButton3.TabIndex = 2;
            this.catchPlanScheduleButton3.Text = "Excel";
            this.catchPlanScheduleButton3.UseVisualStyleBackColor = true;
            // 
            // catchPlanScheduleGroupBox2
            // 
            this.catchPlanScheduleGroupBox2.Controls.Add(this.ExceptionLabel2);
            this.catchPlanScheduleGroupBox2.Controls.Add(this.catchPlanScheduleButton2);
            this.catchPlanScheduleGroupBox2.Controls.Add(this.catchPlanScheduleRadioButton3);
            this.catchPlanScheduleGroupBox2.Controls.Add(this.catchPlanScheduleRadioButton2);
            this.catchPlanScheduleGroupBox2.Controls.Add(this.catchPlanScheduleRadioButton1);
            this.catchPlanScheduleGroupBox2.Controls.Add(this.catchSheduleTextBox2);
            this.catchPlanScheduleGroupBox2.Controls.Add(this.label6);
            this.catchPlanScheduleGroupBox2.Controls.Add(this.label5);
            this.catchPlanScheduleGroupBox2.Location = new System.Drawing.Point(6, 196);
            this.catchPlanScheduleGroupBox2.Name = "catchPlanScheduleGroupBox2";
            this.catchPlanScheduleGroupBox2.Size = new System.Drawing.Size(200, 171);
            this.catchPlanScheduleGroupBox2.TabIndex = 1;
            this.catchPlanScheduleGroupBox2.TabStop = false;
            this.catchPlanScheduleGroupBox2.Text = "Фильтр/Сортировка";
            // 
            // ExceptionLabel2
            // 
            this.ExceptionLabel2.AutoSize = true;
            this.ExceptionLabel2.Location = new System.Drawing.Point(87, 144);
            this.ExceptionLabel2.Name = "ExceptionLabel2";
            this.ExceptionLabel2.Size = new System.Drawing.Size(25, 13);
            this.ExceptionLabel2.TabIndex = 8;
            this.ExceptionLabel2.Text = "Null";
            // 
            // catchPlanScheduleButton2
            // 
            this.catchPlanScheduleButton2.Location = new System.Drawing.Point(6, 139);
            this.catchPlanScheduleButton2.Name = "catchPlanScheduleButton2";
            this.catchPlanScheduleButton2.Size = new System.Drawing.Size(75, 23);
            this.catchPlanScheduleButton2.TabIndex = 8;
            this.catchPlanScheduleButton2.Text = "Применить";
            this.catchPlanScheduleButton2.UseVisualStyleBackColor = true;
            // 
            // catchPlanScheduleRadioButton3
            // 
            this.catchPlanScheduleRadioButton3.AutoSize = true;
            this.catchPlanScheduleRadioButton3.Location = new System.Drawing.Point(99, 81);
            this.catchPlanScheduleRadioButton3.Name = "catchPlanScheduleRadioButton3";
            this.catchPlanScheduleRadioButton3.Size = new System.Drawing.Size(43, 17);
            this.catchPlanScheduleRadioButton3.TabIndex = 12;
            this.catchPlanScheduleRadioButton3.TabStop = true;
            this.catchPlanScheduleRadioButton3.Text = "Год";
            this.catchPlanScheduleRadioButton3.UseVisualStyleBackColor = true;
            // 
            // catchPlanScheduleRadioButton2
            // 
            this.catchPlanScheduleRadioButton2.AutoSize = true;
            this.catchPlanScheduleRadioButton2.Location = new System.Drawing.Point(99, 54);
            this.catchPlanScheduleRadioButton2.Name = "catchPlanScheduleRadioButton2";
            this.catchPlanScheduleRadioButton2.Size = new System.Drawing.Size(58, 17);
            this.catchPlanScheduleRadioButton2.TabIndex = 11;
            this.catchPlanScheduleRadioButton2.TabStop = true;
            this.catchPlanScheduleRadioButton2.Text = "Месяц";
            this.catchPlanScheduleRadioButton2.UseVisualStyleBackColor = true;
            // 
            // catchPlanScheduleRadioButton1
            // 
            this.catchPlanScheduleRadioButton1.AutoSize = true;
            this.catchPlanScheduleRadioButton1.Location = new System.Drawing.Point(99, 27);
            this.catchPlanScheduleRadioButton1.Name = "catchPlanScheduleRadioButton1";
            this.catchPlanScheduleRadioButton1.Size = new System.Drawing.Size(79, 17);
            this.catchPlanScheduleRadioButton1.TabIndex = 10;
            this.catchPlanScheduleRadioButton1.TabStop = true;
            this.catchPlanScheduleRadioButton1.Text = "Нас. пункт";
            this.catchPlanScheduleRadioButton1.UseVisualStyleBackColor = true;
            // 
            // catchSheduleTextBox2
            // 
            this.catchSheduleTextBox2.Location = new System.Drawing.Point(70, 113);
            this.catchSheduleTextBox2.Name = "catchSheduleTextBox2";
            this.catchSheduleTextBox2.Size = new System.Drawing.Size(108, 20);
            this.catchSheduleTextBox2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Сортировать по";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Фильтр";
            // 
            // catchPlanScheduleGroupBox1
            // 
            this.catchPlanScheduleGroupBox1.Controls.Add(this.ExceptionLabel1);
            this.catchPlanScheduleGroupBox1.Controls.Add(this.catchPlanScheduleButton1);
            this.catchPlanScheduleGroupBox1.Controls.Add(this.catchSheduleTextBox1);
            this.catchPlanScheduleGroupBox1.Controls.Add(this.catchScheduleComboBox2);
            this.catchPlanScheduleGroupBox1.Controls.Add(this.catchScheduleComboBox1);
            this.catchPlanScheduleGroupBox1.Controls.Add(this.label4);
            this.catchPlanScheduleGroupBox1.Controls.Add(this.label3);
            this.catchPlanScheduleGroupBox1.Controls.Add(this.label2);
            this.catchPlanScheduleGroupBox1.Location = new System.Drawing.Point(6, 19);
            this.catchPlanScheduleGroupBox1.Name = "catchPlanScheduleGroupBox1";
            this.catchPlanScheduleGroupBox1.Size = new System.Drawing.Size(200, 171);
            this.catchPlanScheduleGroupBox1.TabIndex = 0;
            this.catchPlanScheduleGroupBox1.TabStop = false;
            this.catchPlanScheduleGroupBox1.Text = "Добавить";
            // 
            // ExceptionLabel1
            // 
            this.ExceptionLabel1.AutoSize = true;
            this.ExceptionLabel1.Location = new System.Drawing.Point(6, 116);
            this.ExceptionLabel1.Name = "ExceptionLabel1";
            this.ExceptionLabel1.Size = new System.Drawing.Size(25, 13);
            this.ExceptionLabel1.TabIndex = 7;
            this.ExceptionLabel1.Text = "Null";
            // 
            // catchPlanScheduleButton1
            // 
            this.catchPlanScheduleButton1.Location = new System.Drawing.Point(6, 139);
            this.catchPlanScheduleButton1.Name = "catchPlanScheduleButton1";
            this.catchPlanScheduleButton1.Size = new System.Drawing.Size(75, 23);
            this.catchPlanScheduleButton1.TabIndex = 6;
            this.catchPlanScheduleButton1.Text = "Добавить";
            this.catchPlanScheduleButton1.UseVisualStyleBackColor = true;
            this.catchPlanScheduleButton1.Click += new System.EventHandler(this.catchPlanScheduleButton1_Click);
            // 
            // catchSheduleTextBox1
            // 
            this.catchSheduleTextBox1.Location = new System.Drawing.Point(86, 80);
            this.catchSheduleTextBox1.Name = "catchSheduleTextBox1";
            this.catchSheduleTextBox1.Size = new System.Drawing.Size(108, 20);
            this.catchSheduleTextBox1.TabIndex = 5;
            // 
            // catchScheduleComboBox2
            // 
            this.catchScheduleComboBox2.CausesValidation = false;
            this.catchScheduleComboBox2.FormattingEnabled = true;
            this.catchScheduleComboBox2.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December "});
            this.catchScheduleComboBox2.Location = new System.Drawing.Point(86, 53);
            this.catchScheduleComboBox2.Name = "catchScheduleComboBox2";
            this.catchScheduleComboBox2.Size = new System.Drawing.Size(108, 21);
            this.catchScheduleComboBox2.TabIndex = 4;
            // 
            // catchScheduleComboBox1
            // 
            this.catchScheduleComboBox1.FormattingEnabled = true;
            this.catchScheduleComboBox1.Location = new System.Drawing.Point(86, 26);
            this.catchScheduleComboBox1.Name = "catchScheduleComboBox1";
            this.catchScheduleComboBox1.Size = new System.Drawing.Size(108, 21);
            this.catchScheduleComboBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Год";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Месяц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Нас. пункт";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(160, 21);
            this.tabControl1.Location = new System.Drawing.Point(9, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 581);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.catchPlanGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(835, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Реестр планов отлова";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1003, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Реестр организаций";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 11);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(698, 418);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1003, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Реестр муниципальных контрактов";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(9, 8);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(703, 427);
            this.dataGridView3.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 651);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "План-график отлова";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.catchPlanGroupBox.ResumeLayout(false);
            this.catchPlanScheduleGroupBox3.ResumeLayout(false);
            this.catchPlanScheduleGroupBox3.PerformLayout();
            this.catchPlanScheduleGroupBox2.ResumeLayout(false);
            this.catchPlanScheduleGroupBox2.PerformLayout();
            this.catchPlanScheduleGroupBox1.ResumeLayout(false);
            this.catchPlanScheduleGroupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox catchPlanGroupBox;
        private System.Windows.Forms.GroupBox catchPlanScheduleGroupBox2;
        private System.Windows.Forms.GroupBox catchPlanScheduleGroupBox1;
        private System.Windows.Forms.TextBox catchSheduleTextBox1;
        private System.Windows.Forms.ComboBox catchScheduleComboBox2;
        private System.Windows.Forms.ComboBox catchScheduleComboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton catchPlanScheduleRadioButton3;
        private System.Windows.Forms.RadioButton catchPlanScheduleRadioButton2;
        private System.Windows.Forms.RadioButton catchPlanScheduleRadioButton1;
        private System.Windows.Forms.TextBox catchSheduleTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ExceptionLabel1;
        private System.Windows.Forms.Button catchPlanScheduleButton1;
        private System.Windows.Forms.GroupBox catchPlanScheduleGroupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label selectedIdLabel;
        private System.Windows.Forms.Button catchPlanScheduleButton4;
        private System.Windows.Forms.Button catchPlanScheduleButton3;
        private System.Windows.Forms.Label ExceptionLabel2;
        private System.Windows.Forms.Button catchPlanScheduleButton2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}