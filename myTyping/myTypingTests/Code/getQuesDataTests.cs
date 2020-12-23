using Microsoft.VisualStudio.TestTools.UnitTesting;
using myTyping.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTyping.Code.Tests
{
    [TestClass()]
    public class getQuesDataTests
    {
        [TestMethod()]
        public void getTextsTest()
        {
            var ret=getQuesData.getTexts();
            Console.WriteLine(ret);
        }
    }
}