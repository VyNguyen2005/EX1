using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == false)
            {
                SINHVIEN sv = new SINHVIEN();
                sv.MaSV = textBox1.Text;
                sv.HoTen = textBox2.Text;
                sv.NgaySinh = DateTime.Parse(textBox3.Text);
                listBox1.Items.Add(sv);
                listBox1.SelectedIndex = listBox1.Items.IndexOf(sv);
                textBox1.ReadOnly = true;
            }
            else
            {
                SINHVIEN sv = new SINHVIEN();
                sv.HoTen = textBox2.Text;
                sv.NgaySinh = DateTime.Parse(textBox3.Text);
                listBox1.Items[listBox1.SelectedIndex] = sv;
                textBox1.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            DialogResult tl = MessageBox.Show($"Bạn có muốn xoá thông tin sinh viên {listBox1.Text}", "Xoá thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.SelectedIndex = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control crl in Controls)
            {
                if (crl is TextBox)
                {
                    (crl as TextBox).Clear();
                }
            }
            textBox1.Focus();
            textBox1.ReadOnly = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            SINHVIEN sv = listBox1.SelectedItem as SINHVIEN;
            textBox1.Text = sv.MaSV;
            textBox2.Text = sv.HoTen;
            textBox3.Text = sv.NgaySinh.ToString("dd/MM/yyyy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "HoTen";
        }
    }
}
