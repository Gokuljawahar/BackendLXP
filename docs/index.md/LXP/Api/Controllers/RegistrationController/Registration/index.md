---
sidebar_label: Registration
---

# RegistrationController\.Registration\(RegisterUserViewModel\) Method

**Containing Type**: [RegistrationController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Post the learner and profile details

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("/lxp/learner/registration")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> Registration(LXP.Common.ViewModels.RegisterUserViewModel learner)
```

### Parameters

**learner** &ensp; [RegisterUserViewModel](../../../../Common/ViewModels/RegisterUserViewModel/index.md)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

