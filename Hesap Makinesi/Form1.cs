using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{

    
    public partial class Form1 : Form
    {
        
        int oprtn=0;//operation
        double n1=0,n2=0;//numbers
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
        }
      
        public double cal()//calculate
        {
            double result=0;

            if (oprtn == 1)
            {
                result = n1 + n2;
            }
            else if (oprtn == 2)
            {
                result = n1 - n2;
            }
            else if (oprtn == 3)
            {
                result = n1 * n2;
            }
            else if (oprtn == 4)
            {
                result = n1 / n2;
            }
            else if (oprtn == 5)
            {
                result = n1 % n2;
            }
            else if (oprtn == 6)
            {
                result = Math.Sqrt(n1);
            }
            else if (oprtn == 7)
            {
                result =Math.Pow(n1,2);
            }
            else if (oprtn == 8)
            {
                result = 1/n1;
            }
            return result;
        }
  //*****************sayılar************    
        private void btn_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                textBox1.Text += "0";
            }
            else
                textBox1.Text = textBox1.Text + btn_0.Text;
        }
        private void btn_1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                textBox1.Text += "1";
            }
            else
                textBox1.Text = textBox1.Text + btn_1.Text;
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                textBox1.Text += "2";
            }
            else 
                textBox1.Text = textBox1.Text + btn_2.Text;
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text += "3";
            }
            else
                textBox1.Text = textBox1.Text + btn_3.Text;
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text += "4";
            }
            else
                textBox1.Text = textBox1.Text + btn_4.Text;
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text += "5";
            }
            else
                textBox1.Text = textBox1.Text + btn_5.Text;
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text += "6";
            }
            else
                textBox1.Text = textBox1.Text + btn_6.Text;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text += "7";
            }
            else
                textBox1.Text = textBox1.Text + btn_7.Text;
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text += "8";
            }
            else
                textBox1.Text = textBox1.Text + btn_8.Text;
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text += "9";
            }
            else
                textBox1.Text = textBox1.Text + btn_9.Text;
        }
//**************işlemler*************
        
        private void button4_Click(object sender, EventArgs e)//Toplama
        {
            oprtn = 1;
            n1 = Convert.ToDouble(textBox1.Text);
            clear_tb();
        }
        private void btn_extrac_Click(object sender, EventArgs e)
        {
            oprtn = 2;
            n1 = Convert.ToDouble(textBox1.Text);
            clear_tb();
        }
        private void btn_multipul_Click(object sender, EventArgs e)
        {
            oprtn = 3;
            n1 = Convert.ToDouble(textBox1.Text);
            clear_tb();
        }
        private void btn_division_Click(object sender, EventArgs e)
        {
            oprtn = 4;
            n1 = Convert.ToDouble(textBox1.Text);
            clear_tb();
        }
        private void btn_mod_Click(object sender, EventArgs e)
        {
            oprtn = 5;
            n1 = Convert.ToDouble(textBox1.Text);
            clear_tb();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            oprtn = 6;
            n1 = Convert.ToDouble(textBox1.Text);
        }
        private void btn_pow_Click(object sender, EventArgs e)
        {
            oprtn = 7;
            n1 = Convert.ToDouble(textBox1.Text);
        }
        private void btn_com_Click(object sender, EventArgs e)
        {
            oprtn = 8;
            n1 = Convert.ToDouble(textBox1.Text);
        }
        private void btn_equal_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=" ")
            n2=Double.Parse(textBox1.Text);

            textBox1.Text = cal().ToString();

        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            textBox1.Text="";
        }
        public void clear_tb()
        {
            textBox1.Text = "";
        }
    }
}
