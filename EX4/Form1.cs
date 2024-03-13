using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Noi dung khong the rong. Vui long nhap lai", "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Khoi_Tao_Gia_Tri();
                return;
            }
            if(int.TryParse(textBox1.Text, out int result) == false)
            {
                MessageBox.Show("Noi dung khong the rong. Vui long nhap lai", "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Khoi_Tao_Gia_Tri();
                return;
            }
            listBox1.Items.Add(textBox1.Text);
            Khoi_Tao_Gia_Tri();
        }
        private void Khoi_Tao_Gia_Tri()
        {
            textBox1.Clear();
            textBox1.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void form1_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
           listBox1.Items.Add(4);
           listBox1.Items.Add(5);
           listBox1.Items.Add(6);
           listBox1.Items.Add(7);
           listBox1.Items.Add(8);
        }
    }
}
