namespace AirLines_S2
{
    partial class ShedulesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FromComboBox = new System.Windows.Forms.ComboBox();
            this.ToComboBox = new System.Windows.Forms.ComboBox();
            this.ApplyAirportsButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FlightNumBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteFromButton = new System.Windows.Forms.Button();
            this.DeleteToButton = new System.Windows.Forms.Button();
            this.DeleteNumButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ApplyNumbersButton = new System.Windows.Forms.Button();
            this.DateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(13, 414);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(179, 38);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel/Confirm flight";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "To:";
            // 
            // FromComboBox
            // 
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Items.AddRange(new object[] {
            "NONE"});
            this.FromComboBox.Location = new System.Drawing.Point(63, 41);
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(150, 24);
            this.FromComboBox.TabIndex = 6;
            // 
            // ToComboBox
            // 
            this.ToComboBox.FormattingEnabled = true;
            this.ToComboBox.Location = new System.Drawing.Point(63, 70);
            this.ToComboBox.Name = "ToComboBox";
            this.ToComboBox.Size = new System.Drawing.Size(150, 24);
            this.ToComboBox.TabIndex = 7;
            // 
            // ApplyAirportsButton
            // 
            this.ApplyAirportsButton.Location = new System.Drawing.Point(95, 100);
            this.ApplyAirportsButton.Name = "ApplyAirportsButton";
            this.ApplyAirportsButton.Size = new System.Drawing.Size(78, 31);
            this.ApplyAirportsButton.TabIndex = 8;
            this.ApplyAirportsButton.Text = "Apply";
            this.ApplyAirportsButton.UseVisualStyleBackColor = true;
            this.ApplyAirportsButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(671, 100);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(117, 31);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Update DB";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FlightNumBox
            // 
            this.FlightNumBox.Location = new System.Drawing.Point(383, 17);
            this.FlightNumBox.Name = "FlightNumBox";
            this.FlightNumBox.Size = new System.Drawing.Size(100, 22);
            this.FlightNumBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Flight Number:";
            // 
            // DeleteFromButton
            // 
            this.DeleteFromButton.Location = new System.Drawing.Point(219, 41);
            this.DeleteFromButton.Name = "DeleteFromButton";
            this.DeleteFromButton.Size = new System.Drawing.Size(24, 24);
            this.DeleteFromButton.TabIndex = 13;
            this.DeleteFromButton.Text = "X";
            this.DeleteFromButton.UseVisualStyleBackColor = true;
            this.DeleteFromButton.Click += new System.EventHandler(this.DeleteFromButton_Click);
            // 
            // DeleteToButton
            // 
            this.DeleteToButton.Location = new System.Drawing.Point(219, 71);
            this.DeleteToButton.Name = "DeleteToButton";
            this.DeleteToButton.Size = new System.Drawing.Size(24, 24);
            this.DeleteToButton.TabIndex = 14;
            this.DeleteToButton.Text = "X";
            this.DeleteToButton.UseVisualStyleBackColor = true;
            this.DeleteToButton.Click += new System.EventHandler(this.DeleteToButton_Click);
            // 
            // DeleteNumButton
            // 
            this.DeleteNumButton.Location = new System.Drawing.Point(489, 15);
            this.DeleteNumButton.Name = "DeleteNumButton";
            this.DeleteNumButton.Size = new System.Drawing.Size(24, 24);
            this.DeleteNumButton.TabIndex = 15;
            this.DeleteNumButton.Text = "X";
            this.DeleteNumButton.UseVisualStyleBackColor = true;
            this.DeleteNumButton.Click += new System.EventHandler(this.DeleteNumButton_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(262, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 122);
            this.label5.TabIndex = 16;
            // 
            // ApplyNumbersButton
            // 
            this.ApplyNumbersButton.Location = new System.Drawing.Point(394, 45);
            this.ApplyNumbersButton.Name = "ApplyNumbersButton";
            this.ApplyNumbersButton.Size = new System.Drawing.Size(78, 31);
            this.ApplyNumbersButton.TabIndex = 17;
            this.ApplyNumbersButton.Text = "Apply";
            this.ApplyNumbersButton.UseVisualStyleBackColor = true;
            this.ApplyNumbersButton.Click += new System.EventHandler(this.ApplyNumbersButton_Click);
            // 
            // DateButton
            // 
            this.DateButton.Location = new System.Drawing.Point(655, 45);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(78, 31);
            this.DateButton.TabIndex = 20;
            this.DateButton.Text = "Apply";
            this.DateButton.UseVisualStyleBackColor = true;
            this.DateButton.Click += new System.EventHandler(this.DateButton_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(519, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 122);
            this.label6.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Flight Date:";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(613, 17);
            this.DatePicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(175, 22);
            this.DatePicker.TabIndex = 28;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(219, 414);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(96, 38);
            this.EditButton.TabIndex = 29;
            this.EditButton.Text = "Edit flight";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ShedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ApplyNumbersButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteNumButton);
            this.Controls.Add(this.DeleteToButton);
            this.Controls.Add(this.DeleteFromButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FlightNumBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ApplyAirportsButton);
            this.Controls.Add(this.ToComboBox);
            this.Controls.Add(this.FromComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShedulesForm";
            this.Text = "Manage Flight Schedules";
            this.Load += new System.EventHandler(this.ShedulesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FromComboBox;
        private System.Windows.Forms.ComboBox ToComboBox;
        private System.Windows.Forms.Button ApplyAirportsButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox FlightNumBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteFromButton;
        private System.Windows.Forms.Button DeleteToButton;
        private System.Windows.Forms.Button DeleteNumButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ApplyNumbersButton;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button EditButton;
    }
}

