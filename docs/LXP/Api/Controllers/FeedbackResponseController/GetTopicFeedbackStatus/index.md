---
sidebar_label: GetTopicFeedbackStatus
---

# FeedbackResponseController\.GetTopicFeedbackStatus\(Guid, Guid\) Method

**Containing Type**: [FeedbackResponseController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves the feedback status of a topic for a specific learner\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("TopicFeedbackStatus")]
public Microsoft.AspNetCore.Mvc.IActionResult GetTopicFeedbackStatus(Guid learnerId, Guid topicId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the learner\.

**topicId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the topic\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

A response containing the topic feedback status for the learner\.

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

