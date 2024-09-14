---
sidebar_label: UpdateFeedbackQuestion
---

# TopicFeedbackController\.UpdateFeedbackQuestion\(Guid, TopicFeedbackQuestionViewModel\) Method

**Containing Type**: [TopicFeedbackController](../index.md)

**Assembly**: LXP\.Api\.dll

  
 Update an existing feedback question\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpPut("{topicFeedbackQuestionId}")]
public Microsoft.AspNetCore.Mvc.IActionResult UpdateFeedbackQuestion(Guid topicFeedbackQuestionId, LXP.Common.ViewModels.TopicFeedbackQuestionViewModel.TopicFeedbackQuestionViewModel question)
```

### Parameters

**topicFeedbackQuestionId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the feedback question to update\.

**question** &ensp; [TopicFeedbackQuestionViewModel](../../../../Common/ViewModels/TopicFeedbackQuestionViewModel/TopicFeedbackQuestionViewModel/index.md)

The updated feedback question\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpPutAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpputattribute)

