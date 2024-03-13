using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Noi dung khong the rong. Vui long nhap lai", "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Gà Rán");
            listBox1.Items.Add("Cơm Gà Xối Mỡ");
            listBox1.Items.Add("Bánh Đa Cua");
            listBox1.Items.Add("Bánh Xèo");
            listBox1.Items.Add("Kim Chi Củ Cải");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            for(int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
            }
            while(listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);
            }
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox2.SelectedItems[0]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i]);
            }
            listBox2.Items.Clear();
        }
    }
}
