using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PTB1_Cuong_07;
namespace PTB1_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]// TC1 
        public void PhuongTrinhCoNghiem()
        {
            // thiet lap tc a=2,b=4
            int a = 2;
            int b = 4;
            int expected = -2;// ket qua mong doi -2

            // Act
            int result = PTB1.Solve(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod] // tc2
        [ExpectedException(typeof(System.ArgumentException))] // Xác định rằng phương thức này mong đợi ném một ngoại lệ của kiểu System.ArgumentException.
        public void PTVSN()
        {
            // thiet lap tc a=0,b=0
            int a = 0; // Thiết lập hệ số a của phương trình thành 0.
            int b = 0; // Thiết lập hệ số b của phương trình thành 0.

            // Gọi phương thức Solve của lớp PTB1_Cuong_07 và chuyển các giá trị a và b vào để giải phương trình.
            PTB1.Solve(a, b);
        }
        [TestMethod]// TC3
        [ExpectedException(typeof(System.ArgumentException))]// Xác định rằng phương thức này mong đợi ném một ngoại lệ của kiểu System.Argum
        public void PTVN()
        {
            // thiet lap tc a=0,b=5
            int a = 0;// Thiết lập hệ số a của phương trình thành 0.
            int b = 5;// Thiết lập hệ số b của phương trình thành 0.

            // Gọi phương thức Solve của lớp PTB1_Cuong_07 và chuyển các giá trị a và b vào để giải phương trình.
            PTB1.Solve(a, b);
        }

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",@".\Data\TestData.csv","TestData#csv",DataAccessMethod.Sequential)]
        [TestMethod]//tc4
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());

            int result = PTB1.Solve(a, b);

            Assert.AreEqual(expected, result);
        }

        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData1.csv", "TestData1#csv", DataAccessMethod.Sequential)]
        [TestMethod]//tc5
        public void TestWithDataSource1()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());

            int result = PTB1.Solve(a, b);

            Assert.AreEqual(expected, result);
        }

    }
}
