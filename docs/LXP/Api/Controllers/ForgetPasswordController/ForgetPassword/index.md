---
sidebar_label: ForgetPassword
---

# ForgetPasswordController\.ForgetPassword\(RandomPasswordEmail\) Method

**Containing Type**: [ForgetPasswordController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Forget Password with Random passwordgenerator that sends to user Email

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult> ForgetPassword(LXP.Common.ViewModels.RandomPasswordEmail randompassword)
```

### Parameters

**randompassword** &ensp; [RandomPasswordEmail](../../../../Common/ViewModels/RandomPasswordEmail/index.md)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[ActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.actionresult)&gt;

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

