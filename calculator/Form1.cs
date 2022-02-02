using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox_All_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string str = tb.Text;
            int dig = 0;
            if (str != "")
            {
                if (tb.Name == textBox_HEX.Name)
                    dig = Convert.ToInt32(str, 16);
                if (tb.Name == textBox_DEC.Name)
                    dig = Convert.ToInt32(str, 10);
                if (tb.Name == textBox_OCT.Name)
                    dig = Convert.ToInt32(str, 8);
                if (tb.Name == textBox_BIN.Name)
                    dig = Convert.ToInt32(str, 2);
            }

            string str_HEX = Convert.ToString(dig, 16);
            textBox_HEX.Text = str_HEX.ToUpper();


            string str_DEC = Convert.ToString(dig, 10);
            textBox_DEC.Text = str_DEC;

            string str_OCT = Convert.ToString(dig, 8);
            textBox_OCT.Text = str_OCT;

            string str_BIN = Convert.ToString(dig, 2);
            textBox_BIN.Text = str_BIN;


            string bin_string = str_BIN;
            string hex_string = str_HEX;
            string oct_string = str_OCT;
            string dec_string = str_DEC;
            string _BIN = Regex.Replace(bin_string, ".{4}", "$0 ");
            string _HEX = Regex.Replace(hex_string, ".{4}", "$0 ");
            string _OCT = Regex.Replace(oct_string, ".{3}", "$0 ");
            string _DEC = Regex.Replace(dec_string, ".{3}", "$0 ");
            label_BIN.Text = _BIN;
            label_HEX.Text = _HEX;
            label_OCT.Text = _OCT;
            label_DEC.Text = _DEC;
        }
            


            private void textBox_All_KeyPress(object sender, KeyPressEventArgs e)
            {
                TextBox tb = (TextBox)sender;

                if (tb.Name == textBox_DEC.Name || tb.Name == textBox_OCT.Name)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }

                if (tb.Name == textBox_HEX.Name)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar >= 'A' && e.KeyChar <= 'F'))
                    {
                        e.Handled = true;
                    }
                }

                if (tb.Name == textBox_OCT.Name)
                {
                    if (!char.IsControl(e.KeyChar) && !(e.KeyChar >= '0' && e.KeyChar <= '7'))
                    {
                        e.Handled = true;
                    }
                }

                if (tb.Name == textBox_BIN.Name)
                {
                    if (!char.IsControl(e.KeyChar) && e.KeyChar != '0' && e.KeyChar != '1')
                    {
                        e.Handled = true;
                    }
                }
            }

       
    }
    }

