namespace AirLines_S2
{
    partial class EditFlight
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
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AircraftLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FlightTimeBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(128, 96);
            this.DatePicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(175, 22);
            this.DatePicker.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Flight Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "From:";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromLabel.Location = new System.Drawing.Point(92, 31);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(64, 17);
            this.FromLabel.TabIndex = 32;
            this.FromLabel.Text = "{FROM}";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToLabel.Location = new System.Drawing.Point(212, 31);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(42, 17);
            this.ToLabel.TabIndex = 34;
            this.ToLabel.Text = "{TO}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "From:";
            // 
            // AircraftLabel
            // 
            this.AircraftLabel.AutoSize = true;
            this.AircraftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AircraftLabel.Location = new System.Drawing.Point(323, 31);
            this.AircraftLabel.Name = "AircraftLabel";
            this.AircraftLabel.Size = new System.Drawing.Size(95, 17);
            this.AircraftLabel.TabIndex = 36;
            this.AircraftLabel.Text = "{AIRCRAFT}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Aircraft:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Flight Time:";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(128, 154);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(87, 22);
            this.PriceBox.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Price:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(140, 236);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(101, 33);
            this.UpdateButton.TabIndex = 41;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(247, 236);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(101, 33);
            this.CancelButton.TabIndex = 42;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FlightTimeBox
            // 
            this.FlightTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FlightTimeBox.Location = new System.Drawing.Point(128, 124);
            this.FlightTimeBox.Name = "FlightTimeBox";
            this.FlightTimeBox.Size = new System.Drawing.Size(87, 22);
            this.FlightTimeBox.TabIndex = 43;
            this.FlightTimeBox.Value = new System.DateTime(2021, 1, 24, 14, 46, 0, 0);
            // 
            // EditFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 297);
            this.Controls.Add(this.FlightTimeBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AircraftLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label7);
            this.Name = "EditFlight";
            this.Text = "Edit Flight";
            this.Load += new System.EventHandler(this.EditFlight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AircraftLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DateTimePicker FlightTimeBox;
    }
}