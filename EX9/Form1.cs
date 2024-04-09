using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX9
{
    public partial class Form1 : Form
    {
        List<HOCVIEN> HOCVIENs;
        List<LOPHOC> LOPHOCs;
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                return;
            }
            LOPHOC lh = comboBox1.SelectedItem as LOPHOC;
            label7.Text = lh.thanhTien.ToString("#,##0$");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            KhoiTaoComboBox();
            KhoiTaoListBox();
        }

        private void KhoiTaoListBox()
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "tenHV";
            listBox1.ValueMember = "maHV";
            listBox1.DataSource = HOCVIENs;
        }

        private void KhoiTaoComboBox()
        {
            comboBox1.DisplayMember = "tenLH";
            comboBox1.ValueMember = "maLH";
            comboBox1.DataSource = LOPHOCs;
        }

        private void KhoiTaoDuLieu()
        {
            LOPHOCs = new List<LOPHOC>
            {
                new LOPHOC{maLH = "A01", tenLH = "T1", thanhTien = 1000000},
                new LOPHOC{maLH = "A02", tenLH = "TK1", thanhTien = 2000000},
                new LOPHOC{maLH = "A03", tenLH = "OOP1", thanhTien = 3000000},
                new LOPHOC{maLH = "A04", tenLH = "PL1", thanhTien = 4000000},
                new LOPHOC{maLH = "A05", tenLH = "KT1", thanhTien = 5000000},
                new LOPHOC{maLH = "A06", tenLH = "TL1", thanhTien = 6000000},
                new LOPHOC{maLH = "A07", tenLH = "NV1", thanhTien = 7000000}
            };
            HOCVIENs = new List<HOCVIEN>
            {
                new HOCVIEN{maHV = "B1", tenHV = "Kim Seok Jin", maLH = "A01"},
                new HOCVIEN{maHV = "B2", tenHV = "Jimin Park", maLH = "A02"},
                new HOCVIEN{maHV = "B3", tenHV = "Kim Taehyung", maLH = "A03"},
                new HOCVIEN{maHV = "B4", tenHV = "Lee Min Hoo", maLH = "A04"},
                new HOCVIEN{maHV = "B5", tenHV = "Karina", maLH = "A05"},
                new HOCVIEN{maHV = "B6", tenHV = "Heuning Kai", maLH = "A06"},
                new HOCVIEN{maHV = "B7", tenHV = "JeonJun", maLH = "A07"},
                new HOCVIEN{maHV = "B8", tenHV = "Harry Lu", maLH = "A03"},
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                return;
            }
            HOCVIEN hv = listBox1.SelectedItem as HOCVIEN;
            textBox1.Text = hv.maHV;
            textBox2.Text = hv.tenHV;
            comboBox1.SelectedValue = hv.maLH;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show($"Bạn có muốn xoá thông tin học viên {textBox2.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                HOCVIENs.Remove(listBox1.SelectedItem as HOCVIEN);
                listBox1.SelectedIndex = 0;
                KhoiTaoListBox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if(control is TextBox)
                {
                    (control as TextBox).Clear();
                }
            }
            textBox1.Focus();
            textBox1.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOCVIEN hv;
            if (!textBox1.ReadOnly)
            {
                hv = new HOCVIEN();
                hv.maHV = textBox1.Text;
                hv.tenHV = textBox2.Text;
                hv.maLH = comboBox1.SelectedValue.ToString();
                HOCVIENs.Add(hv);
                KhoiTaoListBox();
                listBox1.SelectedIndex = listBox1.Items.IndexOf(hv);
            }
            else
            {
                hv = listBox1.SelectedItem as HOCVIEN;
                hv.tenHV = textBox2.Text;
                hv.maLH = comboBox1.SelectedValue.ToString();
                KhoiTaoListBox();
                listBox1.SelectedIndex = listBox1.Items.IndexOf(hv); 
            }
            textBox1.ReadOnly = true;
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
