using EvaluationSampleCode;

namespace EvaluationUnitTest
{
    [TestClass]
    public class HtmlFormatHelperTest
    {
        [TestMethod]
        public void GetBoldFormat_WhenCalled_ReturnsBoldFormattedString()
        {
            HtmlFormatHelper htmlFormatHelper = new HtmlFormatHelper();
            string result = htmlFormatHelper.GetBoldFormat("Hello, world!");
            Assert.AreEqual("<b>Hello, world!</b>", result);

        }

        [TestMethod]
        public void GetBoldFormat_WhenCalled_ReturnsItalicFormattedString()
        {
            HtmlFormatHelper htmlFormatHelper = new HtmlFormatHelper();
            string result = htmlFormatHelper.GetBoldFormat("Hello, world!");
            Assert.AreNotEqual("<i>Hello, world!</i>", result);

        }

        [TestMethod]
        public void GetItalicFormat_WhenCalled_ReturnsItalicFormattedString()
        {
            HtmlFormatHelper htmlFormatHelper = new HtmlFormatHelper();
            string result = htmlFormatHelper.GetItalicFormat("Hello, world!");
            Assert.AreEqual("<i>Hello, world!</i>", result);

        }
    }
}