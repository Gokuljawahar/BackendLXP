---
sidebar_label: GenerateOTP
---

# EmailController\.GenerateOTP\(String\) Method

**Containing Type**: [EmailController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Generating email to the repected mail they entered

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("EmailVerification")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GenerateOTP(string email)
```

### Parameters

**email** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

