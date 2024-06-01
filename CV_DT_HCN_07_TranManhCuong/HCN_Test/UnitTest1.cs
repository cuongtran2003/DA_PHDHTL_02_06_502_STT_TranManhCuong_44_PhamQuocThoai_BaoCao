using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CV_DT_HCN_07_TranManhCuong;
namespace ChuViDienTichHCN_Test
{
    [TestClass]
    public class ChuViDienTichTest
    {

        [TestMethod]// TC1 chieudai=5, chieuRong=3,
        public void TestTinhChuVi()
        {
            // Arrange
            int chieuDai = 5;
            int chieuRong = 3;
            int expected = 16; // 2*(5+3) = 16, kq=16

            // Act
            HCN hcn = new HCN(chieuDai, chieuRong);
            int actual = hcn.TinhChuVi();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]// TC2 chieudai=5, chieuRong=3,
        public void TestTinhDienTich()
        {
            // Arrange
            int chieuDai = 5;
            int chieuRong = 3;
            int expected = 15; // 5*3 = 15,kq=15

            // Act
            HCN hcn = new HCN(chieuDai, chieuRong);
            int actual = hcn.TinhDienTich();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // test file csv
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataChuVi.csv", "TestDataChuVi#csv", DataAccessMethod.Sequential)]
        [TestMethod]// tc3 test file csv chu vi hcn
        public void TestWithDataSourceChuVi()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            HCN hcn = new HCN(a, b);
            int actual = hcn.TinhChuVi();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data1\TestDataDienTich.csv", "TestDataDienTich#csv", DataAccessMethod.Sequential)]
        [TestMethod]// tc3 test file csv chu vi hcn
        public void TestWithDataSourceDienTich()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            HCN hcn = new HCN(a, b);
            int actual = hcn.TinhDienTich();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
