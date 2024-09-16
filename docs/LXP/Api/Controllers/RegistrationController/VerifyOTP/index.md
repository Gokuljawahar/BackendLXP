---
sidebar_label: VerifyOTP
---

# RegistrationController\.VerifyOTP\(String, String\) Method

**Containing Type**: [RegistrationController](../index.md)

**Assembly**: LXP\.Api\.dll

  
verifying the OTP by entering the email Id

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("VerifyOTP")]
public Microsoft.AspNetCore.Mvc.IActionResult VerifyOTP(string email, string userOTP)
```

### Parameters

**email** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**userOTP** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

