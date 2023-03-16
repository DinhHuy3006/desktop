using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // xử lý sự kiện khi người dùng đã chọn giới tính Nam 
            // Click đôi vào control checkbox
            // đây là sự kiện mà nếu thay đổi việc check(check hoặc bỏ check đều xẩy ra sự kiện)
            // nếu muốn kiểm tra nếu nút được check mới thông báo thì sửa sau
        }

        private void RDNam_CheckedChanged(object sender, EventArgs e)
        {
            if(RDNam.Checked)
            MessageBox.Show("Bạn chọn giới tính Nam", "Thông báo");
        }

        private void RDNu_CheckedChanged(object sender, EventArgs e)
        {
            if(RDNu.Checked)
            MessageBox.Show("Bạn chọn giới tính Nữ", "Thông báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RDDO.Checked)
                TxtHopMau.BackColor = Color.Red;
            else
                TxtHopMau.BackColor = Color.Green;
        }
    }
}
