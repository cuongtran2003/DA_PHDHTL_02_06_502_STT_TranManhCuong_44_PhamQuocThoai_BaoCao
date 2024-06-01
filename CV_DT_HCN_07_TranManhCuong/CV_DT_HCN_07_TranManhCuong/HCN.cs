using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_DT_HCN_07_TranManhCuong
{
    public class HCN
    {
        // Thuộc tính chiều dài và chiều rộng
        private int chieuDai;
        private int chieuRong;

        // Constructor
        public HCN(int chieuDai, int chieuRong)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }

        // Phương thức tính chu vi
        public int TinhChuVi()
        {
            return 2 * (chieuDai + chieuRong);
        }

        // Phương thức tính diện tích
        public int TinhDienTich()
        {
            return chieuDai * chieuRong;
        }
    }

}
