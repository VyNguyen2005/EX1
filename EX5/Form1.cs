using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                return;
            }
            SINHVIEN sv = listBox1.SelectedItem as SINHVIEN;
            textBox1.Text = sv.MaSV;
            textBox2.Text = sv.HoTen;
            textBox3.Text = sv.HocBong.ToString("#,##0$");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.ReadOnly == false)
            {
                SINHVIEN sv = new SINHVIEN();
                sv.MaSV = textBox1.Text;
                sv.HoTen = textBox2.Text;
                sv.HocBong = int.Parse(textBox3.Text.Replace(",", "").Replace("$", ""));
                listBox1.Items.Add(sv);
                listBox1.SelectedIndex = listBox1.Items.IndexOf(sv);
                textBox1.ReadOnly = true;
            }
            else
            {
                SINHVIEN sv = new SINHVIEN();
                sv.HoTen = textBox2.Text;
                sv.HocBong = int.Parse(textBox3.Text.Replace(",", "").Replace("$", ""));
                listBox1.Items[listBox1.SelectedIndex] = sv;
                textBox1.ReadOnly = true;
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "HoTen";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            DialogResult tl = MessageBox.Show($"Bạn có muốn xoá thông tin sinh viên {listBox1.Text}", "Xoá thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tl == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.SelectedIndex = 0;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //KhoiTaoGiaTri();
            foreach(Control crl in Controls)
            {
                if(crl is TextBox)
                {
                    (crl as TextBox).Clear();
                }
            }
            textBox1.Focus();
            textBox1.ReadOnly = false; 
        }

        private void KhoiTaoGiaTri()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
