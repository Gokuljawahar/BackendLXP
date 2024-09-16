---
sidebar_label: GetFeedbackQuestionsByTopicId
---

# TopicFeedbackController\.GetFeedbackQuestionsByTopicId\(Guid\) Method

**Containing Type**: [TopicFeedbackController](../index.md)

**Assembly**: LXP\.Api\.dll

  
 Retrieve feedback questions by topic ID\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("topic/{topicId}")]
public Microsoft.AspNetCore.Mvc.IActionResult GetFeedbackQuestionsByTopicId(Guid topicId)
```

### Parameters

**topicId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the topic\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

