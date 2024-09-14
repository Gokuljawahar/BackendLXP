---
sidebar_label: DeleteFeedbackQuestion
---

# TopicFeedbackController\.DeleteFeedbackQuestion\(Guid\) Method

**Containing Type**: [TopicFeedbackController](../index.md)

**Assembly**: LXP\.Api\.dll

  
 Delete a feedback question\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpDelete("{topicFeedbackQuestionId}")]
public Microsoft.AspNetCore.Mvc.IActionResult DeleteFeedbackQuestion(Guid topicFeedbackQuestionId)
```

### Parameters

**topicFeedbackQuestionId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

The ID of the feedback question to delete\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpDeleteAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpdeleteattribute)

