---
sidebar_label: GetLearnerProfileById
---

# RegistrationController\.GetLearnerProfileById\(String\) Method

**Containing Type**: [RegistrationController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Fetching particular Learner profile details using Id

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("/lxp/view/learnerProfile/{id}")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetLearnerProfileById(string id)
```

### Parameters

**id** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

