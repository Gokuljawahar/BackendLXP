---
sidebar_label: GetCourseCompletionPercentage
---

# LearnerProgressController\.GetCourseCompletionPercentage\(Guid, Guid\) Method

**Containing Type**: [LearnerProgressController](../index.md)

**Assembly**: LXP\.Api\.dll

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("course-completion-percentage/{learnerId}/{enrollmentId}")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetCourseCompletionPercentage(Guid learnerId, Guid enrollmentId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**enrollmentId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

