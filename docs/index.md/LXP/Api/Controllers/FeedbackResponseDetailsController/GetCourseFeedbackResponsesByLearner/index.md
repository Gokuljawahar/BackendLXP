---
sidebar_label: GetCourseFeedbackResponsesByLearner
---

# FeedbackResponseDetailsController\.GetCourseFeedbackResponsesByLearner\(Guid, Guid\) Method

**Containing Type**: [FeedbackResponseDetailsController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves feedback responses for a specific course and learner by their IDs\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("course/{courseId}/learner/{learnerId}")]
public Microsoft.AspNetCore.Mvc.IActionResult GetCourseFeedbackResponsesByLearner(Guid courseId, Guid learnerId)
```

### Parameters

**courseId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the course\.

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the learner\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

