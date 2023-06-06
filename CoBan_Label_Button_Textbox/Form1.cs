using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoBan_Label_Button_Textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn mở máy tính bỏ túi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Dispose();
            }
        }

        private void txtA_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.DarkSeaGreen;
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void btnCong_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.DarkSeaGreen;
        }

        private void btnCong_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.White;
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }    
                
            if (e.KeyChar == 13 && txtA.Text != "" && txtB.Text != "") // ENTER
            {
                btnCong.Enabled = true;
                btnTru.Enabled = true;
                btnNhan.Enabled = true;
                btnChia.Enabled = true;
                btnDel.Enabled = true;

                txtKetQua.Enabled = true;
            }
            if (txtA.Text.Trim() == "" && e.KeyChar == 13)
            {
                txtA.Focus();
                return;
            }
            if (txtB.Text.Trim() == "" && e.KeyChar == 13)
            {
                txtB.Focus();
                return;
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (double.Parse(txtA.Text) + double.Parse(txtB.Text)).ToString();
            
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (double.Parse(txtA.Text) - double.Parse(txtB.Text)).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (double.Parse(txtA.Text) * double.Parse(txtB.Text)).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtB.Text) == 0)
            {
                txtKetQua.Text = "Lỗi. Chia cho 0";
                return;
            }
            txtKetQua.Text = (double.Parse(txtA.Text) / double.Parse(txtB.Text)).ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            btnCong.Enabled = false;
            btnTru.Enabled = false;
            btnNhan.Enabled = false;
            btnChia.Enabled = false;
            btnDel.Enabled = false;

            txtKetQua.Enabled = false;

            txtA.Text = "";
            txtB.Text = "";
            txtKetQua.Text = "";

            txtA.Focus();
        }
    }
}
