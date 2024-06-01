using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TinhGiaiThua_QuocThoai_44; // Import lớp TinhGiaiThua từ namespace

namespace GiaiThua_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GiaiThuaCua0()
        {
            int excepted = 1;
            // Arrange
            TinhGiaiThua calculator = new TinhGiaiThua(); // Tạo một đối tượng của lớp TinhGiaiThua

            // Act
            long result = calculator.Tinh_Giai_Thua(0); // Tính giai thừa của 0

            // Assert
            Assert.AreEqual(excepted, result); // Kiểm tra xem kết quả có phải là 1 hay không
        }

        [TestMethod]
        public void GiaiThua()
        {
            int excepted = 120;
            // Arrange
            TinhGiaiThua calculator = new TinhGiaiThua(); // Tạo một đối tượng của lớp TinhGiaiThua

            // Act
            long result = calculator.Tinh_Giai_Thua(5); // Tính giai thừa của 5

            // Assert
            Assert.AreEqual(excepted, result); // Kiểm tra xem kết quả có phải là 120 hay không
        }
        
        
        [ExpectedException(typeof(System.ArgumentException))]// ngoại lệ sẽ xuất hiện khi một tham số truyền vào phương thức là 1 số âm
        [TestMethod]
        public void KiemTraGiaiThuaCuaSoAm()
        {
            int excepted = -1;
            // Sắp xếp
            TinhGiaiThua tinhToan = new TinhGiaiThua(); // Tạo một đối tượng của lớp TinhGiaiThua

            // Kiểm tra
            tinhToan.Tinh_Giai_Thua(excepted); // Kiểm tra xem việc nhập số âm có ném ngoại lệ không
        }
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            // Lấy giá trị của cột 'a' từ tệp CSV
            int a = int.Parse(TestContext.DataRow[0].ToString());

            // Lấy giá trị mong đợi từ cột 'expected' từ tệp CSV
            int expected= int.Parse(TestContext.DataRow[1].ToString());
            TinhGiaiThua calculator = new TinhGiaiThua(); // Tạo một đối tượng của lớp TinhGiaiThua

            long result = calculator.Tinh_Giai_Thua(a);
            // Thực hiện kiểm thử dựa trên dữ liệu từ tệp CSV
            Assert.AreEqual(expected, result);
        }
    }
}
