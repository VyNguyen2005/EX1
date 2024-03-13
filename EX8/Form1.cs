using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX8
{
    public partial class Form1 : Form
    {
        List<LOPHOC> LOPHOCs;
        List<HOCVIEN> HOCVIENs;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                return;
            }
            string ml = comboBox1.SelectedValue.ToString();
            List<HOCVIEN> Dsachtheolop = new List<HOCVIEN>();
            foreach(HOCVIEN hv in HOCVIENs)
            {
                if(hv.maLH == ml)
                {
                    Dsachtheolop.Add(hv);
                }
            }
            listBox1.DisplayMember = "tenHV";
            listBox1.ValueMember = "maHV";
            listBox1.DataSource = Dsachtheolop;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            KhoiTaoComboBox();
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
                new LOPHOC{maLH = "A01", tenLH = "T1"},
                new LOPHOC{maLH = "A02", tenLH = "TK1"},
                new LOPHOC{maLH = "A03", tenLH = "OOP1"},
                new LOPHOC{maLH = "A04", tenLH = "PL1"},
                new LOPHOC{maLH = "A05", tenLH = "KT1"},
                new LOPHOC{maLH = "A06", tenLH = "TL1"},
                new LOPHOC{maLH = "A07", tenLH = "NV1"}
            };
            HOCVIENs = new List<HOCVIEN>
            {
                new HOCVIEN{maHV = "B1", tenHV = "Kim Seok Jin", gioiTinh = true, ngaySinh = new DateTime(1992, 12, 04), diaChi = "Heart Armay", maLH = "A01"},
                new HOCVIEN{maHV = "B2", tenHV = "Jimin Park", gioiTinh = false, ngaySinh = new DateTime(1995, 10, 13), diaChi = "Busan", maLH = "A02"},
                new HOCVIEN{maHV = "B3", tenHV = "Kim Taehyung", gioiTinh = false, ngaySinh = new DateTime(1995, 12, 30), diaChi = "Busan", maLH = "A03"},
                new HOCVIEN{maHV = "B4", tenHV = "Lee Min Hoo", gioiTinh = false, ngaySinh = new DateTime(2000, 12, 12), diaChi = "Seoul", maLH = "A04"},
                new HOCVIEN{maHV = "B5", tenHV = "Karina", gioiTinh = true, ngaySinh = new DateTime(2000, 12, 20), diaChi = "Ilsan", maLH = "A05"},
                new HOCVIEN{maHV = "B6", tenHV = "Heuning Kai", gioiTinh = false, ngaySinh = new DateTime(2004, 12, 3), diaChi = "UK", maLH = "A06"},
                new HOCVIEN{maHV = "B7", tenHV = "JeonJun", gioiTinh = false, ngaySinh = new DateTime(2003, 04, 12), diaChi = "BeThuNam", maLH = "A07"},
                new HOCVIEN{maHV = "B8", tenHV = "Harry Lu", gioiTinh = false, ngaySinh = new DateTime(2000, 03, 04), diaChi = "Hong Kong", maLH = "A03"},
            };
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                return;
            }
            HOCVIEN hv = (listBox1.SelectedItem as HOCVIEN);
            textBox1.Text = hv.maHV;
            textBox2.Text = hv.tenHV;
            textBox3.Text = hv.gioiTinh == true ? "Nữ" : "Nam";
            textBox4.Text = hv.ngaySinh.ToShortDateString();
            textBox5.Text = hv.diaChi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            foreach (Control control in this.groupBox1.Controls)
            {
                if(control is TextBox)
                {
                    (control as TextBox).Clear();
                }
            }
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOCVIEN hv;
            if (!textBox1.ReadOnly)
            {
                hv = new HOCVIEN();
                hv.maHV = textBox1.Text;
                hv.tenHV = textBox2.Text;
                hv.gioiTinh = textBox3.Text == "Nam" ? false : true;
                hv.ngaySinh = DateTime.Parse(textBox4.Text);
                hv.diaChi = textBox5.Text;
                hv.maLH = comboBox1.SelectedValue.ToString();
                HOCVIENs.Add(hv);
            }
            else
            {
                hv = listBox1.SelectedItem as HOCVIEN;
                hv.tenHV = textBox2.Text;
                hv.gioiTinh = textBox3.Text == "Nam" ? false : true;
                hv.ngaySinh = DateTime.Parse(textBox4.Text);
                hv.diaChi = textBox5.Text;
            }
            comboBox1_SelectedIndexChanged(sender, e);
            listBox1.SelectedIndex = listBox1.Items.IndexOf(hv);
            textBox1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show($"Bạn có muốn xoá thông tin học viên {textBox2.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tl == DialogResult.Yes)
            {
                HOCVIENs.Remove(listBox1.SelectedItem as HOCVIEN);
                comboBox1_SelectedIndexChanged(sender, e);
                listBox1.SelectedItem = 0;
            }
        }
    }
}
