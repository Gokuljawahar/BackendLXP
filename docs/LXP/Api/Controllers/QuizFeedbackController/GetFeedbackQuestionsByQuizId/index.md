---
sidebar_label: GetFeedbackQuestionsByQuizId
---

# QuizFeedbackController\.GetFeedbackQuestionsByQuizId\(Guid\) Method

**Containing Type**: [QuizFeedbackController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Get feedback questions by quiz ID

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("GetFeedbackQuestionsByQuizId/{quizId}")]
public Microsoft.AspNetCore.Mvc.IActionResult GetFeedbackQuestionsByQuizId(Guid quizId)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

Quiz ID

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

