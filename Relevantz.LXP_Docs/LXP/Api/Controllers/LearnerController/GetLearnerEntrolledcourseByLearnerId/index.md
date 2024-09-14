---
sidebar_label: GetLearnerEntrolledcourseByLearnerId
---

# LearnerController\.GetLearnerEntrolledcourseByLearnerId\(Guid\) Method

**Containing Type**: [LearnerController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Enrolled course details by learner id

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("/lxp/learner/{learnerid}/entrolledcourse")]
public Microsoft.AspNetCore.Mvc.IActionResult GetLearnerEntrolledcourseByLearnerId(Guid learnerid)
```

### Parameters

**learnerid** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

