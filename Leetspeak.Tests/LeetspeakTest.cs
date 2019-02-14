using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTest
  {
    [TestMethod]
    public void IsLeetspeak_eTranslate3()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator();
      Assert.AreEqual("3E3", testLeetspeakTranslator.Translate("eEe"));
    }
    [TestMethod]
    public void IsLeetspeak_oTranslate0()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator();
      Assert.AreEqual("0O0", testLeetspeakTranslator.Translate("oOo"));
    }
    [TestMethod]
    public void IsLeetspeak_ITranslate1()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator();
      Assert.AreEqual("i1i", testLeetspeakTranslator.Translate("iIi"));
    }
    [TestMethod]
    public void IsLeetspeak_tTranslatey()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator();
      Assert.AreEqual("7T7", testLeetspeakTranslator.Translate("tTt"));
    }
    [TestMethod]
    public void IsLeetspeak_sTranslatez()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator();
      Assert.AreEqual("s7ringS3z", testLeetspeakTranslator.Translate("stringSes"));
    }
  }
}
