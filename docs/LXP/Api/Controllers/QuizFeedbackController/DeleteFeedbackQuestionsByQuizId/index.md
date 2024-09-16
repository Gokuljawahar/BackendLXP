---
sidebar_label: DeleteFeedbackQuestionsByQuizId
---

# QuizFeedbackController\.DeleteFeedbackQuestionsByQuizId\(Guid\) Method

**Containing Type**: [QuizFeedbackController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Delete feedback questions by quiz ID

```csharp
[Microsoft.AspNetCore.Mvc.HttpDelete("DeleteFeedbackQuestionsByQuizId/{quizId}")]
public Microsoft.AspNetCore.Mvc.IActionResult DeleteFeedbackQuestionsByQuizId(Guid quizId)
```

### Parameters

**quizId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

Quiz ID

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpDeleteAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpdeleteattribute)

