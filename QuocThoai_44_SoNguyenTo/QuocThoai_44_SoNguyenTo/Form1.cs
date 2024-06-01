using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuocThoai_44_SoNguyenTo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Lấy số nhập từ người dùng từ textbox
            int number;
            if (!int.TryParse(txta.Text, out number))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên.");
                return;
            }

            // Kiểm tra xem số đó có phải là số nguyên tố hay không
            bool isPrime = SoNguyenTo.IsPrime(number);

            // Hiển thị kết quả
            if (isPrime)
                MessageBox.Show($"{number} là số nguyên tố.");
            else
                MessageBox.Show($"{number} không phải là số nguyên tố.");
        }
    
    }
}
