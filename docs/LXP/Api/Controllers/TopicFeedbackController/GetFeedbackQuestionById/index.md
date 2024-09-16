---
sidebar_label: GetFeedbackQuestionById
---

# TopicFeedbackController\.GetFeedbackQuestionById\(Guid\) Method

**Containing Type**: [TopicFeedbackController](../index.md)

**Assembly**: LXP\.Api\.dll

  
 Retrieve a feedback question by its ID\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("{topicFeedbackQuestionId}")]
public Microsoft.AspNetCore.Mvc.IActionResult GetFeedbackQuestionById(Guid topicFeedbackQuestionId)
```

### Parameters

**topicFeedbackQuestionId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the feedback question\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

