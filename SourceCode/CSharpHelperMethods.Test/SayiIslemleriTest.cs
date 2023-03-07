using CSharpHelperMethods.Library;
using NUnit.Framework;

namespace CSharpHelperMethods.Test
{
    [TestFixture]
    public class SayiIslemleriTest
    {
        [Test]
        [TestCase("15", ExpectedResult = true)]
        [TestCase("15123132", ExpectedResult = true)]
        [TestCase("3242a", ExpectedResult = false)]
        [TestCase("asdada", ExpectedResult = false)]
        public bool SayisalMiTest(string metin)
        {
            return SayiIslemleri.SayisalMi(metin);
        }
        
        
    }
}