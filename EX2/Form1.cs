using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int hsA, hsB;
            string value;
            if(int.TryParse(txtHsa.Text, out hsA) == false)
            {
                MessageBox.Show("Hệ số a không phù hợp. Vui lòng nhập lại", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHsa.Clear();
                txtHsa.Focus();
                return;
            }
            if (int.TryParse(txtHsb.Text, out hsB) == false)
            {
                MessageBox.Show("Hệ số b không phù hợp. Vui lòng nhập lại", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHsb.Clear();
                txtHsb.Focus();
                return;
            }
            if(hsA == 0)
            {
                if(hsB == 0)
                {
                    value = "Phương trình vô số nghiệm";
                }
                else
                {
                    value = "Phương trình vô nghiệm";
                }
            }
            else
            {
                value = $"Phương trình có nghiệm x = {-(float)hsB / hsA}";                                                     
            }
            txtKq.Text = value;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHsa.Text = "";
            txtHsb.Text = "";
            txtKq.Text = "";
            txtHsa.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn thoát?", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if(tl == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
