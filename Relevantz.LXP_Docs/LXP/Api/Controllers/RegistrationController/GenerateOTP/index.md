---
sidebar_label: GenerateOTP
---

# RegistrationController\.GenerateOTP\(String\) Method

**Containing Type**: [RegistrationController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Generating email to the repected mail they entered

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("EmailVerification")]
public Microsoft.AspNetCore.Mvc.IActionResult GenerateOTP(string email)
```

### Parameters

**email** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

