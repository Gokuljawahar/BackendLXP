---
sidebar_label: GetAllLearnerDetailsByLearnerId
---

# LearnerController\.GetAllLearnerDetailsByLearnerId\(Guid\) Method

**Containing Type**: [LearnerController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Learner profile by learner id

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("/lxp/learner/{learnerid}/learnerdetails")]
public Microsoft.AspNetCore.Mvc.IActionResult GetAllLearnerDetailsByLearnerId(Guid learnerid)
```

### Parameters

**learnerid** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

