# SMSHelper

این لایبری برای این هستش که شما بتوانید به هر زبانی پیامک بزنید. 
مصرف این کتابخانه دربیشتر در اینترنت اشیا می باشد.
## نصب

Use the package manager [nuget](https://www.nuget.org/) to install [SMSHelper](https://www.nuget.org/packages/Behroozbc.SMSHelper).

```bash
dotnet add package Behroozbc.SMSHelper
```

## Usage

```csharp
using SMSHelper;

// encoding GSM message as UCS2
SmsEngine.UnicodeStr2HexStr("سلام عزیزم");

// decoding GSM UCS2 message 
SmsEngine.HexStr2UnicodeStr("0633064406270645002006280647002006AF0686067E069");
```

## همکاری کردن
من خیلی خوشحال میشم شما کمک کنید به این پکیج اگر نکته ای چیزی یا باگی پیدا کردید حتما ایشو بزارید و اگر دوست دارید قابلیتی رو اضافه کنید حتما پول ریکوست بدید 
دوستتون دارم 🤩🤩



## لایسنس
[MIT](https://github.com/behroozbc/SMSHelper/blob/master/LICENSE)
