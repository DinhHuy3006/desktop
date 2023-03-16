using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // click đôi vào nút chương trình sẽ tự động tạo hàm sự kiện này
        // Khi ta click chuột vào nút chương trình sẽ làm gì?
        private void BtnOk_Click(object sender, EventArgs e)
        {
            var tenDaNhap = TxtTen.Text;

            //MessageBox.Show("Xin chào bạn {tenDaNhap}. Rất vui được gặp bạn", "Thông Điệp chào mừng");
            MessageBox.Show(String.Format("xin chao{0}", tenDaNhap ));
            
            //String.Format("{0}",tenDaNhap);
        }
        // ví dụ bên trên nhập trên gì bên dưới sao chép lại
        // Hộp thoại sao chép không cho gõ, chỉ cho sao chép bên trên, cần xử lý như sau
        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = TxtTen.Text;
        }

        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = TxtTen.Text;
        }

        private void TxtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = TxtTen.Text;
        }


        // Bây giờ muốn xử lý sự kiện, trong ở tên gõ gì thì ô sao chép có nội dung y như vậy, không cần nhấn nút sao chép
        // xử lý như sau :
        // click đôi vào textbox, sự kiện TextChanged được tạo, nhưng mà bây giờ cần bắt sự kiện thay đổi ở ô nhập tên, không phải ô sao chép

    }
}
