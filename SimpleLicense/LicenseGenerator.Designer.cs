namespace SimpleLicense
{
    partial class LicenseGenerator
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
            this.dateTimePicker_Expired = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Generate = new System.Windows.Forms.Button();
            this.textBox_MAC = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker_Expired
            // 
            this.dateTimePicker_Expired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Expired.Location = new System.Drawing.Point(106, 119);
            this.dateTimePicker_Expired.Name = "dateTimePicker_Expired";
            this.dateTimePicker_Expired.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_Expired.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Physical Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expired Date";
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(106, 171);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(75, 23);
            this.button_Generate.TabIndex = 3;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Generate_MouseClick);
            // 
            // textBox_MAC
            // 
            this.textBox_MAC.Location = new System.Drawing.Point(106, 80);
            this.textBox_MAC.Name = "textBox_MAC";
            this.textBox_MAC.Size = new System.Drawing.Size(100, 20);
            this.textBox_MAC.TabIndex = 1;
            this.textBox_MAC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(105, 39);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 20);
            this.textBox_username.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // LicenseGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_MAC);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_Expired);
            this.Name = "LicenseGenerator";
            this.Text = "License Generator";
            this.Load += new System.EventHandler(this.LicenseGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker_Expired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.TextBox textBox_MAC;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label3;
    }
}

