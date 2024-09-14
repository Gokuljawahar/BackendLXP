---
sidebar_label: GetTopicFeedbackResponsesByLearner
---

# FeedbackResponseDetailsController\.GetTopicFeedbackResponsesByLearner\(Guid, Guid\) Method

**Containing Type**: [FeedbackResponseDetailsController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Retrieves feedback responses for a specific topic and learner by their IDs\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("topic/{topicId}/learner/{learnerId}")]
public Microsoft.AspNetCore.Mvc.IActionResult GetTopicFeedbackResponsesByLearner(Guid topicId, Guid learnerId)
```

### Parameters

**topicId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the topic\.

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The unique identifier of the learner\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

