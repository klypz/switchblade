using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Extensions.Tests
{
    public enum E
    {
        [EnumDescription("Enum numero 1")]
        Enum1 = 1,
        [EnumDescription("Enum numero 2")]
        Enum2 = 2,
        Enum3 = 3
    }

    [TestClass()]
    public class EnumExtensionTests
    {
        [TestMethod()]
        public void TryParseValueTest()
        {

            if (EnumExtension.TryParseValue(2, out E? result))
            {
                string desc = EnumExtension.GetDescription(result.Value);
            }
            string desc3 = EnumExtension.GetDescription(E.Enum3) ?? "";

            Assert.Fail();
        }
    }
}