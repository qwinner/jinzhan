using JinZhan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestJinZhan
{
    
    
    /// <summary>
    ///这是 ExportDataTest 的测试类，旨在
    ///包含所有 ExportDataTest 单元测试
    ///</summary>
    [TestClass()]
    public class ExportDataTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///ParsingChangDi 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("JinZhan.exe")]
        public void ParsingChangDiTest()
        {
            ExportData_Accessor target = new ExportData_Accessor(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            actual = target.ParsingChangDi("1,2,3,");
            Assert.AreEqual("生产,存储,住宿,", actual);
            Assert.AreEqual("生产,存储,", target.ParsingChangDi("1,2,"));
            Assert.AreEqual("生产,", target.ParsingChangDi("1,"));
            Assert.AreEqual("生产,存储,住宿,居住,办公,", target.ParsingChangDi("1,2,3,4,5,"));
            Assert.AreEqual("生产,存储,住宿,居住,", target.ParsingChangDi("1,2,3,4,"));
            Assert.AreNotEqual("生产,存储,住宿,居住,", target.ParsingChangDi("1fsfsafs,"));
        }
    }
}
