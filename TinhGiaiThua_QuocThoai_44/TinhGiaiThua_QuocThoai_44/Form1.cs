using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhGiaiThua_QuocThoai_44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GiaiThua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem giá trị nhập vào có phải là một số nguyên không
            if (int.TryParse(txtnhap.Text, out int n))
            {
                try
                {
                    // Tạo một đối tượng của lớp TinhGiaiThua từ thư viện
                    TinhGiaiThua_QuocThoai_44.TinhGiaiThua calculator = new TinhGiaiThua_QuocThoai_44.TinhGiaiThua();

                    // Gọi phương thức Tinh_Giai_Thua để tính toán giai thừa
                    long result = calculator.Tinh_Giai_Thua(n);

                    // Hiển thị kết quả trong một hộp thoại thông báo
                    MessageBox.Show($"Giai thừa của {n} là {result}");
                }
                catch (ArgumentException ex)
                {
                    // Nếu có lỗi, hiển thị thông báo lỗi
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // Nếu giá trị nhập không hợp lệ, hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập một số nguyên.");
            }
        }

    }
}
