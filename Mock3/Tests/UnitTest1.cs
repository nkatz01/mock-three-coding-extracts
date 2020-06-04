using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
 
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestQ1()
        {

            var flour = new QuestionOne.Box(name: "flour", 4);
            Debug.Assert(flour.CostOfTheBox(grocery: true) == 4);
            var sunscreen = new QuestionOne.Box(name: "sunscreen", 3);
            Debug.Assert(sunscreen.CostOfTheBox() == 3.3);
            var tv = new QuestionOne.Box(name: "television", 500);
            Debug.Assert(tv.CostOfTheBox(taxRate: 0.06) == 530);
        }
    }
}
