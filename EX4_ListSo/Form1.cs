using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX4_ListSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Noi dung khong the rong. Vui long nhap lai", "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Khoi_Tao_Gia_Tri();
                return;
            }
            if (int.TryParse(textBox1.Text, out int result) == false)
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

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(4);
            listBox1.Items.Add(5);
            listBox1.Items.Add(6);
            listBox1.Items.Add(7);
            listBox1.Items.Add(8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;
            for(int i = 0; i<listBox1.Items.Count; i++)
            {
                int x = Convert.ToInt32(listBox1.Items[i]);
                s += x;
            }
            MessageBox.Show($"Tổng các số: {s}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn phần tử xoá. Vui lòng chọn", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
        // Tăng PT lên 2
        private void button7_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("ListBox chưa có giá trị", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = Convert.ToInt32(listBox1.Items[i]);
                listBox1.Items[i] = x + 2;
            }
            
        }
        // Chọn phần tử chẵn
        private void button6_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = Convert.ToInt32(listBox1.Items[i]);
                if (x % 2 == 0)
                {
                    listBox1.SelectedIndex = i;
                }
            }
        }
        // Thay bang binh phuong
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("ListBox chưa có giá trị", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = Convert.ToInt32(listBox1.Items[i]);
                listBox1.Items[i] = x * x;
            }
        }
    }
}
