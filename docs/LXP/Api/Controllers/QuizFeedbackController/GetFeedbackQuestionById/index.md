---
sidebar_label: GetFeedbackQuestionById
---

# QuizFeedbackController\.GetFeedbackQuestionById\(Guid\) Method

**Containing Type**: [QuizFeedbackController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Get a feedback question by its ID

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("GetFeedbackQuestionById/{quizFeedbackQuestionId}")]
public Microsoft.AspNetCore.Mvc.IActionResult GetFeedbackQuestionById(Guid quizFeedbackQuestionId)
```

### Parameters

**quizFeedbackQuestionId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

Feedback question ID

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

