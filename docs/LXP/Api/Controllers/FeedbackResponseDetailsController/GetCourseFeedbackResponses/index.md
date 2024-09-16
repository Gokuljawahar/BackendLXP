---
sidebar_label: GetCourseFeedbackResponses
---

# FeedbackResponseDetailsController\.GetCourseFeedbackResponses\(Guid\) Method

**Containing Type**: [FeedbackResponseDetailsController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves feedback responses for a specific course by its ID\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("course/{courseId}")]
public Microsoft.AspNetCore.Mvc.IActionResult GetCourseFeedbackResponses(Guid courseId)
```

### Parameters

**courseId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the course\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

