---
sidebar_label: GetCourseandTopicsByCourseId
---

# EnrollmentController\.GetCourseandTopicsByCourseId\(Guid, Guid\) Method

**Containing Type**: [EnrollmentController](../index.md)

**Assembly**: LXP\.Api\.dll

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("/lxp/enroll/{learnerId}/course/{courseId}/topic")]
public Microsoft.AspNetCore.Mvc.IActionResult GetCourseandTopicsByCourseId(Guid courseId, Guid learnerId)
```

### Parameters

**courseId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

