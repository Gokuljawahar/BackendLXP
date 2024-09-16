---
sidebar_label: UpdatePassword
---

# RegistrationController\.UpdatePassword\(String, String, String\) Method

**Containing Type**: [RegistrationController](../index.md)

**Assembly**: LXP\.Api\.dll

```csharp
[Microsoft.AspNetCore.Mvc.HttpPut("/lxp/learner/updatePassword")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdatePassword(string learnerId, string oldPassword, string newPassword)
```

### Parameters

**learnerId** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**oldPassword** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**newPassword** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpPutAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpputattribute)

