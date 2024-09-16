---
sidebar_label: AddFeedbackQuestion
---

# TopicFeedbackController\.AddFeedbackQuestion\(TopicFeedbackQuestionViewModel\) Method

**Containing Type**: [TopicFeedbackController](../index.md)

**Assembly**: LXP\.Api\.dll

  
 Add a new feedback question\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("question")]
public Microsoft.AspNetCore.Mvc.IActionResult AddFeedbackQuestion(TopicFeedbackQuestionViewModel question)
```

### Parameters

**question** &ensp; TopicFeedbackQuestionViewModel

The feedback question to add\.

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

