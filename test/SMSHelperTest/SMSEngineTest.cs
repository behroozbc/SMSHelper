using NUnit.Framework;
using SMSHelper;

namespace SMSHelperTest
{
    public class SMSHelperTests
    {
        const string _persianText= "سلام به گچپژ پارسي";
        const string _ucs = "0633064406270645002006280647002006AF0686067E06980020067E062706310633064A";

        [Test]
        public void PersianToUcs()
        {
            var strE = SmsEngine.UnicodeStr2HexStr(_persianText);

            Assert.AreEqual(_ucs,strE);
        }
        [Test]
        public void UcsToPersian()
        {
            var strE = SmsEngine.HexStr2UnicodeStr(_ucs);

            Assert.AreEqual(_persianText,strE);
        }

    }
}