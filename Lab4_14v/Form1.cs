using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_14v
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TrB1_Scroll(object sender, EventArgs e)
        {
            L1.Text = TrB1.Value.ToString();
        }
        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            if (TB1.Text == "")
            {
                MessageBox.Show("Поле не должно быть пустым");
                return;
            }
            int mainVariable = Convert.ToInt32(TB1.Text);
            switch (comboBox1.SelectedIndex)
            {
                case 0:FinalLabel.Text = "" + mainVariable * 3.6; break; // m s
                case 1:FinalLabel.Text = "" + mainVariable * 0.28; break; // km ch
            }
            double v = Convert.ToDouble(FinalLabel.Text);
            Math.Round(v, TrB1.Value);
        }
    }
}
