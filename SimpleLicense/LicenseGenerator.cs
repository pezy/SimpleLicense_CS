using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SimpleLicense
{
    public partial class LicenseGenerator : Form
    {
        public LicenseGenerator()
        {
            InitializeComponent();
        }

        private void LicenseGenerator_Load(object sender, EventArgs e)
        {
            textBox_username.Text = Environment.MachineName;
            textBox_MAC.Text = SystemTools.GetLocal();
            dateTimePicker_Expired.Value = DateTime.Today.AddMonths(2);
        }

        private void button_Generate_MouseClick(object sender, MouseEventArgs e)
        {
            string info = textBox_MAC.Text + " " + dateTimePicker_Expired.Text;
            string encryptedInfo = AesTools.Encrypt(info);
            File.WriteAllText(textBox_username.Text + ".lic", encryptedInfo);
            Process.Start(".");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[a-fA-F0-9-]"))
                e.Handled = true;
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
