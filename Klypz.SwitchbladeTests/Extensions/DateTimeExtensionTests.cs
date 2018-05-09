using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Extensions.Tests
{
    [TestClass()]
    public class DateTimeExtensionTests
    {
        [TestMethod()]
        public void ToUnixTimeTest()
        {
            DateTime dateTime = new DateTime(2015, 1, 1);
            string a = dateTime.ToUnixTime() + " - " + dateTime.ToUniversalTime();
        }

        [TestMethod()]
        public void FromUnixTimeTest()
        {
            DateTime dt = DateTimeExtension.FromUnixTime((long)1420070400000);
        }
    }
}