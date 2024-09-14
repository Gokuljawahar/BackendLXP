---
sidebar_label: AddFeedbackQuestion
---

# TopicFeedbackController\.AddFeedbackQuestion\(TopicFeedbackQuestionViewModel\) Method

**Containing Type**: [TopicFeedbackController](../index.md)

**Assembly**: LXP\.Api\.dll

  
 Add a new feedback question\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("question")]
public Microsoft.AspNetCore.Mvc.IActionResult AddFeedbackQuestion(LXP.Common.ViewModels.TopicFeedbackQuestionViewModel.TopicFeedbackQuestionViewModel question)
```

### Parameters

**question** &ensp; [TopicFeedbackQuestionViewModel](../../../../Common/ViewModels/TopicFeedbackQuestionViewModel/TopicFeedbackQuestionViewModel/index.md)

The feedback question to add\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

