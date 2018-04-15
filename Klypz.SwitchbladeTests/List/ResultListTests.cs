using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klypz.Switchblade.Basic;

namespace Klypz.Switchblade.List.Tests
{
    [TestClass()]
    public class ResultListTests
    {
        [TestMethod()]
        public void ResultListTest()
        {
            List<TestList> list = new List<TestList>();

            for (int i = 0; i < 30; i++)
            {
                list.Add(new TestList { Id = i, Nome = PasswordGenerator.NewPassword(special: false) });
            }

            ResultList<TestList> result = new ResultList<TestList>(10, 1);

            result.SetQuery(list.Where(p => p.Id % 2 == 1));
        }
    }

    public class TestList
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}