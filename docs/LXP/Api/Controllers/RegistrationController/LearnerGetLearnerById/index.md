---
sidebar_label: LearnerGetLearnerById
---

# RegistrationController\.LearnerGetLearnerById\(String\) Method

**Containing Type**: [RegistrationController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Fetching particular Learner details and Profile details using Learner Id

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("/lxp/view/getlearner/{id}")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> LearnerGetLearnerById(string id)
```

### Parameters

**id** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

