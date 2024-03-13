using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            if(txtHoLot.Text == "")
            {
                MessageBox.Show("Họ lots không thể rỗng. Vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoLot.Focus();
            }
            lblDisplay.Text = txtHoLot.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = txtHoLot.Text + " " + txtTen.Text;
        }
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtHoLot.Text = "";
            txtTen.Clear();
            lblDisplay.Text = "";
            txtHoLot.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn thoát?", "Hỏi đáp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtHoLot_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
