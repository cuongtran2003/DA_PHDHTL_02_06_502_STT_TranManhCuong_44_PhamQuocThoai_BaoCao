using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_DT_HCN_07_TranManhCuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            int kq;
            // Lấy giá trị chiều dài và chiều rộng từ TextBox
            int chieuDai = Convert.ToInt32(txta.Text);
            int chieuRong = Convert.ToInt32(txtb.Text);

            // Tạo một đối tượng ChuViDienTich và tính chu vi
            HCN hcn = new HCN(chieuDai, chieuRong);
            int chuVi = hcn.TinhChuVi();

            // Hiển thị kết quả
            txtkq.Text = chuVi.ToString();
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            int kq;
            // Lấy giá trị chiều dài và chiều rộng từ TextBox
            int chieuDai = Convert.ToInt32(txta.Text);
            int chieuRong = Convert.ToInt32(txtb.Text);

            // Tạo một đối tượng ChuViDienTich và tính chu vi
            HCN hcn = new HCN(chieuDai, chieuRong);
            int dientich = hcn.TinhDienTich();

            // Hiển thị kết quả
            txtkq.Text = dientich.ToString();
        }
    }
}
