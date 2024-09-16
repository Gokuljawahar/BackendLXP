---
sidebar_label: GetTopicFeedbackResponses
---

# FeedbackResponseDetailsController\.GetTopicFeedbackResponses\(Guid\) Method

**Containing Type**: [FeedbackResponseDetailsController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves feedback responses for a specific topic by its ID\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("topic/{topicId}")]
public Microsoft.AspNetCore.Mvc.IActionResult GetTopicFeedbackResponses(Guid topicId)
```

### Parameters

**topicId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the topic\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

