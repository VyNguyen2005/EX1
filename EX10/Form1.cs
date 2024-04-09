using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX10
{
    public partial class Form1 : Form
    {
        List<LOPHOC> LOPHOCs;
        List<HOCVIEN> HOCVIENs;

        public Form1()
        {
            InitializeComponent();
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
                new LOPHOC{maLH = "A01", tenLH = "T1", hocPhi = 1000000},
                new LOPHOC{maLH = "A02", tenLH = "TK1", hocPhi = 2000000},
                new LOPHOC{maLH = "A03", tenLH = "OOP1", hocPhi = 3000000},
                new LOPHOC{maLH = "A04", tenLH = "PL1", hocPhi = 4000000},
                new LOPHOC{maLH = "A05", tenLH = "KT1", hocPhi = 5000000},
                new LOPHOC{maLH = "A06", tenLH = "TL1", hocPhi = 6000000},
                new LOPHOC{maLH = "A07", tenLH = "NV1", hocPhi = 7000000}
            };
            HOCVIENs = new List<HOCVIEN>
            {
                new HOCVIEN{maHV = "B1", tenHV = "Kim Seok Jin", laSV = false, maLH = "A01", thanhTien = 0},
                new HOCVIEN{maHV = "B2", tenHV = "Jimin Park", laSV = true, maLH = "A02", thanhTien = 0},
                new HOCVIEN{maHV = "B3", tenHV = "Kim Taehyung", laSV = false, maLH = "A03", thanhTien = 0},
                new HOCVIEN{maHV = "B4", tenHV = "Lee Min Hoo", laSV = true, maLH = "A04", thanhTien = 0},
                new HOCVIEN{maHV = "B5", tenHV = "Karina",laSV = false, maLH = "A05", thanhTien = 0},
                new HOCVIEN{maHV = "B6", tenHV = "Heuning Kai", laSV = true, maLH = "A06", thanhTien = 0},
                new HOCVIEN{maHV = "B7", tenHV = "JeonJun",laSV = false, maLH = "A07", thanhTien = 0},
                new HOCVIEN{maHV = "B8", tenHV = "Harry Lu",laSV = true, maLH = "A03", thanhTien = 0},

                //new HOCVIEN{maHV = "B1", tenHV = "Kim Seok Jin", laSV = false, maLH = "A01", thanhTien = 1000000},
                //new HOCVIEN{maHV = "B2", tenHV = "Jimin Park", laSV = true, maLH = "A02", thanhTien = 1800000},
                //new HOCVIEN{maHV = "B3", tenHV = "Kim Taehyung", laSV = false, maLH = "A03", thanhTien = 3000000},
                //new HOCVIEN{maHV = "B4", tenHV = "Lee Min Hoo", laSV = true, maLH = "A04", thanhTien = 3600000},
                //new HOCVIEN{maHV = "B5", tenHV = "Karina",laSV = false, maLH = "A05", thanhTien = 5000000},
                //new HOCVIEN{maHV = "B6", tenHV = "Heuning Kai", laSV = true, maLH = "A06", thanhTien = 5400000},
                //new HOCVIEN{maHV = "B7", tenHV = "JeonJun",laSV = false, maLH = "A07", thanhTien = 7000000},
                //new HOCVIEN{maHV = "B8", tenHV = "Harry Lu",laSV = true, maLH = "A03", thanhTien = 2700000},
            };
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
            checkBox1.Checked = hv.laSV;
            comboBox1.SelectedValue = hv.maLH;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LOPHOC lh = comboBox1.SelectedItem as LOPHOC;
            double TT = lh.hocPhi * (checkBox1.Checked == true ? 0.9 : 1);
            label7.Text = TT.ToString("#,##0$");
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
            checkBox1.Checked = true;
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOCVIEN hv;
            if (!textBox1.ReadOnly)
            {
                hv = new HOCVIEN();
                hv.maHV = textBox1.Text;
                hv.tenHV = textBox2.Text;
                hv.laSV = checkBox1.Checked;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                return;
            }
            LOPHOC lh = comboBox1.SelectedItem as LOPHOC;
            double TT = lh.hocPhi * (checkBox1.Checked == true ? 0.9 : 1);
            label7.Text = TT.ToString("#,##0$");
        }
    }
}
