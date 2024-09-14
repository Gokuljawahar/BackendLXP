---
sidebar_label: VerifyOTP
---

# EmailController\.VerifyOTP\(OTPVerificationViewModel\) Method

**Containing Type**: [EmailController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Validating the OTP

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("VerifyOTP")]
public Microsoft.AspNetCore.Mvc.IActionResult VerifyOTP(LXP.Common.ViewModels.OTPVerificationViewModel otpverify)
```

### Parameters

**otpverify** &ensp; [OTPVerificationViewModel](../../../../Common/ViewModels/OTPVerificationViewModel/index.md)

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

