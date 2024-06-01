using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QuocThoai_44_SoNguyenTo;
namespace SoNguyenTo_Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod] // Đánh dấu phương thức này là một phương thức kiểm tra
        public void IsPrime_InputZero_ReturnsFalse()
        {
            // Arrange
            int number = 0; // Chuẩn bị dữ liệu đầu vào

            // Act
            bool condition = SoNguyenTo.IsPrime(number); // Thực thi phương thức cần kiểm tra

            // Assert
            Assert.IsFalse(condition, "So 0 khong la so nguyen to"); // Kiểm tra biểu thức condition có là false không 
        }

        [TestMethod]
        public void IsPrime_InputOne_ReturnsFalse()
        {
            // Arrange
            int number = 1;

            // Act
            bool condition = SoNguyenTo.IsPrime(number);

            // Assert
            Assert.IsFalse(condition, "so 1 khong la so nguyen to");
        }

        [TestMethod]
        public void IsPrime_InputTwo_ReturnsTrue()
        {
            // Arrange
            int number = 2;

            // Act
            bool condition = SoNguyenTo.IsPrime(number);

            // Assert
            Assert.IsTrue(condition, "So 2 la so nguyen to");
        }

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]//tc4
        public void TestWithDataSource()
        {
            // Lấy giá trị từ cột "number" trong tệp CSV
            int number = int.Parse(TestContext.DataRow[0].ToString());
            // Lấy giá trị mong đợi từ cột "expected" trong tệp CSV
            bool expected = bool.Parse(TestContext.DataRow[1].ToString());

            // Thực hiện kiểm tra sử dụng giá trị lấy từ tệp CSV
            bool condition = SoNguyenTo.IsPrime(number); // Thay YourClass bằng tên lớp của bạn

            // Assert
            Assert.AreEqual(expected, condition);
        }
    }
}

