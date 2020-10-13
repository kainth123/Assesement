using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;
using Assesement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        hvclass testClass = new hvclass();

        public int Bullet { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            var actual = testClass.Spin();
            Assert.IsTrue(actual <= 5);
        }



        [TestMethod]
        public void TestMethod2()

        {
            var actual = testClass.WeaponLoad();
            Assert.IsTrue(actual <= 1);

        }
    }
}






