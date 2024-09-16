---
sidebar_label: DeleteFeedbackQuestion
---

# QuizFeedbackController\.DeleteFeedbackQuestion\(Guid\) Method

**Containing Type**: [QuizFeedbackController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Delete a feedback question

```csharp
[Microsoft.AspNetCore.Mvc.HttpDelete("DeleteFeedbackQuestion/{quizFeedbackQuestionId}")]
public Microsoft.AspNetCore.Mvc.IActionResult DeleteFeedbackQuestion(Guid quizFeedbackQuestionId)
```

### Parameters

**quizFeedbackQuestionId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

Feedback question ID

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpDeleteAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpdeleteattribute)

