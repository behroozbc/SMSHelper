using Xunit;
using SMSHelper;

namespace SMSHelperTest
{
    public class SMSHelperTests
    {
        const string _persianText = "سلام به گچپژ پارسي";
        const string _ucs = "0633064406270645002006280647002006AF0686067E06980020067E062706310633064A";
        const string _illMeesage = "äIMEI:6465§A,DO:Ä0Ñ,DI:ÄÑ,AI:Ä293.9,293.9,0.1,0.0,0.1,0.0,0.0,1,0,0,0.0Ñ,T:21/12/21,12:00:44+14ñ";
        const string _healtyMessage = "{IMEI:6465_A,DO:[0],DI:[],AI:[293.9,293.9,0.1,0.0,0.1,0.0,0.0,1,0,0,0.0],T:21/12/21,12:00:44+14}";
        [Fact]
        public void PersianToUcs()
        {
            var strE = SmsEngine.UnicodeStr2HexStr(_persianText);

            Assert.Equal(_ucs, strE);
        }
        [Fact]
        public void UcsToPersian()
        {
            var strE = SmsEngine.HexStr2UnicodeStr(_ucs);

            Assert.Equal(_persianText, strE);
        }
        [Fact]
        public void RepleaceUnsuppottedUniCode()
        {
            var result = SmsEngine.FixUncodeNotSupport(_illMeesage);
            Assert.Equal(result, _healtyMessage);
        }

    }
}